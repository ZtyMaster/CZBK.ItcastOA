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
    
    public partial class ScheduleType
    {
        public ScheduleType()
        {
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int ID { get; set; }
        public string ItemText { get; set; }
        public Nullable<short> Del { get; set; }
        public Nullable<int> BuMenId { get; set; }
    
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual BumenInfoSet BumenInfoSet { get; set; }
    }
}
