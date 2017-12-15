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
    
    public partial class GL_Journal
    {
        public string code { get; set; }
        public string docno { get; set; }
        public string rowno { get; set; }
        public string summary { get; set; }
        public string maker { get; set; }
        public string auditorname { get; set; }
        public string cashiername { get; set; }
        public string bookkeepername { get; set; }
        public Nullable<decimal> exchangerate { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public Nullable<byte> ispost { get; set; }
        public Nullable<int> year { get; set; }
        public Nullable<int> currentperiod { get; set; }
        public byte[] ts { get; set; }
        public Nullable<decimal> quantityDr { get; set; }
        public Nullable<decimal> quantityCr { get; set; }
        public Nullable<decimal> amountDr { get; set; }
        public Nullable<decimal> amountCr { get; set; }
        public Nullable<decimal> origAmountDr { get; set; }
        public Nullable<decimal> OrigAmountCr { get; set; }
        public Nullable<decimal> periodBeginOrigAmountDr { get; set; }
        public Nullable<decimal> periodBeginOrigAmountCr { get; set; }
        public Nullable<decimal> periodBeginAmountDr { get; set; }
        public Nullable<decimal> periodBeginAmountCr { get; set; }
        public Nullable<decimal> periodBeginQuantityDr { get; set; }
        public Nullable<decimal> periodBeginQuantityCr { get; set; }
        public Nullable<byte> isPeriodBegin { get; set; }
        public string bizNo { get; set; }
        public string billNo { get; set; }
        public Nullable<int> DocDrCrType { get; set; }
        public int id { get; set; }
        public int idaccount { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> idauxAccDepartment { get; set; }
        public Nullable<int> idDocType { get; set; }
        public Nullable<int> idauxAccInventory { get; set; }
        public Nullable<int> idauxAccCustomer { get; set; }
        public Nullable<int> idauxAccSupplier { get; set; }
        public Nullable<int> idauxAccPerson { get; set; }
        public Nullable<int> idclerk { get; set; }
        public Nullable<int> idauxAccProject { get; set; }
        public Nullable<int> idsettlestyle { get; set; }
        public Nullable<int> isdefrence { get; set; }
        public Nullable<int> datafrom { get; set; }
        public Nullable<int> docsourcetype { get; set; }
        public Nullable<int> direction { get; set; }
        public Nullable<int> docbusinesstype { get; set; }
        public Nullable<int> makerId { get; set; }
        public int docid { get; set; }
        public Nullable<int> entryid { get; set; }
        public Nullable<int> auxiliaryinfoid { get; set; }
        public Nullable<int> idexauxacc1 { get; set; }
        public Nullable<int> idexauxacc10 { get; set; }
        public Nullable<int> idexauxacc2 { get; set; }
        public Nullable<int> idexauxacc3 { get; set; }
        public Nullable<int> idexauxacc4 { get; set; }
        public Nullable<int> idexauxacc5 { get; set; }
        public Nullable<int> idexauxacc6 { get; set; }
        public Nullable<int> idexauxacc7 { get; set; }
        public Nullable<int> idexauxacc8 { get; set; }
        public Nullable<int> idexauxacc9 { get; set; }
        public Nullable<int> idaccountingperiod { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditdate { get; set; }
        public Nullable<System.DateTime> cashierauditdate { get; set; }
        public Nullable<System.DateTime> postdate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> bizDate { get; set; }
        public Nullable<System.DateTime> billDate { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
        public Nullable<int> idUnit { get; set; }
    }
}
