//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CZBK.ItcastOA.TModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CS_IncomeVoucher
    {
        public string code { get; set; }
        public string memo { get; set; }
        public Nullable<decimal> exchangeRate { get; set; }
        public Nullable<decimal> origAmount { get; set; }
        public string invoiceCode { get; set; }
        public string sourceVoucherCode { get; set; }
        public Nullable<decimal> origTaxAmountSum { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> taxAmountSum { get; set; }
        public string maker { get; set; }
        public string auditor { get; set; }
        public string reviser { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public string docid { get; set; }
        public byte[] ts { get; set; }
        public string priuserdefnvc1 { get; set; }
        public Nullable<decimal> priuserdefdecm1 { get; set; }
        public string priuserdefnvc2 { get; set; }
        public Nullable<decimal> priuserdefdecm2 { get; set; }
        public string priuserdefnvc3 { get; set; }
        public Nullable<decimal> priuserdefdecm3 { get; set; }
        public string priuserdefnvc4 { get; set; }
        public Nullable<decimal> priuserdefdecm4 { get; set; }
        public string priuserdefnvc5 { get; set; }
        public Nullable<decimal> priuserdefdecm5 { get; set; }
        public string priuserdefnvc6 { get; set; }
        public Nullable<decimal> priuserdefdecm6 { get; set; }
        public string pubuserdefnvc1 { get; set; }
        public Nullable<decimal> pubuserdefdecm1 { get; set; }
        public string pubuserdefnvc2 { get; set; }
        public Nullable<decimal> pubuserdefdecm2 { get; set; }
        public string pubuserdefnvc3 { get; set; }
        public Nullable<decimal> pubuserdefdecm3 { get; set; }
        public string pubuserdefnvc4 { get; set; }
        public Nullable<decimal> pubuserdefdecm4 { get; set; }
        public string pubuserdefnvc5 { get; set; }
        public Nullable<decimal> pubuserdefdecm5 { get; set; }
        public string pubuserdefnvc6 { get; set; }
        public Nullable<decimal> pubuserdefdecm6 { get; set; }
        public Nullable<decimal> origpaymentamount { get; set; }
        public Nullable<decimal> paymentamount { get; set; }
        public string saleordercode { get; set; }
        public int PrintCount { get; set; }
        public int backgroundCreateVoucher { get; set; }
        public int ID { get; set; }
        public Nullable<int> idbusinesstype { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> IdStore { get; set; }
        public Nullable<int> IdMarketingOrgan { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idclerk { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> IdSettleStyle { get; set; }
        public Nullable<int> IdBankAccount { get; set; }
        public Nullable<int> billType { get; set; }
        public Nullable<int> voucherSettleState { get; set; }
        public Nullable<int> voucherstate { get; set; }
        public Nullable<int> auditorid { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<int> sourceVoucherID { get; set; }
        public Nullable<int> saleorderid { get; set; }
        public Nullable<int> idsourcevouchertype { get; set; }
        public Nullable<System.DateTime> arrivalDate { get; set; }
        public Nullable<System.DateTime> oldVoucherDate { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
    }
}
