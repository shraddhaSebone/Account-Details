using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetailsAssignment
{
    internal class AccountDetailsData
    {
        public int accountId { get; set; }
        public string accountName { get; set; }
        public float amount { get; set; }
        public float interest { get; set; }
        public int time { get; set; }
        public AccountDetailsData() { }
        public AccountDetailsData(int accountId, string accountName, float amount, float interest, int time)
        {
            this.accountId = accountId;
            this.accountName = accountName;
            this.amount = amount;
            this.interest = interest;
            this.time = time;

        }
    }
}
