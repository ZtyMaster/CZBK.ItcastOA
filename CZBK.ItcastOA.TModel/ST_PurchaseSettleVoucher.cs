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
    
    public partial class ST_PurchaseSettleVoucher
    {
        public string code { get; set; }
        public string memo { get; set; }
        public Nullable<decimal> sumSettleAmount { get; set; }
        public Nullable<int> createType { get; set; }
        public string maker { get; set; }
        public string auditor { get; set; }
        public string reviser { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public string docno { get; set; }
        public string docclass { get; set; }
        public string docid { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public int id { get; set; }
        public Nullable<int> idbusitype { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> IdMarketingOrgan { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idclerk { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> voucherState { get; set; }
        public Nullable<int> auditorid { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<int> idvouchertype { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
