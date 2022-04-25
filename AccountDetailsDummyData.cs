using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetailsAssignment
{
    internal class AccountDetailsDummyData
    {
        public List<AccountDetailsData> getAccountDetails()
        {
            List<AccountDetailsData> listData = new List<AccountDetailsData>();
            AccountDetailsData depositeData1 = new AccountDetailsData(101, "Raj", 10000, 8, 4);
            listData.Add(depositeData1);
            AccountDetailsData depositeData2 = new AccountDetailsData(102, "Ram", 15000, 7, 6);
            listData.Add(depositeData2);
            AccountDetailsData depositeData3 = new AccountDetailsData(101, "Raj", 25000, 10, 8);
            listData.Add(depositeData3);
            AccountDetailsData depositeData4 = new AccountDetailsData(103, "Ravi", 12000, 8, 12);
            listData.Add(depositeData4);
            AccountDetailsData depositeData5 = new AccountDetailsData(104, "ABC", 11000, 7, 10);
            listData.Add(depositeData5);
            AccountDetailsData depositeData6 = new AccountDetailsData(102, "Ram", 20000, 6, 6);
            listData.Add(depositeData6);
            AccountDetailsData depositeData7 = new AccountDetailsData(101, "Raj", 15000, 8, 8);
            listData.Add(depositeData7);

            return listData;
        }
    }
}
