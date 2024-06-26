using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction
{
    private int TransactionID { get; set; }
    public int Amount { get; set; }
    public DateTime Timestamp { get; set; }

    public Transaction(int amount, DateTime timestamp = DateTime.Now, int transactionID = Transactions.count)
    {
        TransactionID = transactionID;
        Amount = amount;
        Timestamp = timestamp;
    }

    public virtual void RecordTransaction(int amount)
    {
        Transactions.Add(new Trasaction(amount));
    }
    public virtual void GetTransactionDetails()
    {
        Console.WriteLine($"Transaction Details\n ID: {Transaction.TransactionID} \n amount: {Transaction.Amount}\n Time:{Transaction.Timestamp}");
    }
}
