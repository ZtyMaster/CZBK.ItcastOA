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
    
    public partial class RE_ReceiveDetail
    {
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public string shiftvouchercode { get; set; }
        public string poscode { get; set; }
        public string posname { get; set; }
        public string usercode { get; set; }
        public string username { get; set; }
        public string receivercode { get; set; }
        public string receivername { get; set; }
        public string workingtime { get; set; }
        public string shifttime { get; set; }
        public string receivetime { get; set; }
        public Nullable<decimal> origamount { get; set; }
        public Nullable<decimal> origsettleamount { get; set; }
        public Nullable<decimal> origfactsettleamount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> settleamount { get; set; }
        public Nullable<decimal> factsettleamount { get; set; }
        public Nullable<decimal> initialamount { get; set; }
        public Nullable<decimal> imprestamount { get; set; }
        public Nullable<decimal> imprestbalanceamount { get; set; }
        public Nullable<int> extendflag { get; set; }
        public Nullable<decimal> exchangerate { get; set; }
        public byte[] ts { get; set; }
        public string dailyDetailCode { get; set; }
        public string dailyTime { get; set; }
        public Nullable<int> idbankaccount { get; set; }
        public Nullable<int> idreceivebankaccount { get; set; }
        public Nullable<int> idcurrency { get; set; }
        public Nullable<int> idstore { get; set; }
        public Nullable<int> idsettlestyle { get; set; }
        public Nullable<int> userid { get; set; }
        public Nullable<int> receiverid { get; set; }
        public Nullable<long> dailyDetailID { get; set; }
        public Nullable<long> shiftvoucherid { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<System.DateTime> shiftvoucherdate { get; set; }
        public Nullable<System.DateTime> workingdate { get; set; }
        public Nullable<System.DateTime> shiftdate { get; set; }
        public Nullable<System.DateTime> receivedate { get; set; }
        public Nullable<System.DateTime> dailyDetailDate { get; set; }
        public long ID { get; set; }
        public int autoid { get; set; }
    }
}
