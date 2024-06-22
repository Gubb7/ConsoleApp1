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
        Console.WriteLine($"Your balance is: {Balance.balance_amount}");
    }
    public virtual void update_balance(int amount)
    {
        Balance.balance_amount += amount;
    }
}
