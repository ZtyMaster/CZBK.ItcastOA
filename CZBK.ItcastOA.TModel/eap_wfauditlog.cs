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
    
    public partial class eap_wfauditlog
    {
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public string BizCode { get; set; }
        public string EntityCode { get; set; }
        public string Opinion { get; set; }
        public Nullable<int> AuditAction { get; set; }
        public string AuditorName { get; set; }
        public Nullable<byte> IsCurrent { get; set; }
        public int id { get; set; }
        public Nullable<int> AuditorID { get; set; }
        public Nullable<int> EntityID { get; set; }
        public Nullable<int> SolutionID { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
    }
}
