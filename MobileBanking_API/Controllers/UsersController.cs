using MobileBanking_API.Models;
using MobileBanking_API.Utilities;
using MobileBanking_API.ViewModel;
using System;
using System.Collections.Generic;
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

		[Route("productIntake")]
		public ReturnData ProductIntake([FromBody] List<ProductIntake> intakes)
		{
			try
			{
				var intake = intakes.FirstOrDefault();
                var products = $"SELECT * FROM d_Price WHERE Products = '{intake.Product}' AND SaccoCode = '{intake.SaccoCode}'";
                var product = db.Database.SqlQuery<d_Price>(products).FirstOrDefault();
                intakes.ForEach(i =>
				{
                    i.Auditid = i.Auditid ?? "";
                    i.Auditid = i.Auditid.ToUpper();
                    i.Product = i?.Product ?? "";

                    decimal.TryParse(i.Qty, out decimal qty);
                    var balance = 0;
                    decimal? dr = 0;
                    decimal? cr = qty * product.Price;

                    var transDate = Convert.ToDateTime(i.Dates);
                    var inserttransactions = $"SET DATEFORMAT YMD INSERT INTO ProductIntake([Sno],[TransDate],[TransTime],[ProductType],[QSupplied],[PPU],[CR],[DR],[Balance],[Description],[Paid],[Remarks],[TransactionType],[AuditId],[auditdatetime],[Branch],[SaccoCode],[DrAccNo],[CrAccNo]) " +
                        $"VALUES('{i.Sup}','{transDate.Date}','{transDate.TimeOfDay}','{i.Product}','{qty}','{product.Price}','{cr}','{dr}','{balance}','Intake',0,'Sych','1','{i.Auditid}',GETDATE(),'{i.Branchhh}','{i.SaccoCode}','{product.DrAccNo}','{product.CrAccNo}')";
                    db.Database.ExecuteSqlCommand(inserttransactions);

                    var query = $"SET DATEFORMAT YMD SELECT * FROM d_Transport WHERE Trans_Code = '{i.Auditid}' AND sno = '{i.Sup}' AND Active = 1 AND producttype = '{i.Product}'";
                    var transport = db.Database.SqlQuery<d_Transport>(query).FirstOrDefault();
                    if (transport == null)
                    {
                        query = $"SET DATEFORMAT YMD SELECT * FROM d_Transport WHERE Trans_Code = '{i.Auditid}' AND Active = 1 AND producttype = '{i.Product}'";
                        transport = db.Database.SqlQuery<d_Transport>(query).FirstOrDefault();
                    }

                    decimal? rate = 0;
                    if (transport != null)
                        rate = transport.Rate;

                    // Debit supplier transport amount
                    dr = qty * rate;
                    cr = 0;
                    inserttransactions = $"SET DATEFORMAT YMD INSERT INTO ProductIntake([Sno],[TransDate],[TransTime],[ProductType],[QSupplied],[PPU],[CR],[DR],[Balance],[Description],[Paid],[Remarks],[TransactionType],[AuditId],[auditdatetime],[Branch],[SaccoCode],[DrAccNo],[CrAccNo]) " +
                        $"VALUES('{i.Sup}','{transDate.Date}','{transDate.TimeOfDay}','{i.Product}','{qty}','{rate}','{cr}','{dr}','{balance}','Transport',0,'Sych','2','{i.Auditid}',GETDATE(),'{i.Branchhh}','{i.SaccoCode}','{product.TransportCrAccNo}','{product.TransportDrAccNo}')";
                    db.Database.ExecuteSqlCommand(inserttransactions);

                    // Credit transpoter transport amount
                    dr = 0;
                    cr = qty * rate;
                    inserttransactions = $"SET DATEFORMAT YMD INSERT INTO ProductIntake([Sno],[TransDate],[TransTime],[ProductType],[QSupplied],[PPU],[CR],[DR],[Balance],[Description],[Paid],[Remarks],[TransactionType],[AuditId],[auditdatetime],[Branch],[SaccoCode],[DrAccNo],[CrAccNo]) " +
                        $"VALUES('{i.Auditid}','{transDate.Date}','{transDate.TimeOfDay}','{i.Product}','{qty}','{rate}','{cr}','{dr}','{balance}','Transport',0,'Sych','2','{i.Auditid}',GETDATE(),'{i.Branchhh}','{i.SaccoCode}','{product.TransportDrAccNo}','{product.TransportCrAccNo}')";
                    db.Database.ExecuteSqlCommand(inserttransactions);

                    var startDate = new DateTime(transDate.Year, transDate.Month, 1);
                    var endDate = startDate.AddMonths(1).AddDays(-1);
                    var commulated = db.ProductIntakes.Where(s => s.Sno == i.Sup && s.SaccoCode == i.SaccoCode
                    && s.TransDate >= startDate && s.TransDate <= endDate).Sum(s => s.QSupplied);
                    var suppliers = db.d_Suppliers.FirstOrDefault(s => s.SNo.ToString() == i.Sup && s.scode == i.SaccoCode);
                    var content = $"You have supplied {qty} kgs to {i.SaccoCode}. Your commulated {commulated + qty}";

                    if (suppliers != null)
                    {
                        var insertMessageQuery = $"INSERT INTO Messages(Telephone, [Content], ProcessTime, MsgType, Replied, DateReceived, Source, Code) " +
                        $"VALUES('{suppliers.PhoneNo}', '{content}', GETDATE(), 'Outbox', 0, GETDATE(), '{i.Auditid}', '{i.SaccoCode}')";
                        db.Database.ExecuteSqlCommand(insertMessageQuery);
                    }
                });

                return new ReturnData
				{
					Success = true,
					Message = "Submitted Sucessfully"
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
		
		[Route("registerSupplier")]
		public ReturnData RegisterSupplier([FromBody] Supplier supplier)
        {
            try
            {
				string sno = supplier.SNo + "";
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

				if (db.d_Suppliers.Any(s => s.SNo == sno))
					return new ReturnData
					{
						Success = false,
						Message = "Sorry, Supplier No. already exist"
					};

				db.d_Suppliers.Add(new d_Suppliers { 
					SNo = sno,
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

        [Route("transporterIntake")]
        public ReturnData TransporterIntake([FromBody] List<d_TransporterIntake> intakes)
        {
            try
            {
				intakes.ForEach(i =>
				{
                    i.Branch = i?.Branch ?? "";
                    i.AuditDate = DateTime.Now;
                });
                
                db.d_TransporterIntake.AddRange(intakes);
				db.SaveChanges();
				return new ReturnData
				{
					Success = true,
					Message = "Submitted Successfully"
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

    }



}


