using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetailsAssignment
{
    internal class TotalAmountDetails
    {
        public int accountId { get; set; }
        public string name { get; set; }
        public float totalAmount { get; set; }
        public TotalAmountDetails() { }
        public TotalAmountDetails(int accountId,string name, float totalAmount)
        {
            this.accountId = accountId;
            this.name = name;
            this.totalAmount = totalAmount;
        }
    }
}
