//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CZBK.ItcastOA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class YJ_ScheduleDay
    {
        public YJ_ScheduleDay()
        {
            this.YJ_ScheduleAction = new HashSet<YJ_ScheduleAction>();
            this.YJ_ScheduleAction1 = new HashSet<YJ_ScheduleAction>();
        }
    
        public long ID { get; set; }
        public Nullable<System.DateTime> SchenuleTime { get; set; }
        public Nullable<int> WriteUserID { get; set; }
        public Nullable<int> TextID { get; set; }
        public string YJText { get; set; }
        public Nullable<int> YJUserinfoID { get; set; }
        public Nullable<System.DateTime> AddYJtime { get; set; }
        public Nullable<bool> ISee { get; set; }
        public Nullable<System.DateTime> ISeeAddtime { get; set; }
        public Nullable<short> DEL { get; set; }
        public string SeeUserInfoList { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        public virtual UserInfo UserInfo1 { get; set; }
        public virtual ICollection<YJ_ScheduleAction> YJ_ScheduleAction { get; set; }
        public virtual ICollection<YJ_ScheduleAction> YJ_ScheduleAction1 { get; set; }
    }
}
