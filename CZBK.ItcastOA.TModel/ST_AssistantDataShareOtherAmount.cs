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
    
    public partial class ST_AssistantDataShareOtherAmount
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<int> accountYear { get; set; }
        public Nullable<int> accountPeriod { get; set; }
        public Nullable<decimal> outAmount { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public int id { get; set; }
        public Nullable<int> idvouchertype { get; set; }
        public Nullable<int> assistantDataBookID { get; set; }
        public Nullable<int> voucherID { get; set; }
        public Nullable<int> voucherDetailID { get; set; }
        public Nullable<System.DateTime> voucherDate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
