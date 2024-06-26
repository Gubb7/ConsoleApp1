using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Admin : Person
{
    public virtual void AddClient(string name, int accountNumber)
    {
        Persons.Add(new Client(name, accountNumber));
    }
    public virtual void RemoveClient(int personID)
    {
        Persons[personID];
    }
    public virtual void ViewTransactions()
    {
        foreach(object item in Transactions)
        {
            Console.WriteLine($"ID: {item.TransactionID} \t amount: {item.Amount}\t Time:{item.Timestamp}");
        }
    }
    public virtual void GenerateReport()
    {
        Console.WriteLine($"Total amount of transactions: {Transactions.count}");
    }
}
