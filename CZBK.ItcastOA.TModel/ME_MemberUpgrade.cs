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
    
    public partial class ME_MemberUpgrade
    {
        public string code { get; set; }
        public string name { get; set; }
        public string newcardcode { get; set; }
        public string handperson { get; set; }
        public string handpersoncode { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public byte[] memberts { get; set; }
        public string newcode { get; set; }
        public int id { get; set; }
        public Nullable<int> idmember { get; set; }
        public Nullable<int> idnewmembertype { get; set; }
        public Nullable<int> idhandperson { get; set; }
        public Nullable<int> upgradetype { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
