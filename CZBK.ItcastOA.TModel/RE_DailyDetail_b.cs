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
    
    public partial class RE_DailyDetail_b
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public Nullable<decimal> origamount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> origsettleamount { get; set; }
        public Nullable<decimal> settleamount { get; set; }
        public Nullable<decimal> initialamount { get; set; }
        public Nullable<decimal> imprestamount { get; set; }
        public byte[] ts { get; set; }
        public Nullable<int> idbankaccount { get; set; }
        public Nullable<int> idsettlestyle { get; set; }
        public Nullable<long> idDailyDetailDTO { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public long ID { get; set; }
        public Nullable<decimal> ReceiveAmount { get; set; }
    }
}
