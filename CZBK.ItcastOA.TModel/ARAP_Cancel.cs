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
    
    public partial class ARAP_Cancel
    {
        public int ID { get; set; }
        public string code { get; set; }
        public Nullable<int> IdCancelType { get; set; }
        public Nullable<decimal> origCurrentTotalAmount { get; set; }
        public Nullable<decimal> currentTotalAmount { get; set; }
        public Nullable<decimal> exchangeRate { get; set; }
        public Nullable<byte> isauto { get; set; }
        public string sourcevouchercode { get; set; }
        public Nullable<int> sourcevoucherid { get; set; }
        public string docid { get; set; }
        public Nullable<int> voucherstate { get; set; }
        public string memo { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public string maker { get; set; }
        public string auditor { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<int> auditorid { get; set; }
        public string reviser { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> idperson { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> idfirstpartner { get; set; }
        public byte[] ts { get; set; }
        public Nullable<int> idsecondpartner { get; set; }
        public Nullable<int> idbusitype { get; set; }
        public string priuserdefnvc1 { get; set; }
        public Nullable<int> idsourcevouchertype { get; set; }
        public int PrintCount { get; set; }
        public Nullable<int> IdMarketingOrgan { get; set; }
    }
}
