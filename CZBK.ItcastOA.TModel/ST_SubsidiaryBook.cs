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
    
    public partial class ST_SubsidiaryBook
    {
        public string code { get; set; }
        public Nullable<int> accountYear { get; set; }
        public Nullable<int> accountPeriod { get; set; }
        public string voucherCode { get; set; }
        public Nullable<decimal> inQuantity { get; set; }
        public Nullable<decimal> inPrice { get; set; }
        public Nullable<decimal> inAmount { get; set; }
        public Nullable<decimal> outQuantity { get; set; }
        public Nullable<decimal> outPrice { get; set; }
        public Nullable<decimal> outAmount { get; set; }
        public string batch { get; set; }
        public Nullable<byte> isPeriodInit { get; set; }
        public Nullable<byte> isInStock { get; set; }
        public Nullable<byte> isManual { get; set; }
        public Nullable<decimal> inSubQuantity { get; set; }
        public Nullable<byte> isTrueAccount { get; set; }
        public Nullable<byte> isRedVoucher { get; set; }
        public Nullable<int> backVoucher { get; set; }
        public Nullable<decimal> outSubQuantity { get; set; }
        public Nullable<int> orderNo { get; set; }
        public string voucherCodeFlowUnite { get; set; }
        public Nullable<byte> isAdjustVoucher { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public string docid { get; set; }
        public byte[] ts { get; set; }
        public string AccountYearPeriod { get; set; }
        public int id { get; set; }
        public Nullable<int> idbusitype { get; set; }
        public Nullable<int> idbusitypeflowunite { get; set; }
        public Nullable<int> idinventory { get; set; }
        public Nullable<int> idbaseunit { get; set; }
        public Nullable<int> idsubunit { get; set; }
        public Nullable<int> idwarehouse { get; set; }
        public Nullable<int> voucherDetailIDFlowUnite { get; set; }
        public Nullable<int> voucherIDFlowUnite { get; set; }
        public Nullable<int> idvouchertype { get; set; }
        public Nullable<int> idvouchertypeflowunite { get; set; }
        public Nullable<int> purchaseSettleVoucherID { get; set; }
        public Nullable<int> purchaseSettleVoucherDetailID { get; set; }
        public Nullable<int> voucherID { get; set; }
        public Nullable<int> individualID { get; set; }
        public Nullable<int> voucherDetailID { get; set; }
        public Nullable<System.DateTime> accountDate { get; set; }
        public Nullable<System.DateTime> voucherdate { get; set; }
        public Nullable<System.DateTime> auditeddate { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public Nullable<System.DateTime> productionDate { get; set; }
        public Nullable<byte> isneedrecost { get; set; }
    }
}
