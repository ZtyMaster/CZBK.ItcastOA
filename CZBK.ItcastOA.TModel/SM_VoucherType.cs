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
    
    public partial class SM_VoucherType
    {
        public string code { get; set; }
        public string name { get; set; }
        public string moduleName { get; set; }
        public string AuditModule { get; set; }
        public Nullable<byte> isautofillbreakpoint { get; set; }
        public Nullable<byte> iseditable { get; set; }
        public Nullable<byte> isneedaudit { get; set; }
        public string prefixion1 { get; set; }
        public Nullable<int> prefixion1length { get; set; }
        public string prefixion1content { get; set; }
        public Nullable<byte> iscreatorderbyprefixion1 { get; set; }
        public string prefixion2 { get; set; }
        public string prefixion2content { get; set; }
        public Nullable<int> prefixion2length { get; set; }
        public Nullable<byte> iscreatorderbyprefixion2 { get; set; }
        public string prefixion3 { get; set; }
        public string prefixion3content { get; set; }
        public Nullable<int> prefixion3length { get; set; }
        public Nullable<byte> iscreatorderbyprefixion3 { get; set; }
        public string separator { get; set; }
        public Nullable<int> serialnolength { get; set; }
        public Nullable<decimal> startordenalnumber { get; set; }
        public byte disabled { get; set; }
        public byte issystem { get; set; }
        public byte isCodingVisible { get; set; }
        public byte isAudingVisible { get; set; }
        public string vouchertypealias { get; set; }
        public Nullable<byte> isautocreate { get; set; }
        public byte[] ts { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string DtoName { get; set; }
        public string VoucherName { get; set; }
        public string DataType { get; set; }
        public byte isMessageCenterVisible { get; set; }
        public byte isVoucherSearchVisible { get; set; }
        public int prefixion1InterceptType { get; set; }
        public int prefixion2InterceptType { get; set; }
        public int prefixion3InterceptType { get; set; }
        public Nullable<byte> IsNeedWorkFlow { get; set; }
        public Nullable<int> CodeManner { get; set; }
        public Nullable<int> IsPrefix1ReadOnly { get; set; }
        public string SysPropFields { get; set; }
        public string ExpressionName { get; set; }
        public Nullable<byte> isAuditPrint { get; set; }
        public Nullable<byte> IsEnableWFEmail { get; set; }
        public int ID { get; set; }
        public Nullable<byte> IsNeedGzqAudit { get; set; }
    }
}
