using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction
{
    private int transaction_id { get; set; }
    public int amount { get; set; }
    public DateTime timestamp { get; set; }

    public Transaction(int Amount, DateTime Timestamp = DateTime.Now, int Transaction_id = Transactions.count)
    {
        transaction_id = Transaction_id;
        amount = Amount;
        timestamp = Timestamp;
    }

    public virtual void record_transaction(int amount)
    {
        Transactions.Add(new Trasaction(amount));
    }
    public virtual void get_transaction_details()
    {
        Console.WriteLine($"Transaction Details\n ID: {Transaction.transaction_id} \n amount: {Transaction.amount}\n Time:{Transaction.timestamp}");
    }
}
