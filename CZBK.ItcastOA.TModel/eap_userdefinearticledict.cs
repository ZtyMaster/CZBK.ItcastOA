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
    
    public partial class eap_userdefinearticledict
    {
        public byte[] ts { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string Title { get; set; }
        public string TableName { get; set; }
        public string ClassForeignField { get; set; }
        public string ParentField { get; set; }
        public byte IsAutoCreate { get; set; }
        public byte IsSystem { get; set; }
        public Nullable<byte> IsDefault { get; set; }
        public byte IsDisplay { get; set; }
        public string menuCode { get; set; }
        public string menuParentCode { get; set; }
        public string className { get; set; }
        public int id { get; set; }
        public string ExtendTable { get; set; }
        public string ScriptPath { get; set; }
        public string ExtendAssembly { get; set; }
        public int StructType { get; set; }
        public Nullable<int> IdParent { get; set; }
        public Nullable<int> ClassArticleId { get; set; }
        public Nullable<System.DateTime> MadeDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
