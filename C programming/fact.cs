using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n;
        
        Console.WriteLine("Please enter the n value for which factorial need to be found");
        n = (int) inputValue();
        int answer;
        
        answer = Factorial(n);
    }
    
    public static int Factorial(int n)
    {
        int count, i, fact;
        
        count = 1;
        i = 1;
        fact = 1;
        Console.WriteLine("We are using this function to find factorial");
        if (n > 0)
        {
            while (count <= n)
            {
                fact = fact * i;
                i = i + 1;
                count = count + 1;
            }
            Console.WriteLine("The factorial of the given value is " + fact);
        }
        else
        {
            if (n == 0)
            {
                Console.WriteLine("The factorial of 0 is " + fact);
            }
            else
            {
                Console.WriteLine("Factorial value cant be found for negative numbers");
            }
        }
        
        return fact;
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
