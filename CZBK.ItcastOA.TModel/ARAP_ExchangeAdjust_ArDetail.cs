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
    
    public partial class ARAP_ExchangeAdjust_ArDetail
    {
        public string code { get; set; }
        public string detailName { get; set; }
        public Nullable<decimal> adjustAmount { get; set; }
        public Nullable<decimal> origAmount { get; set; }
        public string detailCode { get; set; }
        public string voucherCode { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> differentAmount { get; set; }
        public Nullable<byte> prepayFlag { get; set; }
        public byte[] ts { get; set; }
        public string vouchertimestamp { get; set; }
        public string sourcevouchermemo { get; set; }
        public string saleordercode { get; set; }
        public string sourceordercode { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> IdMember { get; set; }
        public Nullable<int> detailID { get; set; }
        public Nullable<int> idnosettlepartner { get; set; }
        public Nullable<int> idpartner { get; set; }
        public Nullable<int> idperson { get; set; }
        public Nullable<int> IdDetailProject { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> idArapExchangeAdjustDTO { get; set; }
        public int id { get; set; }
        public Nullable<int> voucherDetailID { get; set; }
        public Nullable<int> voucherID { get; set; }
        public Nullable<int> sourceorderid { get; set; }
        public Nullable<int> saleorderid { get; set; }
        public Nullable<int> idsourceordertype { get; set; }
        public Nullable<int> idvouchertype { get; set; }
        public Nullable<System.DateTime> voucherDate { get; set; }
        public Nullable<System.DateTime> arrivalDate { get; set; }
    }
}
