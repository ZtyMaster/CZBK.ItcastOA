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
    
    public partial class SA_SaleOrder
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<decimal> discountRate { get; set; }
        public Nullable<decimal> discountAmount { get; set; }
        public Nullable<decimal> origDiscountAmount { get; set; }
        public Nullable<decimal> exchangeRate { get; set; }
        public string address { get; set; }
        public string linkMan { get; set; }
        public string contractCode { get; set; }
        public Nullable<decimal> origEarnestMoney { get; set; }
        public Nullable<decimal> earnestMoney { get; set; }
        public string memo { get; set; }
        public Nullable<decimal> origAmount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> origTaxAmount { get; set; }
        public Nullable<decimal> taxAmount { get; set; }
        public string contactPhone { get; set; }
        public string maker { get; set; }
        public string auditor { get; set; }
        public string reviser { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public string docid { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
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
        public Nullable<byte> IsAutoGenerateSaleOrderBOM { get; set; }
        public Nullable<byte> IsAutoGenerateRouting { get; set; }
        public string SourceVoucherCode { get; set; }
        public string isnomodify { get; set; }
        public string changer { get; set; }
        public string Mobilephone { get; set; }
        public string MemberAddress { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public Nullable<byte> IsSeparateByWareHouse { get; set; }
        public Nullable<decimal> OrigReceiveAmount { get; set; }
        public Nullable<decimal> ReceiveAmount { get; set; }
        public string collaborateVoucherCode { get; set; }
        public string ExternalCode { get; set; }
        public int ID { get; set; }
        public Nullable<int> idbusinesstype { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> IdMember { get; set; }
        public Nullable<int> idmarketingOrgan { get; set; }
        public Nullable<int> idcustomer { get; set; }
        public Nullable<int> idsettlecustomer { get; set; }
        public Nullable<int> idclerk { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> idwarehouse { get; set; }
        public Nullable<int> idCollaborateUpVoucherType { get; set; }
        public Nullable<int> idCollaborateUpVoucher { get; set; }
        public Nullable<int> DataSource { get; set; }
        public Nullable<int> deliveryMode { get; set; }
        public Nullable<int> isCancel { get; set; }
        public Nullable<int> isSaleDelivery { get; set; }
        public Nullable<int> isSaleOut { get; set; }
        public Nullable<int> reciveType { get; set; }
        public Nullable<int> voucherState { get; set; }
        public Nullable<int> auditorid { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<int> changerid { get; set; }
        public Nullable<int> idCollaborateDownVoucherType { get; set; }
        public Nullable<int> CollaborateState { get; set; }
        public Nullable<int> idCollaborateDownDraftVoucher { get; set; }
        public Nullable<int> SourceVoucherID { get; set; }
        public Nullable<int> idsourcevouchertype { get; set; }
        public Nullable<System.DateTime> deliveryDate { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public Nullable<System.DateTime> changedate { get; set; }
        public string ExternalVoucherCode { get; set; }
    }
}
