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
    
    public partial class GL_Entry
    {
        public string code { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public Nullable<decimal> exchangerate { get; set; }
        public Nullable<decimal> origamountdr { get; set; }
        public Nullable<decimal> origamountcr { get; set; }
        public Nullable<decimal> amountdr { get; set; }
        public Nullable<decimal> amountcr { get; set; }
        public Nullable<decimal> quantitydr { get; set; }
        public Nullable<decimal> quantitycr { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public byte[] ts { get; set; }
        public string priuserdefnvc1 { get; set; }
        public Nullable<decimal> priuserdefdecm1 { get; set; }
        public string priuserdefnvc2 { get; set; }
        public Nullable<decimal> priuserdefdecm2 { get; set; }
        public string priuserdefnvc3 { get; set; }
        public Nullable<decimal> priuserdefdecm3 { get; set; }
        public string priuserdefnvc4 { get; set; }
        public Nullable<decimal> priuserdefdecm4 { get; set; }
        public string AuxiliaryItems { get; set; }
        public int id { get; set; }
        public Nullable<int> idaccount { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> datafrom { get; set; }
        public Nullable<int> idDocDTO { get; set; }
        public Nullable<int> idUnit { get; set; }
    }
}
