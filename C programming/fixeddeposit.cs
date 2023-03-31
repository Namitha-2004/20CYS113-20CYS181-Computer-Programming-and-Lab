using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of users ");
        int n, i, j, years;
        double value;
        
        n = (int) inputValue();
        double[] principle = new double[n];
        int[] year = new int[n];
        
        i = 0;
        j = 1;
        while (i <= n - 1)
        {
            Console.WriteLine("Please enter the principle amount of user " + j);
            value = inputValue();
            principle[i] = value;
            Console.WriteLine("Please enter the year");
            years = (int) inputValue();
            year[i] = years;
            i = i + 1;
            j = j + 1;
        }
        Console.WriteLine("Please enter the user which need access");
        int userchoice, choice;
        
        userchoice = (int) inputValue();
        double useramo;
        
        useramo = principle[userchoice - 1];
        choice = year[userchoice - 1];
        double fixedval;
        
        if (choice == 1)
        {
            fixedval = Year1(useramo);
        }
        else
        {
            if (choice == 2)
            {
                useramo = useramo + Year1(useramo);
                fixedval = Year2(useramo);
            }
            else
            {
                if (choice == 3)
                {
                    useramo = useramo + Year1(useramo) + Year2(useramo);
                    fixedval = Year3((int) useramo);
                }
                else
                {
                    if (choice == 4)
                    {
                        useramo = useramo + Year1(useramo) + Year2(useramo) + Year3((int) useramo);
                        fixedval = Year4(useramo);
                    }
                    else
                    {
                        if (choice >= 5)
                        {
                            useramo = useramo + Year1(useramo) + Year2(useramo) + Year3((int) useramo) + Year4(useramo);
                            fixedval = Year5(useramo);
                        }
                        else
                        {
                            Console.WriteLine("You have entered the number of year");
                        }
                    }
                }
            }
        }
        Console.WriteLine("The final fixed deposit amount is " + fixedval);
    }
    
    public static double Year1(double pri1)
    {
        double totval;
        
        totval = pri1 + pri1 * 0.03;
        
        return totval;
    }
    
    public static double Year2(double prival)
    {
        double totval;
        
        totval = prival + prival * 0.04;
        
        return totval;
    }
    
    public static double Year3(int pri3)
    {
        double totval;
        
        totval = pri3 + pri3 * 0.05;
        
        return totval;
    }
    
    public static double Year4(double pri4)
    {
        double totval;
        
        totval = pri4 + pri4 * 0.055;
        
        return totval;
    }
    
    public static double Year5(double pri5)
    {
        double totval;
        
        totval = pri5 + pri5 * 0.06;
        
        return totval;
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
