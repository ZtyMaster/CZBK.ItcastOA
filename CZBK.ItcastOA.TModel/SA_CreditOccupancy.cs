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
    
    public partial class SA_CreditOccupancy
    {
        public Nullable<decimal> orderunoutamount { get; set; }
        public Nullable<decimal> outunsettleamount { get; set; }
        public Nullable<decimal> salesettleamount { get; set; }
        public Nullable<decimal> incomeunsettleamount { get; set; }
        public Nullable<decimal> receiveuncancelamount { get; set; }
        public byte[] ts { get; set; }
        public Nullable<byte> iscarriedforwardout { get; set; }
        public Nullable<byte> iscarriedforwardin { get; set; }
        public Nullable<decimal> expenseSettleAmount { get; set; }
        public Nullable<decimal> orderUnOutAmountForAudit { get; set; }
        public Nullable<decimal> outUnSettleAmountForAudit { get; set; }
        public Nullable<decimal> saleSettleAmountForAudit { get; set; }
        public Nullable<decimal> incomeUnSettleAmountForAudit { get; set; }
        public Nullable<decimal> receiveUnCancelAmountForAudit { get; set; }
        public Nullable<decimal> expenseSettleAmountForAudit { get; set; }
        public int id { get; set; }
        public Nullable<int> idcustomer { get; set; }
        public Nullable<int> idclerk { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}