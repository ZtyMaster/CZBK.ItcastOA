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
    
    public partial class AA_Account
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> accountingyear { get; set; }
        public string shorthand { get; set; }
        public Nullable<byte> isquantity { get; set; }
        public Nullable<byte> isexchange { get; set; }
        public Nullable<byte> isgatherprinting { get; set; }
        public Nullable<byte> canmakedoc { get; set; }
        public Nullable<byte> iscontrolled { get; set; }
        public Nullable<byte> iscontrolledbussinesssys { get; set; }
        public Nullable<byte> iscontrolledcash { get; set; }
        public Nullable<byte> iscash { get; set; }
        public Nullable<byte> isbank { get; set; }
        public Nullable<byte> iscashequivalents { get; set; }
        public Nullable<byte> isauxaccdepartment { get; set; }
        public Nullable<byte> isauxaccperson { get; set; }
        public Nullable<byte> isauxacccustomer { get; set; }
        public Nullable<byte> isauxaccsupplier { get; set; }
        public Nullable<byte> isauxaccproject { get; set; }
        public Nullable<byte> isauxaccinventory { get; set; }
        public Nullable<byte> isexauxacc1 { get; set; }
        public Nullable<byte> isexauxacc2 { get; set; }
        public Nullable<byte> isexauxacc3 { get; set; }
        public Nullable<byte> isexauxacc4 { get; set; }
        public Nullable<byte> isexauxacc5 { get; set; }
        public Nullable<byte> isexauxacc6 { get; set; }
        public Nullable<byte> isexauxacc7 { get; set; }
        public Nullable<byte> isexauxacc8 { get; set; }
        public Nullable<byte> isexauxacc9 { get; set; }
        public Nullable<byte> isexauxacc10 { get; set; }
        public Nullable<byte> isEndNode { get; set; }
        public Nullable<byte> disabled { get; set; }
        public Nullable<int> depth { get; set; }
        public string inId { get; set; }
        public byte[] ts { get; set; }
        public byte IsAux { get; set; }
        public Nullable<byte> isFinalTransferExchange { get; set; }
        public Nullable<byte> isBillingInfo { get; set; }
        public Nullable<decimal> Remainder { get; set; }
        public string ModifyLog { get; set; }
        public int id { get; set; }
        public Nullable<int> idGatherPrintingAccountDTO { get; set; }
        public Nullable<int> idParent { get; set; }
        public Nullable<int> idaccounttypeDTO { get; set; }
        public Nullable<int> iddefaultcurrencyDTO { get; set; }
        public Nullable<int> bookformat { get; set; }
        public Nullable<int> dcdirection { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<int> idUnit { get; set; }
    }
}
