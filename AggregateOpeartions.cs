using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetailsAssignment
{
    internal class AggregateOpeartions
    {
        public List<TotalAmountDetails> getTotalAmountDetails(List<AccountDetailsData> list)
        {
            Dictionary<int, TotalAmountDetails> dict = new Dictionary<int, TotalAmountDetails>();
            List<TotalAmountDetails> result = new List<TotalAmountDetails>();
            foreach(AccountDetailsData data in list)
            {
                if (dict.ContainsKey(data.accountId))
                {
                    dict[data.accountId].accountId = data.accountId;
                    dict[data.accountId].name = data.accountName;
                    dict[data.accountId].totalAmount +=(data.amount*data.interest*(data.time/12)/100) + data.amount;
                }
                else
                {
                    dict.Add(data.accountId, new TotalAmountDetails());
                    dict[data.accountId].accountId = data.accountId;
                    dict[data.accountId].name = data.accountName;
                    dict[data.accountId].totalAmount += (data.amount * data.interest * (data.time / 12) / 100) + data.amount;
                }
            }
            foreach(TotalAmountDetails data1 in dict.Values)
            {
                result.Add(data1);
            }
            return result;
        }
    }
}
