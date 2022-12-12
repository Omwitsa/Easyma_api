﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileBanking_API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MORINGADbEntities : DbContext
    {
        public MORINGADbEntities()
            : base("name=MORINGADbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<ag_Products> ag_Products { get; set; }
        public virtual DbSet<ag_Receipts> ag_Receipts { get; set; }
        public virtual DbSet<assetcode> assetcodes { get; set; }
        public virtual DbSet<asset> assets { get; set; }
        public virtual DbSet<B2CDisbursementResponse> B2CDisbursementResponse { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<BillJournal> BillJournals { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<CInvoiceDetail> CInvoiceDetails { get; set; }
        public virtual DbSet<CInvoiceJournal> CInvoiceJournals { get; set; }
        public virtual DbSet<CInvoice> CInvoices { get; set; }
        public virtual DbSet<clinic_stkpayresults> clinic_stkpayresults { get; set; }
        public virtual DbSet<CProduct> CProducts { get; set; }
        public virtual DbSet<CreditNoteDetail> CreditNoteDetails { get; set; }
        public virtual DbSet<CreditNoteJournal> CreditNoteJournals { get; set; }
        public virtual DbSet<CreditNote> CreditNotes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<d_Approve2> d_Approve2 { get; set; }
        public virtual DbSet<d_CashPay> d_CashPay { get; set; }
        public virtual DbSet<d_DCodes> d_DCodes { get; set; }
        public virtual DbSet<d_Debtors> d_Debtors { get; set; }
        public virtual DbSet<d_dispatch> d_dispatch { get; set; }
        public virtual DbSet<d_glposting> d_glposting { get; set; }
        public virtual DbSet<d_LPO> d_LPO { get; set; }
        public virtual DbSet<d_MainAccount> d_MainAccount { get; set; }
        public virtual DbSet<d_MaxShares> d_MaxShares { get; set; }
        public virtual DbSet<d_MilkQuality> d_MilkQuality { get; set; }
        public virtual DbSet<d_Payment> d_Payment { get; set; }
        public virtual DbSet<d_Price> d_Price { get; set; }
        public virtual DbSet<d_Receipts> d_Receipts { get; set; }
        public virtual DbSet<d_Requisition> d_Requisition { get; set; }
        public virtual DbSet<d_SMSCompany> d_SMSCompany { get; set; }
        public virtual DbSet<d_Suppliers> d_Suppliers { get; set; }
        public virtual DbSet<d_TransporterIntake> d_TransporterIntake { get; set; }
        public virtual DbSet<d_Transporters> d_Transporters { get; set; }
        public virtual DbSet<d_TransportersPayRoll> d_TransportersPayRoll { get; set; }
        public virtual DbSet<Deduction> Deductions { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dispatch> Dispatches { get; set; }
        public virtual DbSet<DRanx> DRanges { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GLSETUP> GLSETUPs { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<ProductIntake> ProductIntakes { get; set; }
        public virtual DbSet<Receiptno> Receiptnoes { get; set; }
        public virtual DbSet<RefundDetail> RefundDetails { get; set; }
        public virtual DbSet<RefundJournal> RefundJournals { get; set; }
        public virtual DbSet<Refund> Refunds { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<tbl_menus> tbl_menus { get; set; }
        public virtual DbSet<TBL_TFSCOSTCENTRES> TBL_TFSCOSTCENTRES { get; set; }
        public virtual DbSet<Transporter> Transporters { get; set; }
        public virtual DbSet<Transporters_> Transporters_ { get; set; }
        public virtual DbSet<Vender> Venders { get; set; }
        public virtual DbSet<VProduct> VProducts { get; set; }
        public virtual DbSet<ag_close> ag_close { get; set; }
        public virtual DbSet<Ag_ClosingStock> Ag_ClosingStock { get; set; }
        public virtual DbSet<ag_lpo> ag_lpo { get; set; }
        public virtual DbSet<ag_Moringaintake> ag_Moringaintake { get; set; }
        public virtual DbSet<ag_MoringaProducts> ag_MoringaProducts { get; set; }
        public virtual DbSet<ag_paging> ag_paging { get; set; }
        public virtual DbSet<ag_Products1> ag_Products1 { get; set; }
        public virtual DbSet<ag_Products3> ag_Products3 { get; set; }
        public virtual DbSet<ag_Products4> ag_Products4 { get; set; }
        public virtual DbSet<ag_Products5> ag_Products5 { get; set; }
        public virtual DbSet<ag_Receipts1> ag_Receipts1 { get; set; }
        public virtual DbSet<ag_Receipts3> ag_Receipts3 { get; set; }
        public virtual DbSet<ag_Receiptsalesrep> ag_Receiptsalesrep { get; set; }
        public virtual DbSet<ag_ReceiptsEnqury> ag_ReceiptsEnqury { get; set; }
        public virtual DbSet<ag_ReceiptsProcess> ag_ReceiptsProcess { get; set; }
        public virtual DbSet<ag_sales> ag_sales { get; set; }
        public virtual DbSet<ag_stockbalance> ag_stockbalance { get; set; }
        public virtual DbSet<ag_stockbalance1> ag_stockbalance1 { get; set; }
        public virtual DbSet<ag_supplier> ag_supplier { get; set; }
        public virtual DbSet<ag_Supplier1> ag_Supplier1 { get; set; }
        public virtual DbSet<AP> APs { get; set; }
        public virtual DbSet<assets_register> assets_register { get; set; }
        public virtual DbSet<assetstran> assetstrans { get; set; }
        public virtual DbSet<assetstrans1> assetstrans1 { get; set; }
        public virtual DbSet<assetstrans2> assetstrans2 { get; set; }
        public virtual DbSet<AUDITTABLE> AUDITTABLEs { get; set; }
        public virtual DbSet<AUDITTRAN> AUDITTRANS { get; set; }
        public virtual DbSet<AUDITTRANS1> AUDITTRANS1 { get; set; }
        public virtual DbSet<B2CPaymentDummy> B2CPaymentDummy { get; set; }
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<BankRecon> BankRecons { get; set; }
        public virtual DbSet<BANK> BANKS { get; set; }
        public virtual DbSet<barcodedsale> barcodedsales { get; set; }
        public virtual DbSet<barcodeitem> barcodeitems { get; set; }
        public virtual DbSet<Blacklist> Blacklists { get; set; }
        public virtual DbSet<BOOKING> BOOKINGS { get; set; }
        public virtual DbSet<BUDGET> BUDGETS { get; set; }
        public virtual DbSet<CASHB> CASHBs { get; set; }
        public virtual DbSet<CASHBOOK> CASHBOOKs { get; set; }
        public virtual DbSet<CashbookTransaction> CashbookTransactions { get; set; }
        public virtual DbSet<CHEQUE> CHEQUES { get; set; }
        public virtual DbSet<COMBINE> COMBINEs { get; set; }
        public virtual DbSet<CONTRIB> CONTRIBs { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<CUB> CUBs { get; set; }
        public virtual DbSet<Curr> Currs { get; set; }
        public virtual DbSet<CustomerBalance> CustomerBalances { get; set; }
        public virtual DbSet<CUSTOMERBALANCEOLD> CUSTOMERBALANCEOLDs { get; set; }
        public virtual DbSet<d_Approve1> d_Approve1 { get; set; }
        public virtual DbSet<d_AssignmentVehicle> d_AssignmentVehicle { get; set; }
        public virtual DbSet<d_BankBranch> d_BankBranch { get; set; }
        public virtual DbSet<d_BANKS> d_BANKS { get; set; }
        public virtual DbSet<d_Bonus> d_Bonus { get; set; }
        public virtual DbSet<d_Bonus2> d_Bonus2 { get; set; }
        public virtual DbSet<d_Branch> d_Branch { get; set; }
        public virtual DbSet<d_BranchProduct> d_BranchProduct { get; set; }
        public virtual DbSet<d_branchsalesman> d_branchsalesman { get; set; }
        public virtual DbSet<d_CashShares> d_CashShares { get; set; }
        public virtual DbSet<d_changepro> d_changepro { get; set; }
        public virtual DbSet<d_company> d_company { get; set; }
        public virtual DbSet<d_CType> d_CType { get; set; }
        public virtual DbSet<d_DailySummary> d_DailySummary { get; set; }
        public virtual DbSet<d_DailySummaryClerk> d_DailySummaryClerk { get; set; }
        public virtual DbSet<d_Debtors2> d_Debtors2 { get; set; }
        public virtual DbSet<d_Debtorsparchases2> d_Debtorsparchases2 { get; set; }
        public virtual DbSet<d_Districts> d_Districts { get; set; }
        public virtual DbSet<d_Headers> d_Headers { get; set; }
        public virtual DbSet<d_incomestate> d_incomestate { get; set; }
        public virtual DbSet<d_Invoice> d_Invoice { get; set; }
        public virtual DbSet<d_Location> d_Location { get; set; }
        public virtual DbSet<d_M_QSettings> d_M_QSettings { get; set; }
        public virtual DbSet<d_MilkControl> d_MilkControl { get; set; }
        public virtual DbSet<d_MilkControl1> d_MilkControl1 { get; set; }
        public virtual DbSet<d_Milkintake> d_Milkintake { get; set; }
        public virtual DbSet<d_Milkintake_BACKUP> d_Milkintake_BACKUP { get; set; }
        public virtual DbSet<d_Milkintake1> d_Milkintake1 { get; set; }
        public virtual DbSet<d_Milkintake2> d_Milkintake2 { get; set; }
        public virtual DbSet<d_milkintakechange> d_milkintakechange { get; set; }
        public virtual DbSet<d_MilkVehicle> d_MilkVehicle { get; set; }
        public virtual DbSet<d_Mpayement> d_Mpayement { get; set; }
        public virtual DbSet<d_Outlet> d_Outlet { get; set; }
        public virtual DbSet<d_Outletbranch> d_Outletbranch { get; set; }
        public virtual DbSet<d_OutletDispatch> d_OutletDispatch { get; set; }
        public virtual DbSet<d_OutletSales> d_OutletSales { get; set; }
        public virtual DbSet<d_Outletstock> d_Outletstock { get; set; }
        public virtual DbSet<d_OutletVehicle> d_OutletVehicle { get; set; }
        public virtual DbSet<d_Outsales> d_Outsales { get; set; }
        public virtual DbSet<d_Outsalesb> d_Outsalesb { get; set; }
        public virtual DbSet<d_PaymentReq> d_PaymentReq { get; set; }
        public virtual DbSet<d_Payroll> d_Payroll { get; set; }
        public virtual DbSet<d_PayrollCopy> d_PayrollCopy { get; set; }
        public virtual DbSet<d_Periods> d_Periods { get; set; }
        public virtual DbSet<d_PreSets> d_PreSets { get; set; }
        public virtual DbSet<d_Price2> d_Price2 { get; set; }
        public virtual DbSet<d_PriceBranch> d_PriceBranch { get; set; }
        public virtual DbSet<d_Quality> d_Quality { get; set; }
        public virtual DbSet<d_Registration> d_Registration { get; set; }
        public virtual DbSet<d_sconribution> d_sconribution { get; set; }
        public virtual DbSet<d_Shares> d_Shares { get; set; }
        public virtual DbSet<d_smssettings> d_smssettings { get; set; }
        public virtual DbSet<d_supplier_deduc> d_supplier_deduc { get; set; }
        public virtual DbSet<d_supplier_standingorder> d_supplier_standingorder { get; set; }
        public virtual DbSet<d_SupplyDeducTrans> d_SupplyDeducTrans { get; set; }
        public virtual DbSet<d_tbl_trends> d_tbl_trends { get; set; }
        public virtual DbSet<d_tmpEnquery> d_tmpEnquery { get; set; }
        public virtual DbSet<d_tmpTransEnquery> d_tmpTransEnquery { get; set; }
        public virtual DbSet<d_trans_frate> d_trans_frate { get; set; }
        public virtual DbSet<d_TransDetailed> d_TransDetailed { get; set; }
        public virtual DbSet<d_TransMode> d_TransMode { get; set; }
        public virtual DbSet<d_Transport> d_Transport { get; set; }
        public virtual DbSet<d_Transport_Deduc> d_Transport_Deduc { get; set; }
        public virtual DbSet<d_transport_standingorder> d_transport_standingorder { get; set; }
        public virtual DbSet<d_Type> d_Type { get; set; }
        public virtual DbSet<d_VehicleTill> d_VehicleTill { get; set; }
        public virtual DbSet<DispatchBalancing> DispatchBalancings { get; set; }
        public virtual DbSet<DRAWNSTOCK> DRAWNSTOCKs { get; set; }
        public virtual DbSet<EasyMa_policies> EasyMa_policies { get; set; }
        public virtual DbSet<EmpBenefit> EmpBenefits { get; set; }
        public virtual DbSet<EmployeesDed> EmployeesDeds { get; set; }
        public virtual DbSet<EntitlementType> EntitlementTypes { get; set; }
        public virtual DbSet<ExcelDump> ExcelDumps { get; set; }
        public virtual DbSet<FLMD> FLMDs { get; set; }
        public virtual DbSet<FLMDCrop> FLMDCrops { get; set; }
        public virtual DbSet<FLMDLand> FLMDLands { get; set; }
        public virtual DbSet<GLedger> GLedgers { get; set; }
        public virtual DbSet<GLTRANSACTION> GLTRANSACTIONS { get; set; }
        public virtual DbSet<GLTRANSACTIONS2> GLTRANSACTIONS2 { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Journalslisting> Journalslistings { get; set; }
        public virtual DbSet<JournalType> JournalTypes { get; set; }
        public virtual DbSet<LOGIN> LOGINS { get; set; }
        public virtual DbSet<Matchedreport> Matchedreports { get; set; }
        public virtual DbSet<milkcontrol2> milkcontrol2 { get; set; }
        public virtual DbSet<Milktransfer> Milktransfers { get; set; }
        public virtual DbSet<Mpesab> Mpesabs { get; set; }
        public virtual DbSet<param> @params { get; set; }
        public virtual DbSet<passwordhistory> passwordhistories { get; set; }
        public virtual DbSet<PaymentBooking> PaymentBookings { get; set; }
        public virtual DbSet<PaySlip> PaySlips { get; set; }
        public virtual DbSet<PERIOD> PERIODS { get; set; }
        public virtual DbSet<PettyCash> PettyCashes { get; set; }
        public virtual DbSet<QBMP> QBMPS { get; set; }
        public virtual DbSet<Qsetup> Qsetups { get; set; }
        public virtual DbSet<ReceiptBooking> ReceiptBookings { get; set; }
        public virtual DbSet<reportpath> reportpaths { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<serialno> serialnoes { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<SharesCategory> SharesCategories { get; set; }
        public virtual DbSet<sisold> sisolds { get; set; }
        public virtual DbSet<SMSSubscription> SMSSubscriptions { get; set; }
        public virtual DbSet<sno> snoes { get; set; }
        public virtual DbSet<StandingOrder> StandingOrders { get; set; }
        public virtual DbSet<SubCounty> SubCounties { get; set; }
        public virtual DbSet<Swift_Messages> Swift_Messages { get; set; }
        public virtual DbSet<SYSPARAM> SYSPARAMs { get; set; }
        public virtual DbSet<tbbalance> tbbalances { get; set; }
        public virtual DbSet<tbl_usermenus> tbl_usermenus { get; set; }
        public virtual DbSet<Tchp_Rate> Tchp_Rate { get; set; }
        public virtual DbSet<TEMPCASHBOOK> TEMPCASHBOOKs { get; set; }
        public virtual DbSet<tempGlTransaction> tempGlTransactions { get; set; }
        public virtual DbSet<TEMTTBBALANCE> TEMTTBBALANCEs { get; set; }
        public virtual DbSet<TMPCASHBOOK> TMPCASHBOOKs { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransCode> TransCodes { get; set; }
        public virtual DbSet<TransportersBalancing> TransportersBalancings { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserAccounts1> UserAccounts1 { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
    }
}
