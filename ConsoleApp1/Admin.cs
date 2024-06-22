using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Admin : Client
{
    public virtual void add_client(string Name, int Account_number)
    {
        Сlients.Add(new Client(Name, Account_number));
    }
    public virtual void remove_client(int ClientID)
    {
        Clients[ClientID];
    }
    public virtual void view_transactions()
    {
        foreach(object item in Transactions)
        {
            Console.WriteLine($"ID: {item.transaction_id} \t amount: {item.amount}\t Time:{item.timestamp}");
        }
    }
    public virtual void generate_report()
    {
        Console.WriteLine($"Total amount of transactions: {Transactions.count}");
    }
}
