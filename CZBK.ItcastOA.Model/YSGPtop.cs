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
    
    public partial class YSGPtop
    {
        public YSGPtop()
        {
            this.YSGPinfoes = new HashSet<YSGPinfo>();
        }
    
        public long ID { get; set; }
        public System.DateTime GPtime { get; set; }
        public int PGbumen { get; set; }
        public string PGperson { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public decimal WorkTime { get; set; }
        public decimal PGpersonAllWages { get; set; }
        public decimal SettlementAmount { get; set; }
        public short Del_f { get; set; }
        public int AddUser { get; set; }
        public System.DateTime AddTime { get; set; }
    
        public virtual BumenInfoSet BumenInfoSet { get; set; }
        public virtual ICollection<YSGPinfo> YSGPinfoes { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
