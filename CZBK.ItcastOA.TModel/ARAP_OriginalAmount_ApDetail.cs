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
    
    public partial class ARAP_OriginalAmount_ApDetail
    {
        public string code { get; set; }
        public Nullable<decimal> origPrepayAmount { get; set; }
        public Nullable<decimal> prepayAmount { get; set; }
        public Nullable<decimal> origAmount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> origBalanceAmount { get; set; }
        public Nullable<decimal> balanceAmount { get; set; }
        public Nullable<decimal> origTotalPrepayAmount { get; set; }
        public Nullable<decimal> totalPrepayAmount { get; set; }
        public Nullable<decimal> origTotalAmount { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public byte[] ts { get; set; }
        public Nullable<byte> IsCarriedForwardOut { get; set; }
        public Nullable<byte> isCarriedForwardIn { get; set; }
        public Nullable<decimal> OrigOtherAmount { get; set; }
        public Nullable<decimal> OtherAmount { get; set; }
        public string memo { get; set; }
        public int ID { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idperson { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> idArapOriginalAmountDTO { get; set; }
        public Nullable<System.DateTime> origDate { get; set; }
        public Nullable<System.DateTime> arrivaldate { get; set; }
        public Nullable<decimal> OrigInitialExpense { get; set; }
        public Nullable<decimal> InitialExpense { get; set; }
        public Nullable<decimal> OrigActualInitialExpense { get; set; }
        public Nullable<decimal> ActualInitialExpense { get; set; }
        public Nullable<decimal> OrigActualOtherApAmount { get; set; }
        public Nullable<decimal> ActualOtherApAmount { get; set; }
    }
}
