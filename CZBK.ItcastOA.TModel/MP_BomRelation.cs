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
    
    public partial class MP_BomRelation
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public byte[] ts { get; set; }
        public Nullable<int> InvLev { get; set; }
        public string bomPath { get; set; }
        public Nullable<int> realLevel { get; set; }
        public Nullable<byte> isEnd { get; set; }
        public int id { get; set; }
        public Nullable<int> IdRealParent { get; set; }
        public Nullable<int> idTop { get; set; }
        public Nullable<int> idBom { get; set; }
        public Nullable<int> idChild { get; set; }
        public Nullable<int> IdInventory { get; set; }
        public Nullable<int> idSku { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
    }
}
