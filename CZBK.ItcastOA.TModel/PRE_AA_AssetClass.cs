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
    
    public partial class PRE_AA_AssetClass
    {
        public string TradeKind { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<byte> depth { get; set; }
        public string inid { get; set; }
        public Nullable<byte> isendnode { get; set; }
        public Nullable<byte> ispreset { get; set; }
        public Nullable<byte> isdisPlay { get; set; }
        public string imageFile { get; set; }
        public Nullable<int> defaultyears { get; set; }
        public Nullable<int> defaultmonths { get; set; }
        public Nullable<decimal> defaultnrvrate { get; set; }
        public Nullable<byte> defaultoffsetinputtax { get; set; }
        public Nullable<decimal> defaultinputtaxrate { get; set; }
        public string UsedYearAndMonth { get; set; }
        public byte IsSystem { get; set; }
        public int id { get; set; }
        public Nullable<int> idassetprop { get; set; }
        public Nullable<int> iddeprmethod { get; set; }
        public Nullable<int> idbarcode { get; set; }
        public Nullable<int> idunit { get; set; }
        public Nullable<int> idlabelstyle { get; set; }
        public Nullable<int> idcardstyle { get; set; }
        public Nullable<int> idparent { get; set; }
        public string ExpressionName { get; set; }
    }
}