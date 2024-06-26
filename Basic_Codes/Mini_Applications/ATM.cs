using System;


namespace file
{
    public class ATM
    {
        public static void Main(string[] args)
        {
            int balance = 1000;
            Console.WriteLine(" WELCOME TO ATM SERVICES ");
            int no = 1111;
            Console.WriteLine("Enter the pin no. : ");
            int pin=Convert.ToInt32(Console.ReadLine());
            do{
            if(pin==no)
            {
             Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1.To Check Balance");
                Console.WriteLine("2.To Withdraw Money");
                Console.WriteLine("3.To Deposit Money");
                Console.WriteLine("4.To Exit");
                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Your balance is: "+balance);
                        break;
                    }
                    case 2:
                    {
                        Console.Write("Enter amount to withdraw: ");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Insufficient amount");
                        }
                        else
                        {
                            balance =balance - withdrawAmount;
                            Console.WriteLine("You have withdrawn "+withdrawAmount+". Your new balance is : " +balance);
                        }
                        break;
                    }

                    case 3:
                    {
                        Console.Write("Enter amount to deposit: ");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());;
                        balance += depositAmount;
                        Console.WriteLine("You have deposited "+depositAmount+". Your new balance is "+balance);
                        break;
                    }
                    case 4:
                        Console.WriteLine("Thank you for using our ATM. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                } 
            }
            else{
                Console.WriteLine("You have entered the incorrect pin....");
                Console.WriteLine("Please do enter the correct pin : ");
                pin=Convert.
                ToInt32(Console.ReadLine());

            }
            }while(true);
        }
    }
}