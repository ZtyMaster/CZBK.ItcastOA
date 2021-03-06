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
    
    public partial class MP_CostAllocationOrder_b_tmp
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string sourceVoucherCode { get; set; }
        public byte[] sourcevoucherdetailts { get; set; }
        public byte[] sourcevoucherts { get; set; }
        public string batch { get; set; }
        public Nullable<int> sequencenumber { get; set; }
        public Nullable<decimal> refcost { get; set; }
        public Nullable<decimal> totalrefcost { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public Nullable<decimal> directmaterials { get; set; }
        public Nullable<decimal> indirectmaterials { get; set; }
        public Nullable<decimal> manufacturecost { get; set; }
        public Nullable<decimal> mancost { get; set; }
        public Nullable<decimal> outsourcingcost { get; set; }
        public Nullable<decimal> othercost { get; set; }
        public Nullable<decimal> othercost1 { get; set; }
        public Nullable<decimal> othercost2 { get; set; }
        public Nullable<decimal> totalcost { get; set; }
        public Nullable<decimal> unitcost { get; set; }
        public string jgdcode { get; set; }
        public string rkdcode { get; set; }
        public byte[] ts { get; set; }
        public string priuserdefnvc1 { get; set; }
        public Nullable<decimal> priuserdefdecm1 { get; set; }
        public string priuserdefnvc2 { get; set; }
        public Nullable<decimal> priuserdefdecm2 { get; set; }
        public string priuserdefnvc3 { get; set; }
        public Nullable<decimal> priuserdefdecm3 { get; set; }
        public string priuserdefnvc4 { get; set; }
        public Nullable<decimal> priuserdefdecm4 { get; set; }
        public string pubuserdefnvc1 { get; set; }
        public Nullable<decimal> pubuserdefdecm1 { get; set; }
        public string pubuserdefnvc2 { get; set; }
        public Nullable<decimal> pubuserdefdecm2 { get; set; }
        public string pubuserdefnvc3 { get; set; }
        public Nullable<decimal> pubuserdefdecm3 { get; set; }
        public string pubuserdefnvc4 { get; set; }
        public Nullable<decimal> pubuserdefdecm4 { get; set; }
        public Nullable<int> idinventory { get; set; }
        public Nullable<int> idproject { get; set; }
        public Nullable<int> idbaseunit { get; set; }
        public Nullable<int> idWarehouse { get; set; }
        public Nullable<int> CurrUserID { get; set; }
        public Nullable<int> idCostAllocationOrderDTO { get; set; }
        public Nullable<int> jgdid { get; set; }
        public Nullable<int> jgdDetailId { get; set; }
        public Nullable<int> rkdid { get; set; }
        public Nullable<int> sourceVoucherId { get; set; }
        public Nullable<int> rkdDetailId { get; set; }
        public Nullable<int> sourceVoucherDetailId { get; set; }
        public Nullable<System.DateTime> createdtime { get; set; }
        public Nullable<int> SourceVoucherTypeId { get; set; }
    }
}
