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
    
    public partial class EAP_VoucherDraft
    {
        public byte[] ts { get; set; }
        public string name { get; set; }
        public string Json { get; set; }
        public byte IsHandMade { get; set; }
        public string Code { get; set; }
        public string VoucherName { get; set; }
        public Nullable<int> DraftType { get; set; }
        public Nullable<int> UserId { get; set; }
        public int id { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> idmarketingOrgan { get; set; }
    }
}
