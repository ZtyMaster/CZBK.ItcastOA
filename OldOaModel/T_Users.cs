//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OldOaModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Users
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Nullable<long> PersonID { get; set; }
        public string RName { get; set; }
        public string Bumen { get; set; }
        public string Guishu { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<bool> IsLogin { get; set; }
        public Nullable<int> Qx { get; set; }
        public Nullable<int> Bj_qx { get; set; }
        public Nullable<int> Wuguan { get; set; }
        public Nullable<int> Caiwu { get; set; }
        public Nullable<int> Huoyun { get; set; }
        public Nullable<int> admin { get; set; }
        public Nullable<int> yingxiao { get; set; }
        public Nullable<int> NewXinzi { get; set; }
        public Nullable<int> KQshenhe { get; set; }
        public Nullable<int> OldGZ { get; set; }
    
        public virtual T_Users T_Users1 { get; set; }
        public virtual T_Users T_Users2 { get; set; }
    }
}
