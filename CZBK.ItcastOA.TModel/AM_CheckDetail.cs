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
    
    public partial class AM_CheckDetail
    {
        public string code { get; set; }
        public Nullable<int> qty { get; set; }
        public byte[] ts { get; set; }
        public string MutiDept { get; set; }
        public string OldBarCode { get; set; }
        public string OldCode { get; set; }
        public string OldName { get; set; }
        public string OldSpec { get; set; }
        public Nullable<int> OldQty { get; set; }
        public string OldMutiDept { get; set; }
        public Nullable<int> idadmindept { get; set; }
        public Nullable<int> idOldAdminDept { get; set; }
        public Nullable<int> idOldUsePerson { get; set; }
        public Nullable<int> iduseperson { get; set; }
        public Nullable<int> idOldPosition { get; set; }
        public Nullable<int> idposition { get; set; }
        public Nullable<int> idOldUseStatus { get; set; }
        public Nullable<int> iduseStatus { get; set; }
        public Nullable<int> idasset { get; set; }
        public int id { get; set; }
        public Nullable<int> idAMCheckVoucherDTO { get; set; }
        public Nullable<int> admindeptcheckresult { get; set; }
        public Nullable<int> positioncheckresult { get; set; }
        public Nullable<int> qtycheckresult { get; set; }
        public Nullable<int> usedeptcheckresult { get; set; }
        public Nullable<int> usepersoncheckresult { get; set; }
        public Nullable<int> UseStatusCheckResult { get; set; }
    }
}
