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
    
    public partial class AA_InventoryUnitPrice
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<decimal> invMPCost { get; set; }
        public Nullable<decimal> invLSPrice { get; set; }
        public Nullable<decimal> retailPrice { get; set; }
        public Nullable<decimal> latestPPrice { get; set; }
        public Nullable<decimal> latestSalePrice { get; set; }
        public Nullable<decimal> invSCost1 { get; set; }
        public Nullable<decimal> invSCost2 { get; set; }
        public Nullable<decimal> invSCost3 { get; set; }
        public Nullable<decimal> invSCost4 { get; set; }
        public Nullable<decimal> invSCost5 { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public Nullable<decimal> latestSaleDiscount { get; set; }
        public Nullable<decimal> latestUnitSalePrice { get; set; }
        public Nullable<decimal> latestUnitTaxSalePrice { get; set; }
        public Nullable<decimal> highestoutsourcedprice { get; set; }
        public Nullable<decimal> latestoutsourcedprice { get; set; }
        public Nullable<decimal> rateOfExchange { get; set; }
        public string rateDescription { get; set; }
        public Nullable<decimal> MarkupRate { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> InvSCost6 { get; set; }
        public Nullable<decimal> InvSCost7 { get; set; }
        public Nullable<decimal> InvSCost8 { get; set; }
        public Nullable<decimal> InvSCost9 { get; set; }
        public Nullable<decimal> InvSCost10 { get; set; }
        public int idinventory { get; set; }
        public int id { get; set; }
        public int idunit { get; set; }
        public Nullable<int> idunitgroup { get; set; }
        public Nullable<System.DateTime> madeDate { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public Nullable<System.DateTime> createdTime { get; set; }
        public Nullable<byte> isGroup { get; set; }
    }
}
