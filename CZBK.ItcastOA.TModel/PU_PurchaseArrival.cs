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
    
    public partial class PU_PurchaseArrival
    {
        public string code { get; set; }
        public string purchaseInvoiceNo { get; set; }
        public Nullable<decimal> discountRate { get; set; }
        public Nullable<decimal> exchangeRate { get; set; }
        public string acceptAddress { get; set; }
        public string linkMan { get; set; }
        public string linkTelphone { get; set; }
        public Nullable<decimal> origPaymentCashAmount { get; set; }
        public Nullable<decimal> paymentCashAmount { get; set; }
        public Nullable<decimal> origTotalTaxAmount { get; set; }
        public Nullable<decimal> totalTaxAmount { get; set; }
        public Nullable<decimal> origtotalAmount { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public Nullable<byte> isPriceCheck { get; set; }
        public Nullable<byte> isReduceArrival { get; set; }
        public Nullable<byte> isAutoGenerateInvoice { get; set; }
        public Nullable<byte> isAutoGenerateInStock { get; set; }
        public string memo { get; set; }
        public string saleOrderCode { get; set; }
        public Nullable<byte> isNoArapBookkeeping { get; set; }
        public string isNoModify { get; set; }
        public string maker { get; set; }
        public string auditor { get; set; }
        public string reviser { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<byte> ismodifiedcode { get; set; }
        public string docclass { get; set; }
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
        public Nullable<decimal> origPaymentAmount { get; set; }
        public Nullable<decimal> paymentAmount { get; set; }
        public string sourceVoucherCode { get; set; }
        public Nullable<byte> IsBeforeSystemInuse { get; set; }
        public string changer { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public string collaborateVoucherCode { get; set; }
        public int id { get; set; }
        public Nullable<int> idbusinesstype { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> idMarketingOrgan { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idclerk { get; set; }
        public Nullable<int> idqualityclerk { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> idrdstyle { get; set; }
        public Nullable<int> idCollaborateDownVoucherType { get; set; }
        public Nullable<int> CollaborateState { get; set; }
        public Nullable<int> idCollaborateDownDraftVoucher { get; set; }
        public Nullable<int> idwarehouse { get; set; }
        public Nullable<int> deliveryMode { get; set; }
        public Nullable<int> inStockState { get; set; }
        public Nullable<int> invoiceType { get; set; }
        public Nullable<int> payType { get; set; }
        public Nullable<int> settleState { get; set; }
        public Nullable<int> voucherState { get; set; }
        public Nullable<int> auditorid { get; set; }
        public Nullable<int> makerid { get; set; }
        public Nullable<int> changerid { get; set; }
        public Nullable<int> idCollaborateUpVoucherType { get; set; }
        public Nullable<int> idCollaborateUpVoucher { get; set; }
        public Nullable<int> saleOrderId { get; set; }
        public Nullable<int> idsourcevouchertype { get; set; }
        public Nullable<System.DateTime> acceptDate { get; set; }
        public Nullable<System.DateTime> payDate { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> madedate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public Nullable<System.DateTime> sourceVoucherDate { get; set; }
        public Nullable<System.DateTime> changedate { get; set; }
        public string ExternalCode { get; set; }
    }
}
