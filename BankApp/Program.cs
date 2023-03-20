namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBank = new BankAccount(301268638, "Dongli Liu", 100000);
            double depositAmount;
            double currentBalance;
            Console.WriteLine("Enter the amount to deposit");
            depositAmount = double.Parse(Console.ReadLine());
            myBank.Deposit(depositAmount);
            currentBalance = myBank.Balance;
            Console.WriteLine($"Your current banlance: {currentBalance}");
        }
    }
}