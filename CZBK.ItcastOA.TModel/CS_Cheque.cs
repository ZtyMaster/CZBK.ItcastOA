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
    
    public partial class CS_Cheque
    {
        public Nullable<decimal> origbillamout { get; set; }
        public Nullable<decimal> origLimitAmount { get; set; }
        public Nullable<decimal> origreimburseamount { get; set; }
        public string reimbursememo { get; set; }
        public string sourcevouchercode { get; set; }
        public string invalidatememo { get; set; }
        public string receiver { get; set; }
        public string receiveaccount { get; set; }
        public string receivebank { get; set; }
        public string paymenter { get; set; }
        public Nullable<byte> isautoreimburse { get; set; }
        public string documentsusage { get; set; }
        public string billcode { get; set; }
        public string settledetailid { get; set; }
        public string notepwd { get; set; }
        public string memo { get; set; }
        public string maker { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public byte[] ts { get; set; }
        public int id { get; set; }
        public Nullable<int> idpaymentbankaccount { get; set; }
        public Nullable<int> idreceivebankaccount { get; set; }
        public Nullable<int> idreimbursedepartment { get; set; }
        public Nullable<int> idusedepartment { get; set; }
        public Nullable<int> idcancler { get; set; }
        public Nullable<int> idorigreimburseperson { get; set; }
        public Nullable<int> iduser { get; set; }
        public Nullable<int> iduserperson { get; set; }
        public Nullable<int> idwriteoffer { get; set; }
        public Nullable<int> sourceVoucherID { get; set; }
        public Nullable<int> idChequeBookDTO { get; set; }
        public Nullable<int> voucherstate { get; set; }
        public Nullable<int> voucherstatebeforeclose { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<int> idsourcevouchertype { get; set; }
        public Nullable<System.DateTime> billDate { get; set; }
        public Nullable<System.DateTime> reimbursedate { get; set; }
        public Nullable<System.DateTime> invalidatedate { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
    }
}