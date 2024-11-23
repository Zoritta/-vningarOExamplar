using System.Diagnostics.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {
        int balance = 340;
        Console.WriteLine("How much du you want to deposite?");
        string deposite = Console.ReadLine()!;
        balance += int.Parse(deposite);
        DisplayBalance(balance);
        Console.WriteLine("How much do you want to withdraw?");
        string withdraw = Console.ReadLine()!;
        balance -= int.Parse(withdraw);
        DisplayBalance(balance);
    }

    static void DisplayBalance(int balance){
        Console.WriteLine("Your account balance is: " + balance);
    }
}