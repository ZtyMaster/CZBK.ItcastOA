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
    
    public partial class MP_PRA_SuggestionSourceRelation
    {
        public string code { get; set; }
        public string name { get; set; }
        public string sourceVoucherCode { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public Nullable<decimal> quantity2 { get; set; }
        public Nullable<decimal> basequantity { get; set; }
        public Nullable<decimal> subquantity { get; set; }
        public Nullable<decimal> unitexchangerate { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public byte[] ts { get; set; }
        public int id { get; set; }
        public Nullable<int> idbaseunit { get; set; }
        public Nullable<int> idsubunit { get; set; }
        public Nullable<int> idunit { get; set; }
        public Nullable<int> idunit2 { get; set; }
        public Nullable<int> sourceVoucherId { get; set; }
        public Nullable<int> sourceVoucherDetailId { get; set; }
        public Nullable<int> idPraPurchaseSuggestionDTO { get; set; }
        public Nullable<int> voucherid { get; set; }
        public Nullable<int> idsourcevouchertype { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
    }
}
