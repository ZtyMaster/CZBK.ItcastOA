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
    
    public partial class SM_SendTimeRule
    {
        public Nullable<int> perxdays { get; set; }
        public Nullable<int> perxweeks { get; set; }
        public string week { get; set; }
        public Nullable<int> perxmonth { get; set; }
        public Nullable<int> day { get; set; }
        public Nullable<int> leaddays { get; set; }
        public string timeformat { get; set; }
        public string sendtimetype { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public int id { get; set; }
        public Nullable<System.DateTime> begindate { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
        public Nullable<System.DateTime> sendtime { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
