// Design an interface Ibank with two methods Deposit() and withdraw(). Create a class Account that implements the interface and performs basics banking Operations
// based on user Input

interface Ibank
{
    void Deposit();
    void Withdraw();
}

class Account : Ibank
{
    public int curr_amt = 0;
    public void Deposit()
    {
        Console.WriteLine("Enter the amount to deposit: ");
        int d_amt = int.Parse(Console.ReadLine());
        if(d_amt < 0)
        {
            Console.WriteLine("Invalid Amount. Please enter a positive value.");
            return;
        }
        curr_amt = curr_amt + d_amt;
    }

    public void Withdraw()
    {
        Console.WriteLine("Enter the amount to withdraw: ");
        int w_amt = int.Parse(Console.ReadLine());
        if(w_amt > curr_amt)
        {
            Console.WriteLine("Insufficient Amount.");
            return;
        }
        curr_amt = curr_amt - w_amt;
    }

    public void display()
    {
        Console.WriteLine($"Your current balance is {curr_amt}");
    }

    public static void Main(String[]args)
    {
        Account a = new Account();
        Console.WriteLine("Welcome to Bank Oprations Program");
        while (true)
        {
            Console.WriteLine("1. Deposit \n2. Withdraw \n3.Display Amount \n4. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                a.Deposit();
                break;

                case 2:
                a.Withdraw();
                break;

                case 3:
                a.display();
                break;

                case 4:
                return;
            }
        }
    }
}
