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
    
    public partial class CS_CashAccount
    {
        public string sourceVoucherCode { get; set; }
        public string sourceVoucherMaker { get; set; }
        public string sourceVoucherAuditor { get; set; }
        public string sourceVoucherMemo { get; set; }
        public Nullable<decimal> origInAmount { get; set; }
        public Nullable<decimal> origOutAmount { get; set; }
        public Nullable<decimal> origAmount { get; set; }
        public Nullable<byte> isPeriodBeginning { get; set; }
        public string sourceVoucherDocumentCode { get; set; }
        public string docId { get; set; }
        public Nullable<int> year { get; set; }
        public Nullable<int> period { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public byte[] ts { get; set; }
        public Nullable<decimal> inamount { get; set; }
        public Nullable<decimal> outamount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<byte> ispullin { get; set; }
        public Nullable<decimal> inexchangerate { get; set; }
        public Nullable<decimal> outexchangerate { get; set; }
        public Nullable<decimal> exchangerate { get; set; }
        public Nullable<decimal> OrigTotalDrAmount { get; set; }
        public Nullable<decimal> TotalDrAmount { get; set; }
        public Nullable<decimal> OrigTotalCrAmount { get; set; }
        public Nullable<decimal> TotalCrAmount { get; set; }
        public int id { get; set; }
        public Nullable<int> idbankaccount { get; set; }
        public Nullable<int> idsourcevoucherbusinesstype { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> IdMarketingOrgan { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idperson { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> idsettlestyle { get; set; }
        public Nullable<int> IdOtherBankAccount { get; set; }
        public Nullable<int> IdIncome { get; set; }
        public Nullable<int> IdExpenseItem { get; set; }
        public Nullable<int> sourceVoucherID { get; set; }
        public Nullable<int> sourceMultiSettleID { get; set; }
        public Nullable<int> SourceVoucherMakerId { get; set; }
        public Nullable<int> idsourcevouchertype { get; set; }
        public Nullable<System.DateTime> sourceVoucherDate { get; set; }
        public Nullable<System.DateTime> sourceVoucherCreatedTime { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> SourceVoucherAuditDate { get; set; }
        public string Summary { get; set; }
    }
}