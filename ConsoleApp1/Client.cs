using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




int ID = 1;
public class Client
{
    public int client_id { get; set; }
    public string name { get; set; }
    public int account_number { get; set; }

    public Client(string Name, int Account_number, int ClientID = Clients.count) 
    {
        client_id = ClientID;
        name = Name;
        account_number = Account_number;
    }
    public virtual void deposit(int clientID, int amount)
    {
        list.Clients.Where(i => i.client_id == clientID).balance += amount;
    }
    public virtual void withdraw(int clientID, int amount)
    {
        list.Clients.Where(i => i.client_id == clientID).balance -= amount;
    }
    public virtual void get_balance()
    {
        Console.WriteLine($"Your balance is: {Balance.balance_amount}");
    }
}