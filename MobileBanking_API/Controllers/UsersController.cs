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
				var supplier = $"SET DATEFORMAT YMD SELECT Sno FROM ProductIntake WHERE Sno = '{syncData.Sup}' AND TransDate = '{syncData.Dates}' AND QSupplied = '{syncData.Qty}' AND ProductType = '{syncData.Product}' AND SaccoCode = '{syncData.SaccoCode}'";
				var supplierNo = db.Database.SqlQuery<String>(supplier).FirstOrDefault();

				if (String.IsNullOrEmpty(supplierNo))
				{
					var products = $"SELECT * FROM d_Price WHERE Products = '{syncData.Product}' AND SaccoCode = '{syncData.SaccoCode}'";
					var product = db.Database.SqlQuery<d_Price>(products).FirstOrDefault();
					decimal.TryParse(syncData.Qty, out decimal qty);
					var productPrice = qty * product.Price;
					var balance = GetBalance(new ProductIntake
					{
						Sno = syncData.Sup,
						SaccoCode = syncData.SaccoCode,
						CR = productPrice,
						DR = 0
					});

					var transDate = Convert.ToDateTime(syncData.Dates);
					var inserttransactions = $"SET DATEFORMAT YMD INSERT INTO ProductIntake([Sno],[TransDate],[TransTime],[ProductType],[QSupplied],[PPU],[CR],[DR],[Balance],[Description],[Paid],[Remarks],[TransactionType],[AuditId],[auditdatetime],[Branch],[SaccoCode],[DrAccNo],[CrAccNo]) " +
                        $"VALUES('{syncData.Sup}','{transDate.Date}','{transDate.TimeOfDay}','{syncData.Product}','{qty}','{product.Price}','{productPrice}','0','{balance}','Intake',0,'Uploaded','1','{syncData.Auditid}',GETDATE(),'{syncData.Branchhh}','{syncData.SaccoCode}','{product.DrAccNo}','{product.CrAccNo}')";
					db.Database.ExecuteSqlCommand(inserttransactions);

					var startDate = new DateTime(transDate.Year, transDate.Month, 1);
					var endDate = startDate.AddMonths(1).AddDays(-1);
					var commulated = db.ProductIntakes.Where(s => s.Sno == syncData.Sup && s.SaccoCode == syncData.SaccoCode
					&& s.TransDate >= startDate && s.TransDate <= endDate).Sum(s => s.QSupplied);
					var suppliers = db.d_Suppliers.FirstOrDefault(s => s.SNo.ToString() == syncData.Sup && s.scode == syncData.SaccoCode);
					db.Messages.Add(new Message
					{
						Telephone = suppliers.PhoneNo,
						Content = $"You have supplied {qty} kgs. Your commulated {commulated}",
						ProcessTime = DateTime.Now.ToString(),
						MsgType = "Outbox",
						Replied = false,
						DateReceived = DateTime.Now,
						Source = syncData.Auditid,
						Code = syncData.SaccoCode
					});

					db.SaveChanges();

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

		private decimal? GetBalance(ProductIntake productIntake)
		{
			var latestIntake = db.ProductIntakes.Where(i => i.Sno == productIntake.Sno && i.SaccoCode.ToUpper().Equals(productIntake.SaccoCode.ToUpper()))
					.OrderByDescending(i => i.Id).FirstOrDefault();
			if (latestIntake == null)
				latestIntake = new ProductIntake();
			latestIntake.Balance = latestIntake?.Balance ?? 0;
			productIntake.DR = productIntake?.DR ?? 0;
			productIntake.CR = productIntake?.CR ?? 0;
			var balance = latestIntake.Balance + productIntake.CR - productIntake.DR;
			return balance;
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
		public ReturnData GetItems(string saccoCode)
        {
            try
            {
				var query = "SELECT Products FROM d_Price WHERE SaccoCode = '" + saccoCode + "'";
				var prices = db.Database.SqlQuery<string>(query).ToList();
				return new ReturnData
				{
					Success = true,
					Data = prices
				};
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


