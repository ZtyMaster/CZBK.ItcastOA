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
    
    public partial class ARAP_ReceivePayment_MultiSettle
    {
        public string code { get; set; }
        public string documentCode { get; set; }
        public Nullable<decimal> origAmount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public byte[] ts { get; set; }
        public int ID { get; set; }
        public Nullable<int> idbankaccount { get; set; }
        public Nullable<int> idsettlestyle { get; set; }
        public Nullable<int> idArapReceivePaymentDTO { get; set; }
    }
}
