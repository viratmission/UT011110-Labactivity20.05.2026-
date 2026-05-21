using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
namespace BankApplication

{
    class BankAccount
    {
        public string bankName = "Amana Bank";
        public string accountHolder;
        public int accNumber = 91234567;
        public decimal accBalance;
        public string accType = "Fixed Deposit";
        public decimal withdraw;
        public decimal deposit;
        List<string> accounts = new List<string>();

        transaction trans = new transaction();
        Program program = new Program();
       
        
        //public double updateBalance = accbalance + Deposit;
        //public updateBalance = accbalance - Withdraw;
        public void Welcome()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                   Amana Bank                       ");
            Console.WriteLine($"            Welcome to Our Bank !                  ");
            Console.WriteLine("----------------------------------------------------");
        }
        public void Menu()
        {
            Console.WriteLine($"\n               ------- Menu -------             \n\n1. View Account \n2. Check Balance \n3. Deposit \n4. Withdrawal \n5. Transaction History \n6. Exit ");
            Console.WriteLine("");
        }
        public void AccDetails(BankAccount account)
        {
            Console.WriteLine("            ----------------------");
            Console.WriteLine($"               Account Details\n" +
            $"            ----------------------\n" + "\n" +
            $"Account Holder Name              : {accountHolder}\n" +
            $"Account Number                   : {accNumber}\n" +
            $"Account Balance                  : Rs.{accBalance:F2}");
            Console.WriteLine();
            Console.Write($"\nPress any key to move on...");
            Console.ReadKey();
            Console.Clear();
        }
        public void Deposit(BankAccount account)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                   Amana Bank                       ");
            Console.WriteLine($"            Welcome to Our Bank {accountHolder} !  ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("      -------- Deposit Your Cash !! -------- ");
            Console.WriteLine();
            
            
            Console.Write("Ennter Your Deposit Amount      : ");
            deposit = Convert.ToInt32(Console.ReadLine());
            accounts.Add($"{trans.Date}     {accountHolder}     Deposit  +{deposit}       Rs.{accBalance+deposit}.00");
            
            if (deposit > 0)
            {
                account.accBalance += account.deposit;
                Console.WriteLine($"Deposit Completed !!\nNow Your Balance is Rs.{accBalance}"); //updateDeposit


            }

            else { Console.WriteLine("Deposit Amount Is Invalid !!!"); }
            Console.Write($"\nPress any key to move on...");
            
            Console.ReadKey();
            Console.Clear();

        }
        

        public void Withdraw(BankAccount account)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                   Amana Bank                       ");
            Console.WriteLine($"            Welcome to Our Bank {accountHolder} !  ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("    -------- Widthdraw Your Cash !! -------- ");
            Console.WriteLine();


            Console.Write("Enter your Widthrawal Amount        : ");
            account.withdraw = Convert.ToInt32(Console.ReadLine());
            accounts.Add(trans.Date+"     "+accountHolder+"    "+"Withdraw  -"+withdraw+ "     "+"Rs."+$"{  accBalance-withdraw}"+".00");

            if (account.withdraw > 0 && account.withdraw < account.accBalance)
            {
               accBalance -= withdraw;
                Console.WriteLine($"Widhrawal Completed !!\nNow Your Balance Is Rs.{accBalance}"); //updateWithdraw
            }
            else { Console.WriteLine("Withdrawal Amount Is Invalid !!!"); }
            Console.Write($"\nPress any key to move on...");
            Console.ReadKey();
            Console.Clear();
        }
        public void transaction()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                         Amana Bank                       ");
            Console.WriteLine($"                  Welcome to Our Bank {accountHolder} !  ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("       ------------- Transaction History ------------        ");
            Console.WriteLine();
            Console.WriteLine("Date   &   Time          Name         Type & Money      Balance  ");
            Console.WriteLine();

            foreach (var s in accounts)
            {
             Console.WriteLine(s);
                
            };
            



            Console.Write($"\nPress any key to move on...");
            Console.ReadKey();
            Console.Clear();
        }

    }
    class transaction
    {
        public int id;
        public DateTime Date = DateTime.Now;
        public void print()
        {
            Console.WriteLine($"");
        }
    }
    class Program
    {
        static void Main()
        {
            //Part 1 

            BankAccount account = new BankAccount();
            account.Welcome();
            
            //Part 2

            Console.Write("Enter your Name                  : ");
            account.accountHolder = Console.ReadLine();
            Console.WriteLine("Welcome To Our Bank              : " + account.accountHolder);
            Console.Write("Enter Your Opening Amount        : ");
            account.accBalance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Current Balance                  : Rs." + account.accBalance + ".00");
            //string accountHolder = Console.ReadLine();
            Console.WriteLine("....................................................");
            Console.WriteLine();


            //Part 3

            /*Console.Write("Enter Your Name                  :   ");
            string userName = Console.ReadLine();
            Console.WriteLine("Evaluate Your Future !           :" + "   " + userName);
            Console.Write("Enter Your Opening Amount        :   ");
            int openingBalance = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Opening balance is          :" + "   " + openingBalance);
            Console.WriteLine();*/

            //Part 4

            account.AccDetails(account);

            //part 5

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("                   Amana Bank                       ");
                Console.WriteLine($"            Welcome to Our Bank {account.accountHolder} !  ");
                Console.WriteLine("----------------------------------------------------");

                account.Menu();
                Console.WriteLine("Choose a option in the Menu");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("                   Amana Bank                       ");
                        Console.WriteLine($"            Welcome to Our Bank {account.accountHolder} !  ");
                        Console.WriteLine("----------------------------------------------------");

                        Console.WriteLine("            ----------------------");
                        Console.WriteLine($"               Account Details\n" +
                        $"            ----------------------\n" + "\n" +
                        $"Account Holder Name              : {account.accountHolder}\n" +
                        $"Account Number                   : {account.accNumber}\n" +
                        $"Account Balance                  : Rs.{account.accBalance.ToString("F2")}");
                        Console.WriteLine();
                        Console.Write($"\nPress any key to move on...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("                   Amana Bank                       ");
                        Console.WriteLine($"            Welcome to Our Bank {account.accountHolder} !  ");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine();

                        Console.WriteLine("        ------- Your Account Balance ------- ");
                        Console.WriteLine();

                        Console.WriteLine($"Your Account Balance is : Rs.{account.accBalance}");
                        Console.Write($"\nPress any key to move on...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        account.Deposit(account);
                        break;

                    case 4:
                        account.Withdraw(account);
                        break;

                    case 5:
                        account.transaction();

                        break;


                    case 6:
                        exit = false;
                        Console.Clear();
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("                   Amana Bank                       ");
                        Console.WriteLine($"               See you Later {account.accountHolder} !         ");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine();

                        Console.WriteLine($"Thank You for Choosing Our Bank Nice To Meet U {account.accountHolder}....");
                        Console.Write($"\nPress any key to move on...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Choices Identified !!!");
                        Console.Write($"\nPress any key to move on...");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }
            }
            Console.WriteLine($"See You later {account.accountHolder}....");
            Console.ReadKey();
        }

        /*public static void Welcome()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                   Amana Bank                       ");
            Console.WriteLine($"            Welcome to Our Bank !                  ");
            Console.WriteLine("----------------------------------------------------");
        }*/
        /*public static void Menu()
        {
            Console.WriteLine($"\n               ------- Menu -------             \n\n1. View Account \n2. Check Balance \n3. Deposit \n4. Withdrawal \n5. Reloads & Pay Bills \n6. Exit ");
            Console.WriteLine("");
        }*/
        /* public static void AccDetails(string accountHolder, int accNumber, double accBalance)
         {
             Console.WriteLine("            ----------------------");
             Console.WriteLine($"               Account Details\n" +
             $"            ----------------------\n" + "\n" +
             $"Account Holder Name              : {accountHolder}\n" +
             $"Account Number                   : {accNumber}\n" +
             $"Account Balance                  : Rs.{accBalance:F2}");
             Console.WriteLine();
             Console.Write($"\nPress any key to move on...");
             Console.ReadKey();
             Console.Clear();
         }*/
        /* public static void Deposit(string accountHolder, double accBalance)
         {
             Console.Clear();
             Console.WriteLine("----------------------------------------------------");
             Console.WriteLine("                   Amana Bank                       ");
             Console.WriteLine($"            Welcome to Our Bank {accountHolder} !  ");
             Console.WriteLine("----------------------------------------------------");
             Console.WriteLine();

             Console.WriteLine("      -------- Deposit Your Cash !! -------- ");
             Console.WriteLine();

             Console.Write("Ennter Your Deposit Amount      : ");
             int Deposit = Convert.ToInt32(Console.ReadLine());
             if (Deposit > 0)
             {
                 Console.WriteLine($"Deposit Completed !!\nNow Your Balance is Rs.{accBalance + Deposit}");
             }
             else { Console.WriteLine("Deposit Amount Is Invalid !!!"); }
             Console.Write($"\nPress any key to move on...");
             Console.ReadKey();
             Console.Clear();

         }*/
        /* public static void Withdraw(string accountHolder, double accBalance)
         {
             Console.Clear();
             Console.WriteLine("----------------------------------------------------");
             Console.WriteLine("                   Amana Bank                       ");
             Console.WriteLine($"            Welcome to Our Bank {accountHolder} !  ");
             Console.WriteLine("----------------------------------------------------");
             Console.WriteLine();

             Console.WriteLine("    -------- Widthdraw Your Cash !! -------- ");
             Console.WriteLine();

             Console.Write("Enter your Widthrawal Amount        : ");
             int Withdraw = Convert.ToInt32(Console.ReadLine());
             if (Withdraw > 0)
             {
                 Console.WriteLine($"Widhrawal Completed !!\nNow Your Balance Is Rs.{accBalance - Withdraw}");
             }
             else { Console.WriteLine("Withdrawal Amount Is Invalid !!!"); }
             Console.Write($"\nPress any key to move on...");
             Console.ReadKey();
             Console.Clear();
         }*/

    }

}


