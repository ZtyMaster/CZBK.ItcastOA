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
    
    public partial class eap_printbussetting
    {
        public int id { get; set; }
        public byte[] ts { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> TemplateId { get; set; }
        public string printdirname { get; set; }
        public string clientName { get; set; }
        public string printerName { get; set; }
        public Nullable<int> PageCopies { get; set; }
        public Nullable<byte> PrintAllPage { get; set; }
        public string PrintPageRange { get; set; }
        public Nullable<byte> PrintType { get; set; }
        public Nullable<byte> PrintDirection { get; set; }
        public Nullable<int> CopiesSpacing { get; set; }
        public Nullable<byte> PrintSeparator { get; set; }
        public Nullable<byte> Collated { get; set; }
        public Nullable<int> PrintNum { get; set; }
        public Nullable<int> PageVouchers { get; set; }
        public Nullable<byte> RowsAdaptive { get; set; }
        public Nullable<byte> FillBlankRows { get; set; }
        public Nullable<int> FixRows { get; set; }
        public string Printpaper { get; set; }
        public string margin { get; set; }
        public string BarcodeType { get; set; }
        public Nullable<int> PerRows { get; set; }
        public string LabelSpacings { get; set; }
        public string DynPropertyString { get; set; }
        public string SetUrl { get; set; }
        public string PrintClass { get; set; }
        public Nullable<int> NumRows { get; set; }
        public Nullable<byte> AutoRows { get; set; }
        public string PrintCfgJson { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
    }
}
