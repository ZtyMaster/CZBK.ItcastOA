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
    
    public partial class eap_reportfield
    {
        public string title { get; set; }
        public string selectFieldName { get; set; }
        public string aliasName { get; set; }
        public string whereFieldName { get; set; }
        public Nullable<byte> isBundleField { get; set; }
        public Nullable<byte> isMain { get; set; }
        public Nullable<byte> canGroup { get; set; }
        public Nullable<byte> defaultGroup { get; set; }
        public Nullable<byte> canClassiced { get; set; }
        public Nullable<byte> canLinkage { get; set; }
        public Nullable<byte> canRowGroup { get; set; }
        public Nullable<byte> defaultRowGroup { get; set; }
        public Nullable<byte> canColumnGroup { get; set; }
        public Nullable<byte> isMultiLevelGroup { get; set; }
        public string parentDataField { get; set; }
        public Nullable<byte> isColumn { get; set; }
        public string lastLevelIdentifyField { get; set; }
        public string dtoprop { get; set; }
        public string RefDtoProp { get; set; }
        public Nullable<byte> StaticGroup { get; set; }
        public int id { get; set; }
        public Nullable<byte> IsColSpan { get; set; }
        public byte[] ts { get; set; }
        public Nullable<int> idparent { get; set; }
        public Nullable<int> ideap_reporttemplate { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
    }
}
