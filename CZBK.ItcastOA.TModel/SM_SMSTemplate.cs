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
    
    public partial class SM_SMSTemplate
    {
        public string subjectvalue { get; set; }
        public string subjecttitle { get; set; }
        public string bodyvalue { get; set; }
        public string bodytitle { get; set; }
        public string messageobject { get; set; }
        public byte[] ts { get; set; }
        public string selectfields { get; set; }
        public Nullable<byte> isControlSendNum { get; set; }
        public Nullable<int> SendNum { get; set; }
        public int id { get; set; }
        public Nullable<int> messagetype { get; set; }
        public string authFieldsTitle { get; set; }
        public string authFields { get; set; }
    }
}
