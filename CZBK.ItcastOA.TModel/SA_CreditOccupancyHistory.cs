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
    
    public partial class SA_CreditOccupancyHistory
    {
        public int id { get; set; }
        public Nullable<decimal> orderunoutamount { get; set; }
        public Nullable<decimal> outunsettleamount { get; set; }
        public Nullable<decimal> salesettleamount { get; set; }
        public Nullable<decimal> incomeunsettleamount { get; set; }
        public Nullable<decimal> receiveuncancelamount { get; set; }
        public byte[] ts { get; set; }
        public Nullable<decimal> expenseSettleAmount { get; set; }
        public Nullable<decimal> orderunoutamountForAudit { get; set; }
        public Nullable<decimal> outunsettleamountForAudit { get; set; }
        public Nullable<decimal> salesettleamountForAudit { get; set; }
        public Nullable<decimal> incomeunsettleamountForAudit { get; set; }
        public Nullable<decimal> receiveuncancelamountForAudit { get; set; }
        public Nullable<decimal> expenseSettleAmountForAudit { get; set; }
        public Nullable<int> idcustomer { get; set; }
        public Nullable<int> idclerk { get; set; }
        public string operationType { get; set; }
        public string voucherCode { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    }
}
