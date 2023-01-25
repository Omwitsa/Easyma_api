using MobileBanking_API.Models;
using MobileBanking_API.Utilities;
using MobileBanking_API.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
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
		public async Task<ReturnData> ProductIntake([FromBody] List<ProductIntakeVm> intakes)
		{
			try
			{
                var productIntakeBkps = new List<d_ProductIntakeBkp>();
                intakes.ForEach(i =>
                {
                    var transDate = Convert.ToDateTime(i.Dates);
                    decimal.TryParse(i.Qty, out decimal qty);
                    productIntakeBkps.Add(new d_ProductIntakeBkp
                    {
                        Sno = i.Sup,
                        Product = i.Product,
                        Qnty = qty,
                        Date = transDate,
                        TransCode = i.Auditid,
                        AuditDate = DateTime.Now
                    });
                });

                if (productIntakeBkps.Any())
                {
                    db.d_ProductIntakeBkp.AddRange(productIntakeBkps);
                    await db.SaveChangesAsync();
                }

                var intake = intakes.FirstOrDefault();
                var products = $"SELECT * FROM d_Price WHERE Products = '{intake.Product}' AND SaccoCode = '{intake.SaccoCode}'";
                var product = await db.Database.SqlQuery<d_Price>(products).FirstOrDefaultAsync();
                var productIntakes = new List<ProductIntake>();
                foreach(var productIntake in intakes)
                {
                    productIntake.Auditid = productIntake.Auditid ?? "";
                    productIntake.Auditid = productIntake.Auditid.ToUpper();
                    productIntake.Product = productIntake?.Product ?? "";

                    decimal.TryParse(productIntake.Qty, out decimal qty);
                    var balance = 0;
                    decimal? dr = 0;
                    decimal? cr = qty * product.Price;
                    var transDate = Convert.ToDateTime(productIntake.Dates);
                    productIntakes.Add(new ProductIntake
                    {
                        Sno = productIntake.Sup,
                        TransDate = transDate.Date,
                        TransTime = transDate.TimeOfDay,
                        ProductType = productIntake.Product,
                        QSupplied = qty,
                        PPU = product.Price,
                        CR = cr,
                        DR = dr,
                        Balance = balance,
                        Description = "Intake",
                        Paid = false,
                        Remarks = productIntake.Shift + "; Synch",
                        TransactionType = 1,
                        AuditId = productIntake.Auditid,
                        auditdatetime = DateTime.UtcNow.AddHours(3),
                        Branch = productIntake.Branchhh,
                        SaccoCode = productIntake.SaccoCode,
                        DrAccNo = product.DrAccNo,
                        CrAccNo = product.CrAccNo,
                    });

                    var query = $"SET DATEFORMAT YMD SELECT * FROM d_Transport WHERE Trans_Code = '{productIntake.Auditid}' AND sno = '{productIntake.Sup}' AND Active = 1 AND producttype = '{productIntake.Product}'";
                    var transport = await db.Database.SqlQuery<d_Transport>(query).FirstOrDefaultAsync();
                    if (transport == null)
                    {
                        query = $"SET DATEFORMAT YMD SELECT * FROM d_Transport WHERE Trans_Code = '{productIntake.Auditid}' AND Active = 1 AND producttype = '{productIntake.Product}'";
                        transport = await db.Database.SqlQuery<d_Transport>(query).FirstOrDefaultAsync();
                    }

                    decimal? rate = 0;
                    if (transport != null)
                        rate = transport.Rate;

                    // Debit supplier transport amount
                    dr = qty * rate;
                    cr = 0;
                    productIntakes.Add(new ProductIntake
                    {
                        Sno = productIntake.Sup,
                        TransDate = transDate.Date,
                        TransTime = transDate.TimeOfDay,
                        ProductType = productIntake.Product,
                        QSupplied = qty,
                        PPU = rate,
                        CR = cr,
                        DR = dr,
                        Balance = balance,
                        Description = "Transport",
                        Paid = false,
                        Remarks = productIntake.Shift + "; Synch",
                        TransactionType = 2,
                        AuditId = productIntake.Auditid,
                        auditdatetime = DateTime.UtcNow.AddHours(3),
                        Branch = productIntake.Branchhh,
                        SaccoCode = productIntake.SaccoCode,
                        DrAccNo = product.TransportCrAccNo,
                        CrAccNo = product.TransportDrAccNo,
                    });

                    // Credit transpoter transport amount
                    dr = 0;
                    cr = qty * rate;

                    productIntakes.Add(new ProductIntake
                    {
                        Sno = productIntake.Auditid,
                        TransDate = transDate.Date,
                        TransTime = transDate.TimeOfDay,
                        ProductType = productIntake.Product,
                        QSupplied = qty,
                        PPU = rate,
                        CR = cr,
                        DR = dr,
                        Balance = balance,
                        Description = "Transport",
                        Paid = false,
                        Remarks = productIntake.Shift + "; Synch",
                        TransactionType = 2,
                        AuditId = productIntake.Auditid,
                        auditdatetime = DateTime.UtcNow.AddHours(3),
                        Branch = productIntake.Branchhh,
                        SaccoCode = productIntake.SaccoCode,
                        DrAccNo = product.TransportDrAccNo,
                        CrAccNo = product.TransportCrAccNo,
                    });
                }

                //var startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                //var endDate = startDate.AddMonths(1).AddDays(-1);
                //var monthlyIntakes = await db.ProductIntakes.Where(s => s.SaccoCode == intake.SaccoCode
                //&& s.TransDate >= startDate && s.TransDate <= endDate).ToListAsync();

                //var supIntakes = productIntakes.GroupBy(i => i.Sno).ToList();
                //supIntakes.ForEach(i =>
                //{
                //    var suppliers = db.d_Suppliers.FirstOrDefault(s => s.SNo.ToString() == i.Key && s.scode == intake.SaccoCode);
                //    if (suppliers != null)
                //    {
                //        var qty = i.Sum(p => p.QSupplied);
                //        var commulated = monthlyIntakes.Where(m => m.Sno == i.Key).Sum(m => m.QSupplied);
                //        var content = $"You have supplied {qty} kgs to {intake.SaccoCode}. Your commulated {commulated + qty}";

                //        db.Messages.Add(new Message
                //        {
                //            Telephone = suppliers.PhoneNo,
                //            Content = content,
                //            ProcessTime = DateTime.UtcNow.AddHours(3).ToString(),
                //            MsgType = "Outbox",
                //            Replied = false,
                //            DateReceived = DateTime.UtcNow.AddHours(3),
                //            Source = intake.Auditid,
                //            Code = intake.SaccoCode
                //        });
                //    }
                //});
                db.ProductIntakes.AddRange(productIntakes);
                var result = await db.SaveChangesAsync();

                return new ReturnData
				{
					Success = true,
					Message = "Submitted Sucessfully",
                    Data = result
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

        [Route("getSuppliers")]
        public async Task<ReturnData> GetSuppliers(string transCode, string saccoCode)
        {
            try
            {
                saccoCode = saccoCode ?? "";
                transCode = transCode ?? "";
                var suppliers = await db.d_Suppliers
                    .Select(s => new SupplierVm
                    {
                        SNo = s.SNo,
                        Names = s.Names
                    }).ToListAsync();

                var startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                var intakes = await db.ProductIntakes.Where(s => s.SaccoCode == saccoCode
                && s.TransDate >= startDate && s.TransDate <= endDate && s.Description == "Intake").ToListAsync();

                suppliers.ForEach(s =>
                {
                    s.Cummulative = intakes.Where(i => i.Sno == s.SNo).Sum(i => i.QSupplied);
                });

                return new ReturnData
                {
                    Success = true,
                    Data = suppliers
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


