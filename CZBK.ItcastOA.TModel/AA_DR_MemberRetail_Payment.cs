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
    
    public partial class AA_DR_MemberRetail_Payment
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<decimal> origamount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> overchargesamount { get; set; }
        public string updatedBy { get; set; }
        public Nullable<int> idMemberRetailDTO { get; set; }
        public int id { get; set; }
        public Nullable<int> idsettlestyle { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
