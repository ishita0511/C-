using System;

namespace BankingDomain
{
    public delegate void BankingOperations();
    class Account
    {
        public int accountNumber { get; set;}
        public string customerName { get; set;}
        public float balance { get; set;}

        public event BankingOperations UnderBalance;
        public event BankingOperations BalanceZero;

        public void Withdraw(float withdrawlAmt)
        {
            if (balance >= withdrawlAmt)
            {
                balance -= withdrawlAmt;
            }
            else
            {
                UnderBalance();
            }
        }

        public void Deposit(float depositAmt)
        {
            balance += depositAmt;
        }

        public void Display()
        {
            Console.WriteLine("Customer Name: {0}", customerName);
            Console.WriteLine("Account Number: {0}", accountNumber);
            Console.WriteLine("Balance: {0}", balance);
        }

        public static void Main(string[] args)
        {
            Account obj = new Account
            {
                accountNumber = 579,
                customerName = "ABC Jain",
                balance = 10000.0F
            };

            int choice = 0;
            do
            {
                Console.WriteLine("1. Withdraw\n2. Deposit\n3. Display Balance\n4. Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (obj.balance == 0)
                    obj.BalanceZero();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Amount to be withdrawn");
                        float wAmt = Convert.ToSingle(Console.ReadLine());
                        obj.Withdraw(wAmt);
                        break;

                    case 2:
                        Console.WriteLine("Enter Amount to be deposited");
                        float dAmt = Convert.ToSingle(Console.ReadLine());
                        obj.Deposit(dAmt);
                        break;

                    case 3:
                        obj.Display();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;
                }
            } while (choice != 4);
        }
    }
}
