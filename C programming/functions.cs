using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, p, i, j;
        
        Console.WriteLine("Please enter the n value for which factorial need to be found");
        n = (int) inputValue();
        i = 0;
        j = 1;
        while (i <= n)
        {
            int answer;
            
            answer = Factorial(i);
            i = i + 1;
        }
        Console.WriteLine("Please enter the n value for which fibonnaci need to be found");
        p = (int) inputValue();
        while (j <= p)
        {
            answer = Fibo(p);
            j = j + 1;
        }
        double hnd, ccont, tstren;
        int a, count, grade;
        
        count = 1;
        Console.WriteLine("Please enter following values for which grade of the steel need to be found");
        Console.WriteLine("Please enter the number of steels the grade need to be assigned");
        a = (int) inputValue();
        while (count <= a)
        {
            Console.WriteLine("Enter the hardness of the steel");
            hnd = inputValue();
            Console.WriteLine("Enter the carbon content of the steel");
            ccont = inputValue();
            Console.WriteLine("Enter the tensile strength of the steel");
            tstren = inputValue();
            grade = Gradesteel(hnd, ccont, tstren);
            count = count + 1;
        }
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
    
    public static int Fibo(int n)
    {
        Console.WriteLine("We are using this function to find Fibonnaci series");
        int count, i, j, k, fvalue;
        
        count = 1;
        j = 0;
        k = 1;
        if (n > 0)
        {
            Console.WriteLine("The fibonnaci value is 0");
            Console.WriteLine("The fibonnaci value is 1");
            while (count <= n - 2)
            {
                fvalue = j + k;
                j = k;
                k = fvalue;
                count = count + 1;
                Console.WriteLine("The fibonnaci value is " + fvalue);
            }
        }
        else
        {
            if (n == 0)
            {
                fvalue = 0;
                Console.WriteLine("The fibonnaci value is 0");
            }
            else
            {
                fvalue = 0;
                Console.WriteLine("Fibonacci series cant be found for negative numbers");
            }
        }
        
        return fvalue;
    }
    
    public static int Gradesteel(double hdn, double ccont, double tstrength)
    {
        int grade;
        int i, j, k;
        
        i = 0;
        j = 0;
        k = 0;
        if (hdn > 50)
        {
            i = 1;
        }
        if (ccont < 0.7)
        {
            j = 1;
        }
        if (tstrength > 5600)
        {
            k = 1;
        }
        if (i == 1 && j == 1 && k == 1)
        {
            grade = 10;
        }
        else
        {
            if (i == 1 && j == 1)
            {
                grade = 9;
            }
            else
            {
                if (i == 1 && k == 1)
                {
                    grade = 7;
                }
                else
                {
                    if (j == 1 && k == 1)
                    {
                        grade = 8;
                    }
                    else
                    {
                        if (i == 1 || j == 1 || k == 1)
                        {
                            grade = 6;
                        }
                        else
                        {
                            grade = 5;
                        }
                    }
                }
            }
        }
        Console.WriteLine("The grade of the steel given is " + grade);
        
        return grade;
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
