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
    
    public partial class CS_ChequeBook
    {
        public string code { get; set; }
        public string chequecodebegin { get; set; }
        public Nullable<int> number { get; set; }
        public string chequecodeend { get; set; }
        public Nullable<int> numbernouse { get; set; }
        public Nullable<int> numberuse { get; set; }
        public Nullable<int> numberreimburse { get; set; }
        public Nullable<int> numberinvalidate { get; set; }
        public string buynode { get; set; }
        public string printtemplate { get; set; }
        public string buyoperateperson { get; set; }
        public string printtemplateid { get; set; }
        public string memo { get; set; }
        public string maker { get; set; }
        public string auditor { get; set; }
        public string reviser { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public byte[] ts { get; set; }
        public int id { get; set; }
        public Nullable<int> idbankaccount { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> idbuyperson { get; set; }
        public Nullable<int> idsettlestyle { get; set; }
        public Nullable<int> voucherstate { get; set; }
        public Nullable<int> auditorid { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<System.DateTime> buydate { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
    }
}
