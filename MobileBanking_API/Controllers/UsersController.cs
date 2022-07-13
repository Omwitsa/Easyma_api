using MobileBanking_API.Models;
using MobileBanking_API.Utilities;
using MobileBanking_API.ViewModel;
using System;
using System.Linq;
using System.Web.Http;

namespace MobileBanking_API.Controllers
{
	[RoutePrefix("webservice/users")]
	public class UsersController : ApiController
	{
		MORINGADbEntities db;
		public UsersController()
		{
			db = new MORINGADbEntities();
		}

		[Route("login")]
		public ReturnData PosAdmin([FromBody] SyncData syncData)
		{
			try
			{
				syncData.Product = syncData?.Product ?? "";
				var milkTime = $"set dateformat ymd Select auditdatetime from d_Milkintake where auditdatetime='{syncData.dates}'and QSupplied='{syncData.qty}' and SNo='{syncData.sup}'";
				var milkintakeTime = db.Database.SqlQuery<String>(milkTime).FirstOrDefault();

				if (String.IsNullOrEmpty(milkintakeTime))
				{
					var milkPrice = $"SELECT Price FROM d_price where products = '{syncData.Product}'";
					var milkkPrice = db.Database.SqlQuery<Decimal>(milkPrice).FirstOrDefault();
					double doubleValue = decimal.ToDouble(milkkPrice);
					double value = Convert.ToDouble(syncData.qty);
					double Milkprice = value * doubleValue;
					var inserttransactions = $"set dateformat ymd INSERT INTO d_Milkintake(SNo,TransDate,QSupplied,auditdatetime,LOCATION,AuditId,PPU,PAmount,Transtime, Type)values('{syncData.sup}','{syncData.dates}','{syncData.qty}','{syncData.dates}','{syncData.branchhh}','{syncData.auditid}','{milkkPrice}','{Milkprice}','{DateTime.Now.ToShortTimeString()}', '{syncData.Product}')";
					db.Database.ExecuteSqlCommand(inserttransactions);
					return new ReturnData
					{
						Success = true,
						Message = "Sucess"
					};
				}
				else 
				{
					return new ReturnData
					{
						Success = true,
						Message = "False"
					};
				}
			}

			catch (Exception ex)
			{
				return new ReturnData
				{
					Success = false,
					Message = "Sorry, An error occurred,Contact Administrator"
				};
			}
		}

		[Route("registerSupplier")]
		public ReturnData RegisterSupplier([FromBody] Supplier supplier)
        {
            try
            {
				if (supplier == null)
					return new ReturnData
					{
						Success = false,
						Message = "Sorry, Kindly provide the supplier"
					};

				if (supplier.SNo < 1)
					return new ReturnData
					{
						Success = false,
						Message = "Sorry, Kindly provide supplier No."
					};

				if (string.IsNullOrEmpty(supplier.Names))
					return new ReturnData
					{
						Success = false,
						Message = "Sorry, Kindly provide supplier Names."
					};

				if (string.IsNullOrEmpty(supplier.IdNo))
					return new ReturnData
					{
						Success = false,
						Message = "Sorry, Kindly provide supplier Id No."
					};

				if (db.d_Suppliers.Any(s => s.SNo == supplier.SNo))
					return new ReturnData
					{
						Success = false,
						Message = "Sorry, Supplier No. already exist"
					};

				db.d_Suppliers.Add(new d_Suppliers { 
					SNo = supplier.SNo,
					Names = supplier.Names,
					IdNo = supplier.IdNo,
					PhoneNo = supplier.PhoneNo,
					Email = supplier.Email,
					Branch = supplier.Branch,
					BBranch = supplier.BBranch,
					Address = supplier.Address,
					Town = supplier.Town,
					District = supplier.District,
					Division = supplier.Division,
					Location = supplier.Location,
					Village = supplier.Village,
					dob = supplier.dob,
					Regdate = supplier.Regdate,
					Br = "A",
					freezed = "0",
					mass = "0"
				});

				db.SaveChanges();
				return new ReturnData
				{
					Success = true,
					Message = "Sucess"
				};
			}
            catch (Exception ex)
            {
				return new ReturnData
				{
					Success = false,
					Message = "Sorry, An error occurred"
				};
			}
        }

		[Route("getItems")]
		public ReturnData GetItems()
        {
            try
            {
				var query = "SELECT Products FROM d_Price";
				var prices = db.Database.SqlQuery<string>(query).ToList();
				return new ReturnData
				{
					Success = true,
					Data = prices
				};
            }
            catch (Exception)
            {
				return new ReturnData
				{
					Success = false,
					Message = "Sorry, An error occurred,Contact Administrator"
				};
			}
        }

		[Route("getSupplierNo")]
		public ReturnData GetSupplierNo()
		{
			try
			{
				var recentSupplierNo = db.d_Suppliers.ToList()
					.OrderByDescending(s => s.SNo)
					.Select(s => s.SNo).FirstOrDefault();

				return new ReturnData
				{
					Success = true,
					Data = recentSupplierNo + 1
				};
			}
			catch (Exception)
			{
				return new ReturnData
				{
					Success = false,
					Message = "Sorry, An error occurred,Contact Administrator"
				};
			}
		}
	}



}


