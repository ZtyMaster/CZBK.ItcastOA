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
    
    public partial class B2B_WarehouseUploadLog
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseCode { get; set; }
        public byte[] WarehouseTs { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
    }
}
