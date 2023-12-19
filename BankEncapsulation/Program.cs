namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            
            //Console.WriteLine("How much would you like to deposit?");
            
            //var depositAmount = double.Parse(Console.ReadLine());

            //account.Deposit(depositAmount);

            //Console.WriteLine($"Your balance is now {account.GetBalance()}");

            var toDo = ("check balance", "deposit", "withdraw", "transfer", "exit");
            

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Check balance, Deposit, Withdraw, Transfer, Exit");
            var toDoEntered = (Console.ReadLine().ToLower());

            while (toDoEntered != "exit")
            {
                if (toDoEntered == "check balance")
                {
                    Console.WriteLine($"Your Balance is ${account.GetBalance()}");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("Check balance, Deposit, Withdraw, Transfer, Exit");
                    toDoEntered = Console.ReadLine().ToLower();
                    if (toDoEntered != "exit")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Thank you. Have a Nice day.");
                        break;
                    }
                }
                if (toDoEntered == "deposit")
                {

                    Console.WriteLine("How much would you like to deposit?");

                    var depositAmount = double.Parse(Console.ReadLine());
                    
                    account.Deposit(depositAmount);

                    Console.WriteLine($"Your balance is now ${account.GetBalance()}");

                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("Check balance, Deposit, Withdraw, Transfer, Exit");
                    toDoEntered=Console.ReadLine().ToLower();
                    if (toDoEntered != "exit")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Thank you. Have a Nice day.");
                        break;
                    }

                }
                if (toDoEntered == "withdraw")
                {
                    if (account.GetBalance() > 0) 
                    {
                        Console.WriteLine("How much would you like to withdraw?");

                        var withdrawAmount = double.Parse(Console.ReadLine());

                        if (withdrawAmount <= account.GetBalance())
                        {
                            account.Withdrawal(withdrawAmount);

                            Console.WriteLine($"Your balance is now ${account.GetBalance()}");

                            Console.WriteLine();
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("Check balance, Deposit, Withdraw, Transfer, Exit");
                            toDoEntered = Console.ReadLine().ToLower();
                            if (toDoEntered != "exit")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Thank you. Have a Nice day.");
                                break;
                            }
                        }
                        else if (withdrawAmount > account.GetBalance())
                        {
                            Console.WriteLine("That amount exeeds your balance. Please enter a new amount.");
                            withdrawAmount = double.Parse(Console.ReadLine());

                            if (withdrawAmount <= account.GetBalance())
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("This transaction has been cancelled.");
                                break;
                            }

                        }


                    }
                    else
                    {
                        Console.WriteLine("You have insufficient fund your balance to proceed. Please select a different action.");
                        Console.WriteLine();
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("Check balance, Deposit, Withdraw, Transfer, Exit");
                        toDoEntered = Console.ReadLine().ToLower();
                        if (toDoEntered != "exit")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Thank you. Have a Nice day.");
                            break;
                        }
                    }

                }
                if (toDoEntered == "transfer")
                {
                    Console.WriteLine("This action is not available at this time.");
                    
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("Check balance, Deposit, Withdraw, Transfer, Exit");
                    toDoEntered = Console.ReadLine().ToLower();
                    if (toDoEntered != "exit")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Thank you. Have a Nice day.");
                        break;
                    }
                }
                if (toDoEntered == "exit")
                {
                    Console.WriteLine("Thank you. Have a Nice day.");
                    break;
                }
            }

        }

        
    }
}
