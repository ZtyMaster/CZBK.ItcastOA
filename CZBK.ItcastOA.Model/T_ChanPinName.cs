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
    
    public partial class T_ChanPinName
    {
        public T_ChanPinName()
        {
            this.YXB_Baojia = new HashSet<YXB_Baojia>();
            this.YXB_Baojia1 = new HashSet<YXB_Baojia>();
            this.YXB_Baojia2 = new HashSet<YXB_Baojia>();
            this.YXB_WinCanPin = new HashSet<YXB_WinCanPin>();
            this.YXB_WinCanPin1 = new HashSet<YXB_WinCanPin>();
            this.T_SCCJ = new HashSet<T_SCCJ>();
            this.T_SCCJ1 = new HashSet<T_SCCJ>();
            this.T_SCCJ2 = new HashSet<T_SCCJ>();
        }
    
        public long ID { get; set; }
        public string MyTexts { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreatePerson { get; set; }
        public Nullable<short> Del { get; set; }
        public string MyColums { get; set; }
        public Nullable<long> T_ID { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        public virtual ICollection<YXB_Baojia> YXB_Baojia { get; set; }
        public virtual ICollection<YXB_Baojia> YXB_Baojia1 { get; set; }
        public virtual ICollection<YXB_Baojia> YXB_Baojia2 { get; set; }
        public virtual ICollection<YXB_WinCanPin> YXB_WinCanPin { get; set; }
        public virtual ICollection<YXB_WinCanPin> YXB_WinCanPin1 { get; set; }
        public virtual ICollection<T_SCCJ> T_SCCJ { get; set; }
        public virtual ICollection<T_SCCJ> T_SCCJ1 { get; set; }
        public virtual ICollection<T_SCCJ> T_SCCJ2 { get; set; }
    }
}
