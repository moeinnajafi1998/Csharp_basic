// Encapsulation:
// Encapsulation is the principle of hiding the internal details of an object and exposing only what is necessary.
// This is achieved using access modifiers like private, protected, and public.
// It helps in protecting the internal state of the object from unintended interference and misuse.
public class BankAccount
{
    private decimal balance;
    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }
    
    public decimal GetBalance()
    {
        return balance;
    }
}

class Program{
    static void Main(string[] args){
        BankAccount account = new BankAccount();
        account.Deposit(100);
        Console.WriteLine(account.GetBalance()); // Output: 100
    }
}


