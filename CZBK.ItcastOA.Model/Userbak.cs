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
    
    public partial class Userbak
    {
        public int ID { get; set; }
        public int UserInfoID { get; set; }
        public int OldUserID { get; set; }
        public string CardNumber { get; set; }
        public Nullable<short> Gender { get; set; }
        public string BigPhoto { get; set; }
        public string minPhoto { get; set; }
        public string Addess { get; set; }
        public Nullable<bool> del { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}
