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
    
    public partial class PR_SalesPromotion_Subs
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<decimal> retailprice { get; set; }
        public Nullable<decimal> additionalprice { get; set; }
        public Nullable<decimal> quantitymeet { get; set; }
        public Nullable<decimal> amountmeet { get; set; }
        public Nullable<decimal> discountrate { get; set; }
        public Nullable<decimal> discountamount { get; set; }
        public string promotiondesc { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public byte[] ts { get; set; }
        public Nullable<decimal> LimitedGiftQuantity { get; set; }
        public Nullable<decimal> DayLimitedGiftQuantity { get; set; }
        public string InventoryBarCode { get; set; }
        public Nullable<decimal> PieceMeet { get; set; }
        public int ID { get; set; }
        public Nullable<int> idinventory { get; set; }
        public Nullable<int> idunit { get; set; }
        public Nullable<int> idSalesPromotionDTO { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
    }
}