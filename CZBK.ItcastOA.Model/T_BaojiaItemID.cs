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
    
    public partial class T_BaojiaItemID
    {
        public T_BaojiaItemID()
        {
            this.T_YXbj_master = new HashSet<T_YXbj_master>();
        }
    
        public int ID { get; set; }
        public string Str_url { get; set; }
        public bool del { get; set; }
    
        public virtual ICollection<T_YXbj_master> T_YXbj_master { get; set; }
    }
}