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
    
    public partial class GL_ExchangeLossProfitTransform
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<byte> iscontain { get; set; }
        public Nullable<byte> iscurrency { get; set; }
        public byte[] ts { get; set; }
        public int id { get; set; }
        public Nullable<int> idlossaccount { get; set; }
        public Nullable<int> idlossprofitaccount { get; set; }
        public Nullable<int> idprofitaccount { get; set; }
        public Nullable<int> iddoctype { get; set; }
        public Nullable<int> idperiod { get; set; }
    }
}