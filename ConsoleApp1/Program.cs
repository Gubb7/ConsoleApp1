using System;
using System.Data.Common;

int clientCount = 0;
int TransactionIDCount = 0;

Client client1 = new Client(clientCount, "Tom", 0);
Balance balance1 = new Balance(clientCount, clientCount, 0);
Transaction transaction1 = new(0, 300, DateTime.Now);

transaction1.get_transaction_details();

public class Transaction
{
    private int transaction_id { get; set; }
    public int amount { get; set; }
    public DateTime timestamp { get; set; }

    public Transaction(int Transaction_id, int Amount, DateTime Timestamp)
    {
        transaction_id = Transaction_id;
        amount = Amount;
        timestamp = Timestamp;
    }

    public virtual object record_transaction()
    {
        TransactionIDCount++;
        Console.Write("enter amount of money");
        return new Transaction(TransactionIDCount, Convert.ToInt32(Console.ReadLine()), DateTime.Now);
    }
    public virtual void get_transaction_details()
    {
        Console.WriteLine($"Transaction Details\n ID: {Transaction.transaction_id} \n amount: {Transaction.amount}\n Time:{Transaction.timestamp}");
    }
}
public class Balance
{
    public int balance_id { get; set; }
    public int client_id { get; set; }
    public int balance_amount { get; set; }

    public Balance(int Balance_id, int Client_id, int Balance_amount)
    {
        balance_id = Balance_id;
        client_id = Client_id;
        balance_amount = Balance_amount;
    }

    public virtual void get_balance()
    {
        Console.WriteLine($"Your balance is: {balance1.balance_amount}");
    }
    public virtual void update_balance(int amount)
    {
        balance1.balance_amount += amount;
    }
}
public class Client
{
    public int client_id { get; set; }
    public string name { get; set; }
    public int account_number { get; set; }

    public Client(int Client_id, string Name, int Account_number)
    {
        client_id = Client_id;
        name = Name;
        account_number = Account_number;
    }
    public virtual void deposit(amount)
    {
    
    }
    public virtual void withdraw(amount);
    public virtual void get_balance()
    {
        Console.WriteLine("$Your balance is: {balance1.balance_amount}");
    }
}
}   
public class Person : Client
{
    public Person(int person_id) : base(client_id) { }
}
public class Admin
{
    public virtual object add_client()
    {
        return new Client(999, "john", 999);
    }
    public virtual void remove_client(object client)
    {
        client = null;
    }
    public virtual void view_transactions()
    {

    }
    public virtual void generate_report()
    {

    }
}