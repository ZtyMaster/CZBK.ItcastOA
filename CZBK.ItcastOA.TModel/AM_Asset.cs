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
    
    public partial class AM_Asset
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> ver { get; set; }
        public Nullable<byte> isactive { get; set; }
        public string spec { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<byte> ismultidept { get; set; }
        public Nullable<int> deptver { get; set; }
        public Nullable<int> expyears { get; set; }
        public Nullable<int> expmonths { get; set; }
        public Nullable<int> usedyears { get; set; }
        public Nullable<int> usedmonths { get; set; }
        public Nullable<int> leftyears { get; set; }
        public Nullable<int> leftmonths { get; set; }
        public Nullable<decimal> expuop { get; set; }
        public Nullable<decimal> useduop { get; set; }
        public Nullable<decimal> curuop { get; set; }
        public Nullable<decimal> leftuop { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> taxfee { get; set; }
        public Nullable<decimal> fixfee { get; set; }
        public Nullable<decimal> discardfee { get; set; }
        public Nullable<decimal> otherfee { get; set; }
        public Nullable<decimal> estvalue { get; set; }
        public Nullable<decimal> origvalue { get; set; }
        public Nullable<decimal> functionorigvalue { get; set; }
        public Nullable<decimal> exchangerate { get; set; }
        public Nullable<byte> isoffsetinputtax { get; set; }
        public Nullable<decimal> inputtaxrate { get; set; }
        public Nullable<decimal> inputtax { get; set; }
        public Nullable<decimal> totaldepr { get; set; }
        public Nullable<decimal> netamount { get; set; }
        public Nullable<decimal> bookvalue { get; set; }
        public Nullable<decimal> expnrvrate { get; set; }
        public Nullable<decimal> expnrv { get; set; }
        public Nullable<byte> isdepr { get; set; }
        public Nullable<decimal> monthdeprrate { get; set; }
        public Nullable<decimal> monthdepramount { get; set; }
        public Nullable<decimal> YearTotalProvision { get; set; }
        public Nullable<decimal> unitdepr { get; set; }
        public Nullable<decimal> leftprovision { get; set; }
        public Nullable<decimal> clearincome { get; set; }
        public Nullable<decimal> clearfee { get; set; }
        public Nullable<decimal> saletax { get; set; }
        public Nullable<decimal> biztax { get; set; }
        public Nullable<decimal> impairment { get; set; }
        public string barcode { get; set; }
        public string serialnum { get; set; }
        public string suitnum { get; set; }
        public string fundsrc { get; set; }
        public string landlevel { get; set; }
        public Nullable<decimal> landarea { get; set; }
        public Nullable<decimal> buildingarea { get; set; }
        public Nullable<int> rooms { get; set; }
        public Nullable<decimal> empower { get; set; }
        public Nullable<int> emnum { get; set; }
        public string license { get; set; }
        public Nullable<decimal> nettons { get; set; }
        public Nullable<byte> isbegin { get; set; }
        public Nullable<byte> issealed { get; set; }
        public Nullable<int> srcvoucherid { get; set; }
        public string srcvouchernum { get; set; }
        public string docid { get; set; }
        public string memo { get; set; }
        public string maker { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public string mutidept { get; set; }
        public byte[] ts { get; set; }
        public string priuserdefnvc1 { get; set; }
        public Nullable<decimal> priuserdefdecm1 { get; set; }
        public string priuserdefnvc2 { get; set; }
        public Nullable<decimal> priuserdefdecm2 { get; set; }
        public string priuserdefnvc3 { get; set; }
        public Nullable<decimal> priuserdefdecm3 { get; set; }
        public string priuserdefnvc4 { get; set; }
        public Nullable<decimal> priuserdefdecm4 { get; set; }
        public string priuserdefnvc5 { get; set; }
        public Nullable<decimal> priuserdefdecm5 { get; set; }
        public string priuserdefnvc6 { get; set; }
        public Nullable<decimal> priuserdefdecm6 { get; set; }
        public string pubuserdefnvc1 { get; set; }
        public Nullable<decimal> pubuserdefdecm1 { get; set; }
        public string pubuserdefnvc2 { get; set; }
        public Nullable<decimal> pubuserdefdecm2 { get; set; }
        public string pubuserdefnvc3 { get; set; }
        public Nullable<decimal> pubuserdefdecm3 { get; set; }
        public string pubuserdefnvc4 { get; set; }
        public Nullable<decimal> pubuserdefdecm4 { get; set; }
        public string pubuserdefnvc5 { get; set; }
        public Nullable<decimal> pubuserdefdecm5 { get; set; }
        public string pubuserdefnvc6 { get; set; }
        public Nullable<decimal> pubuserdefdecm6 { get; set; }
        public string AssetOrderNum { get; set; }
        public Nullable<byte> IsActualDepr { get; set; }
        public string ActualDeprMethod { get; set; }
        public Nullable<int> DeprCycle { get; set; }
        public string SourceVoucherNum { get; set; }
        public string ImageFile { get; set; }
        public string UsedYearAndMonth { get; set; }
        public string LeftYearAndMonth { get; set; }
        public string ExpYearAndMonth { get; set; }
        public Nullable<int> ExpTotalMonth { get; set; }
        public Nullable<int> UsedTotalMonth { get; set; }
        public Nullable<int> LeftTotalMonth { get; set; }
        public Nullable<byte> disabled { get; set; }
        public Nullable<int> SumYears { get; set; }
        public int PrintCount { get; set; }
        public Nullable<int> idassetclass { get; set; }
        public Nullable<int> idAssetProp { get; set; }
        public Nullable<int> idbizusage { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> idadmindept { get; set; }
        public Nullable<int> idusedept { get; set; }
        public Nullable<int> iddeprmethod { get; set; }
        public Nullable<int> idhandlereason { get; set; }
        public Nullable<int> idincdecway { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idproducer { get; set; }
        public Nullable<int> idperson { get; set; }
        public Nullable<int> idposition { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> idunit { get; set; }
        public Nullable<int> iduopunit { get; set; }
        public Nullable<int> idusestatus { get; set; }
        public int id { get; set; }
        public Nullable<int> idPrevCardID { get; set; }
        public Nullable<int> cardid { get; set; }
        public Nullable<int> copyfrom { get; set; }
        public Nullable<int> SourceVoucherID { get; set; }
        public Nullable<int> cardstate { get; set; }
        public Nullable<int> IsGenDoc { get; set; }
        public Nullable<int> voucherstate { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<int> idbookperiod { get; set; }
        public Nullable<int> IDSourceVoucherPeriod { get; set; }
        public Nullable<int> idsrcvoucherperiod { get; set; }
        public Nullable<int> idprocesstype { get; set; }
        public Nullable<int> IDSourceVoucherType { get; set; }
        public Nullable<int> idSrcVoucherType { get; set; }
        public Nullable<System.DateTime> bookdate { get; set; }
        public Nullable<System.DateTime> expduedate { get; set; }
        public Nullable<System.DateTime> producedate { get; set; }
        public Nullable<System.DateTime> wtydate { get; set; }
        public Nullable<System.DateTime> srcvoucherdate { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public Nullable<System.DateTime> SourceVoucherDate { get; set; }
        public Nullable<System.DateTime> BeginDeprMonth { get; set; }
        public Nullable<System.DateTime> EndDeprMonth { get; set; }
        public Nullable<System.DateTime> CardDate { get; set; }
        public string OldTS { get; set; }
        public string ExternalDocInfo { get; set; }
        public string ExternalCode { get; set; }
        public Nullable<int> SrcVoucherOrder { get; set; }
        public Nullable<int> provisionway { get; set; }
    }
}
