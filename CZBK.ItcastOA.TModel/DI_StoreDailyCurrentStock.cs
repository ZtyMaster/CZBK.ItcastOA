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
    
    public partial class DI_StoreDailyCurrentStock
    {
        public byte[] ts { get; set; }
        public string name { get; set; }
        public decimal StockRequestQuantity { get; set; }
        public decimal BaseQuantity { get; set; }
        public decimal CanUseQuantity { get; set; }
        public decimal PurchaseArrivalQuantity { get; set; }
        public decimal PurchaseForReceiveQuantity { get; set; }
        public decimal ProductForReceiveQuantity { get; set; }
        public decimal SaleDeliveryQuantity { get; set; }
        public decimal SaleDispatchQuantity { get; set; }
        public decimal OtherOnWayQuantity { get; set; }
        public decimal TransOnWayQuantity { get; set; }
        public decimal OtherForDispatchQuantity { get; set; }
        public decimal TransForDispatchQuantity { get; set; }
        public decimal SafeQuantity { get; set; }
        public decimal LowQuantity { get; set; }
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
        public decimal ESStoreForDispatchQuantity { get; set; }
        public decimal DistributionForReceiveQuantity { get; set; }
        public int id { get; set; }
        public Nullable<int> idinventory { get; set; }
        public Nullable<int> idwarehouse { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
