using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of users ");
        int n, i, j;
        double value;
        
        n = (int) inputValue();
        double[] balance = new double[n];
        
        i = 0;
        j = 1;
        while (i <= n - 1)
        {
            Console.WriteLine("Please enter the balance amount of user " + j);
            value = inputValue();
            balance[i] = value;
            i = i + 1;
            j = j + 1;
        }
        Console.WriteLine("Please enter the user which need access");
        int userchoice, choice;
        
        userchoice = (int) inputValue();
        double useramo;
        
        useramo = balance[userchoice - 1];
        Console.WriteLine("Please enter choice as 1 for withdraw of money ");
        Console.WriteLine("Please enter choice as 2 for deposition of money ");
        Console.WriteLine("Please enter choice as 3 for recommending");
        choice = (int) inputValue();
        if (choice == 1)
        {
            double withdrawres;
            
            withdrawres = withdraw(useramo);
            balance[userchoice - 1] = withdrawres;
        }
        else
        {
            if (choice == 2)
            {
                double depositres;
                
                depositres = deposit(useramo);
                balance[userchoice - 1] = depositres;
            }
            else
            {
                if (choice == 3)
                {
                    double recres;
                    
                    recres = Recommend(useramo);
                    balance[userchoice - 1] = recres;
                }
                else
                {
                    Console.WriteLine("You have entered the wrong output");
                }
            }
        }
    }
    
    public static double deposit(double balance)
    {
        double deposit;
        
        Console.WriteLine("Please enter the amount to be deposited");
        deposit = inputValue();
        Console.WriteLine("You have successfully deposited " + deposit + " Rs to your account");
        deposit = balance + deposit;
        Console.WriteLine("The remaninning balance in your account is " + deposit);
        
        return deposit;
    }
    
    public static double Recommend(double balance)
    {
        double @return;
        
        Console.WriteLine("Please enter the number to which you have recommended the bank");
        @return = inputValue();
        Console.WriteLine("You have successfully Recommended " + @return + " to our bank. As agift you will have certain priviledges");
        @return = balance + @return * 50;
        Console.WriteLine("The remaninning balance in your account is " + @return);
        
        return @return;
    }
    
    public static double withdraw(double balance)
    {
        double withdraw;
        
        Console.WriteLine("Please enter the amount to be withdrawed");
        withdraw = inputValue();
        if (withdraw < balance)
        {
            if (balance > 500)
            {
                Console.WriteLine("You have successfully withdrawed " + withdraw + " Rs from your account");
                withdraw = balance - withdraw;
            }
            else
            {
                if (balance == 500)
                {
                    Console.WriteLine("Please add more amount to your account");
                    Console.WriteLine("You have successfully withdrawed " + withdraw + " Rs from your account");
                    withdraw = balance - withdraw;
                }
                else
                {
                    Console.WriteLine("You cant withdraw from your account due to unsufficient balance");
                    withdraw = balance;
                }
            }
            Console.WriteLine("The remaninning balance in your account is " + withdraw);
        }
        else
        {
            Console.WriteLine("You have given a greater amount than in your account , So you cant withdraw the money ");
            Console.WriteLine("The remaninning balance in your account is " + balance);
        }
        
        return withdraw;
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
