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
    
    public partial class GL_AccountPeriodBegin
    {
        public string code { get; set; }
        public Nullable<int> accountingyear { get; set; }
        public Nullable<int> accountingperiod { get; set; }
        public string currency { get; set; }
        public Nullable<decimal> yearbeginbalancequantity { get; set; }
        public Nullable<decimal> yearbeginbalanceorigamount { get; set; }
        public Nullable<decimal> yearbeginbalanceamount { get; set; }
        public Nullable<decimal> cumquantitydr { get; set; }
        public Nullable<decimal> cumorigamountdr { get; set; }
        public Nullable<decimal> cumamountdr { get; set; }
        public Nullable<decimal> cumquantitycr { get; set; }
        public Nullable<decimal> cumorigamountcr { get; set; }
        public Nullable<decimal> cumamountcr { get; set; }
        public Nullable<decimal> periodbeginbalancequantity { get; set; }
        public Nullable<decimal> periodbeginbalanceorigamount { get; set; }
        public Nullable<decimal> periodbeginbalanceamount { get; set; }
        public byte[] ts { get; set; }
        public string SourceType { get; set; }
        public string SourceContent { get; set; }
        public int id { get; set; }
        public Nullable<int> idaccountDTO { get; set; }
    }
}
