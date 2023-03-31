using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int rollno;
        string name;
        string address;
        string bloodgrp;
        int pnum;
        string department;
        
        Console.WriteLine("Please enter your roll number (The last two digits only)");
        rollno = (int) inputValue();
        Console.WriteLine("Please enter your Name ");
        name = Console.ReadLine()
        Console.WriteLine("Please enter your Address in sigle line ");
        address = Console.ReadLine()
        Console.WriteLine("Please enter your Blood group");
        bloodgrp = Console.ReadLine()
        Console.WriteLine("Please enter your Phone Number (if any code begin with 00---)");
        pnum = (int) inputValue();
        Console.WriteLine("Please enter your Department to which you have assigned");
        department = Console.ReadLine()
        Console.WriteLine("Student Info");
        Console.WriteLine("The Roll number of students is ");
        Console.WriteLine(rollno);
        Console.WriteLine("The Name of students is ");
        Console.WriteLine(name);
        Console.WriteLine("The Address of students is ");
        Console.WriteLine(address);
        Console.WriteLine("The Blood group of students is ");
        Console.WriteLine(bloodgrp);
        Console.WriteLine("The Phone number of students is ");
        Console.WriteLine(pnum);
        Console.WriteLine("The Department of students is ");
        Console.WriteLine(department);
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
