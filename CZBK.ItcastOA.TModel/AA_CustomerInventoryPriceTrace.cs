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
    
    public partial class AA_CustomerInventoryPriceTrace
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<decimal> lastPrice { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> unitprice { get; set; }
        public Nullable<decimal> unittaxprice { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public int id { get; set; }
        public int idinventory { get; set; }
        public int idcustomer { get; set; }
        public int idunit { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
