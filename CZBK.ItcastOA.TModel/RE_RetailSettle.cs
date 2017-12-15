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
    
    public partial class RE_RetailSettle
    {
        public string code { get; set; }
        public string name { get; set; }
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
        public Nullable<decimal> settleamount { get; set; }
        public Nullable<decimal> deductionrate { get; set; }
        public Nullable<byte> isauto { get; set; }
        public Nullable<decimal> totalSettleAmount { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public Nullable<decimal> totalTaxAmount { get; set; }
        public Nullable<decimal> totalSettleTax { get; set; }
        public Nullable<decimal> totalSettleTaxAmount { get; set; }
        public Nullable<decimal> wipechange { get; set; }
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
        public Nullable<decimal> UseStorageAmount { get; set; }
        public Nullable<decimal> IntegralStorageAmount { get; set; }
        public Nullable<decimal> PreReceiveAmount { get; set; }
        public Nullable<decimal> ConvertToStorageAmount { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public int ID { get; set; }
        public Nullable<int> idstore { get; set; }
        public Nullable<int> idmarketingorgan { get; set; }
        public Nullable<int> idcustomer { get; set; }
        public Nullable<int> idsettlecustomer { get; set; }
        public Nullable<int> idperson { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> branchstrikebalance { get; set; }
        public Nullable<int> datasource { get; set; }
        public Nullable<int> headquartersstrikebalance { get; set; }
        public Nullable<int> iscancle { get; set; }
        public Nullable<int> receivetype { get; set; }
        public Nullable<int> voucherstate { get; set; }
        public Nullable<int> auditorid { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> receivingmaturity { get; set; }
    }
}
