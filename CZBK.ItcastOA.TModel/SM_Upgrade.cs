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
    
    public partial class SM_Upgrade
    {
        public int ID { get; set; }
        public string Version { get; set; }
        public string ScriptFileName { get; set; }
        public string ItemType { get; set; }
        public string UpdateClass { get; set; }
        public string Parameter { get; set; }
        public int OrderNo { get; set; }
        public byte DBType { get; set; }
        public string Location { get; set; }
        public string LanguageType { get; set; }
        public Nullable<int> Status { get; set; }
        public string Product { get; set; }
        public Nullable<System.DateTime> ExecutionTime { get; set; }
    }
}
