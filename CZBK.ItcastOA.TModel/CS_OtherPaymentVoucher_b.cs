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
    
    public partial class CS_OtherPaymentVoucher_b
    {
        public int id { get; set; }
        public string code { get; set; }
        public Nullable<decimal> origamount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> origSettleAmount { get; set; }
        public Nullable<decimal> SettleAmount { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public byte[] ts { get; set; }
        public Nullable<int> idOtherPaymentVoucherDTO { get; set; }
        public Nullable<decimal> exchangeRate { get; set; }
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
        public Nullable<int> idproject { get; set; }
        public string OtherPaymentItemUse { get; set; }
        public string summary { get; set; }
    }
}
