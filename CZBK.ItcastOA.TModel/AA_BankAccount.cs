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
    
    public partial class AA_BankAccount
    {
        public string code { get; set; }
        public string name { get; set; }
        public string bankNo { get; set; }
        public Nullable<byte> disabled { get; set; }
        public byte[] ts { get; set; }
        public string updatedBy { get; set; }
        public Nullable<byte> isusingdeficitcontrol { get; set; }
        public Nullable<byte> isusingbankcheck { get; set; }
        public Nullable<decimal> NewBalance { get; set; }
        public Nullable<byte> VirtualPay { get; set; }
        public int id { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> iddepartment { get; set; }
        public Nullable<int> idMarketingOrgan { get; set; }
        public Nullable<int> balancedirection { get; set; }
        public Nullable<int> bankName { get; set; }
        public Nullable<int> bankNoType { get; set; }
        public Nullable<System.DateTime> madeDate { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public Nullable<System.DateTime> dateofusingbankcheck { get; set; }
        public Nullable<System.DateTime> createdTime { get; set; }
        public string WeixinAppID { get; set; }
        public string WeixinPayKey { get; set; }
        public string AlipayServiceNo { get; set; }
        public string AlipayAppID { get; set; }
        public string WeiXinMerchantNo { get; set; }
        public string WeiXinServiceNo { get; set; }
        public string WeiXinServiceAPPID { get; set; }
    }
}
