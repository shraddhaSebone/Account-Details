using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetailsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountDetailsDummyData accountDetailsDummyData = new AccountDetailsDummyData();
            List<AccountDetailsData> list = accountDetailsDummyData.getAccountDetails();
            foreach(AccountDetailsData data in list)
            {
                Console.WriteLine($"{data.accountId},{data.accountName},{data.amount},{data.interest},{data.time}");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------");
            AggregateOpeartions aggregateOpeartions = new AggregateOpeartions();
            List<TotalAmountDetails> list1 = aggregateOpeartions.getTotalAmountDetails(list);
            foreach(TotalAmountDetails data in list1)
            {
                Console.WriteLine($"{data.accountId},{data.name},{data.totalAmount}");
            }
        }
    }
}
