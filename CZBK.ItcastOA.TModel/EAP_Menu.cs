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
    
    public partial class EAP_Menu
    {
        public int id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortCut { get; set; }
        public short Grade { get; set; }
        public string SupMenuID { get; set; }
        public Nullable<bool> EndGrade { get; set; }
        public Nullable<int> ShowIndex { get; set; }
        public string RequestUrl { get; set; }
        public string GroupFlow { get; set; }
        public Nullable<bool> IsItemGroup { get; set; }
        public bool IsControl { get; set; }
        public string Version { get; set; }
        public Nullable<short> AccountType { get; set; }
        public bool Visibility { get; set; }
        public byte[] ts { get; set; }
        public string inID { get; set; }
        public string PrivilegeID { get; set; }
        public string ExpressionName { get; set; }
        public Nullable<int> InvBarCodeVoucher { get; set; }
        public Nullable<int> TFlag { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<bool> isCommonUse { get; set; }
        public string RelationMenuCode { get; set; }
        public string RelationMenuTitle { get; set; }
        public string SupMenuID2 { get; set; }
        public Nullable<int> ShowIndex2 { get; set; }
        public Nullable<int> MenuIn { get; set; }
        public Nullable<bool> TabCache { get; set; }
    }
}