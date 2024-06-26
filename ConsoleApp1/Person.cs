using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    public int PersonID { get; set; }
    public string Name { get; set; }
    public int AccountNumber { get; set; }

    public Person(string name, int accountNumber, int personID = Persons.count) 
    {
        PersonID = personID;
        Name = name;
        AccountNumber = accountNumber;
    }
    public virtual void Deposit(int personID, int amount)
    {
        list.Clients.Where(i => i.PersonID == personID).balance += amount;
    }
    public virtual void Withdraw(int personID, int amount)
    {
        list.Clients.Where(i => i.PersonID == personID).balance -= amount;
    }
    public virtual void GetBalance()
    {
        Console.WriteLine($"Your balance is: {Balance.balanceAmount}");
    }
}