public class Balance
{
    public int BalanceID { get; set; }
    public int PersonID { get; set; }
    public int BalanceAmount { get; set; }

    public Balance(int balanceID, int personID, int balanceAmount)
    {
        BalanceID = balanceID;
        PersonID = personID;
        BalanceAmount = balanceAmount;
    }

    public virtual void GetBalance()
    {
        Console.WriteLine($"Your balance is: {Balance.BalanceAmount}");
    }
    public virtual void UpdateBalance(int amount)
    {
        Balance.Balance_amount += amount;
    }
}
