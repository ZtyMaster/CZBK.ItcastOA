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
    
    public partial class T_ZhiPiaoTong
    {
        public long ID { get; set; }
        public string ComName { get; set; }
        public decimal Money { get; set; }
        public string Skbak { get; set; }
        public string Bumen { get; set; }
        public string Fangshi { get; set; }
        public Nullable<bool> del { get; set; }
        public Nullable<System.DateTime> NewTime { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public Nullable<int> AddUser { get; set; }
    }
}
