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
    
    public partial class MP_PRA_GeneratePurchaseOrderSetting
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<decimal> exchangerate { get; set; }
        public Nullable<byte> isnullitem { get; set; }
        public byte[] ts { get; set; }
        public int id { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idperson { get; set; }
        public Nullable<System.DateTime> purchasedate { get; set; }
        public Nullable<System.DateTime> arrivaldate { get; set; }
    }
}
