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
    
    public partial class ST_PositionInit
    {
        public string memo { get; set; }
        public string maker { get; set; }
        public string auditor { get; set; }
        public string reviser { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public byte[] ts { get; set; }
        public int id { get; set; }
        public Nullable<int> idposition { get; set; }
        public Nullable<int> idwarehouse { get; set; }
        public Nullable<int> auditorid { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
    }
}
