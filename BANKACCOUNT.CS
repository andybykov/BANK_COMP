
using System;

class BankAccount : IComparable<BankAccount>
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;

    private static long nextNumber = 123;

    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
            this.Deposit(amount);
    }

    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
        }
        return sufficientFunds;
    }

    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextNumber++;
    }

    public int CompareTo(BankAccount other)
    {
        // If other is not a valid object reference, this instance is greater.
        if (other == null) return 1;

        return accBal.CompareTo(other.accBal);
    }
}
