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
    
    public partial class ME_IntegralForGift
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<decimal> memberintegral { get; set; }
        public Nullable<decimal> thistotalintegral { get; set; }
        public Nullable<decimal> integralbalance { get; set; }
        public Nullable<byte> autooutstock { get; set; }
        public string docno { get; set; }
        public string docclass { get; set; }
        public Nullable<int> accountingperiod { get; set; }
        public string docid { get; set; }
        public Nullable<int> accountingyear { get; set; }
        public string memo { get; set; }
        public string maker { get; set; }
        public string auditor { get; set; }
        public string reviser { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public int id { get; set; }
        public Nullable<int> idmember { get; set; }
        public Nullable<int> idmemberType { get; set; }
        public Nullable<int> idstore { get; set; }
        public Nullable<int> idmarketingOrgan { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idwarehouse { get; set; }
        public Nullable<int> outstockstate { get; set; }
        public Nullable<int> voucherstate { get; set; }
        public Nullable<int> auditorid { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
