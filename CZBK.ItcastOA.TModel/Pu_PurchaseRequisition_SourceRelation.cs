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
    
    public partial class Pu_PurchaseRequisition_SourceRelation
    {
        public string code { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public Nullable<decimal> unitExchangeRate { get; set; }
        public Nullable<decimal> quantity2 { get; set; }
        public Nullable<decimal> baseQuantity { get; set; }
        public Nullable<decimal> subQuantity { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public int id { get; set; }
        public Nullable<int> idbaseunit { get; set; }
        public Nullable<int> idsubunit { get; set; }
        public Nullable<int> idunit { get; set; }
        public Nullable<int> idunit2 { get; set; }
        public Nullable<int> sourceVoucherID { get; set; }
        public Nullable<int> sourceVoucherDetailID { get; set; }
        public Nullable<int> voucherID { get; set; }
        public Nullable<int> idPurchaseRequisitionDetailDTO { get; set; }
        public Nullable<int> idsourcevouchertype { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
