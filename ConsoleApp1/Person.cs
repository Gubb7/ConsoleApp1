using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person : Client
{
    public string address { get; set; }
    public Person(string Address, string Name, int Account_number, int ClientID = Clients.count) : base(Name, Account_number, ClientID)
    {
        address = Address;
    }
}