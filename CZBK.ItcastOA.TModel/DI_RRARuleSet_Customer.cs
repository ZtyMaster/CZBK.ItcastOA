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
    
    public partial class DI_RRARuleSet_Customer
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public byte[] ts { get; set; }
        public int id { get; set; }
        public Nullable<int> IdInventory { get; set; }
        public Nullable<int> IdInventoryClass { get; set; }
        public Nullable<int> CustomerReplenishmentRule { get; set; }
        public Nullable<int> ProductInfo { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
