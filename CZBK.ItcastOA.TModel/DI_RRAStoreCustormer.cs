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
    
    public partial class DI_RRAStoreCustormer
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> RequestQuantity { get; set; }
        public Nullable<decimal> DistributionRqeuareQuantity { get; set; }
        public Nullable<decimal> DistributionQuantity { get; set; }
        public Nullable<decimal> CurrentStock { get; set; }
        public Nullable<decimal> SaleQuantity { get; set; }
        public Nullable<decimal> NewAllocationRatio { get; set; }
        public string ReplenishmentRule { get; set; }
        public byte[] Ts { get; set; }
        public Nullable<byte> HasDistributed { get; set; }
        public Nullable<decimal> AvailableQuantity { get; set; }
        public int ID { get; set; }
        public Nullable<int> idstore { get; set; }
        public Nullable<int> StoreOrCustomerID { get; set; }
        public Nullable<int> IdInventory { get; set; }
        public Nullable<int> idcustomer { get; set; }
        public Nullable<int> idInWarehouse { get; set; }
        public Nullable<int> idReplenishmentRule { get; set; }
        public Nullable<int> IdRRAInventoryDTO { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
    }
}