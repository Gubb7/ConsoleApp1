using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Client : Person
{
    public string address { get; set; }
    public Client(string address, string name, int accountNumber, int personID = Persons.count) : base(name, accountNumber, personID)
    {
        Address = address;
    }
}