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
    
    public partial class RE_RetailSettle_b
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public Nullable<byte> ispresent { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public Nullable<decimal> retailprice { get; set; }
        public Nullable<decimal> discountrate { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> taxrate { get; set; }
        public Nullable<decimal> taxprice { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> taxamount { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<decimal> deductionrate { get; set; }
        public Nullable<decimal> settleamount { get; set; }
        public Nullable<decimal> settleTax { get; set; }
        public Nullable<decimal> settleTaxAmount { get; set; }
        public Nullable<decimal> totalsettleamount { get; set; }
        public Nullable<decimal> expenseamount { get; set; }
        public Nullable<decimal> wipechange { get; set; }
        public Nullable<byte> issource { get; set; }
        public Nullable<byte> taxflag { get; set; }
        public byte[] ts { get; set; }
        public string priuserdefnvc0 { get; set; }
        public Nullable<decimal> priuserdefdecm0 { get; set; }
        public string priuserdefnvc1 { get; set; }
        public Nullable<decimal> priuserdefdecm1 { get; set; }
        public string priuserdefnvc2 { get; set; }
        public Nullable<decimal> priuserdefdecm2 { get; set; }
        public string priuserdefnvc3 { get; set; }
        public Nullable<decimal> priuserdefdecm3 { get; set; }
        public string priuserdefnvc4 { get; set; }
        public Nullable<decimal> priuserdefdecm4 { get; set; }
        public string pubuserdefnvc1 { get; set; }
        public Nullable<decimal> pubuserdefdecm1 { get; set; }
        public string pubuserdefnvc2 { get; set; }
        public Nullable<decimal> pubuserdefdecm2 { get; set; }
        public string pubuserdefnvc3 { get; set; }
        public Nullable<decimal> pubuserdefdecm3 { get; set; }
        public string pubuserdefnvc4 { get; set; }
        public Nullable<decimal> pubuserdefdecm4 { get; set; }
        public string freeItem0 { get; set; }
        public string freeItem1 { get; set; }
        public string freeItem2 { get; set; }
        public string freeItem3 { get; set; }
        public string freeItem4 { get; set; }
        public string freeItem5 { get; set; }
        public string freeItem6 { get; set; }
        public string freeItem7 { get; set; }
        public string freeItem8 { get; set; }
        public string freeItem9 { get; set; }
        public Nullable<decimal> VirtualSettleAmount { get; set; }
        public Nullable<decimal> CashSettleAmount { get; set; }
        public Nullable<decimal> VirtualDeductionAmount { get; set; }
        public Nullable<decimal> CashDeductionAmount { get; set; }
        public Nullable<decimal> StorageSettleAmount { get; set; }
        public Nullable<decimal> unitExchangeRate { get; set; }
        public Nullable<decimal> quantity2 { get; set; }
        public Nullable<decimal> baseQuantity { get; set; }
        public Nullable<decimal> subQuantity { get; set; }
        public int ID { get; set; }
        public Nullable<int> idmember { get; set; }
        public Nullable<int> idinventory { get; set; }
        public Nullable<int> idunit { get; set; }
        public Nullable<int> idunit2 { get; set; }
        public Nullable<int> idbaseunit { get; set; }
        public Nullable<int> idsubunit { get; set; }
        public Nullable<int> idDistrict_Member { get; set; }
        public Nullable<int> idMembertype { get; set; }
        public Nullable<int> idperson { get; set; }
        public Nullable<int> promotiontype { get; set; }
        public Nullable<int> idRetailSettleDTO { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
    }
}
