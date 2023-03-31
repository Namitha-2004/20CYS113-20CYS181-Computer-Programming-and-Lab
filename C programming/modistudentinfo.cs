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
        Console.WriteLine("The Roll number of the student is " + rollno + " The Name of the student is " + name + " The Adress of the student is " + address + " The Blood group of the student is " + bloodgrp + " The Phone Number of the student is " + pnum + " The Department of the student is " + department);
        int sem;
        
        Console.WriteLine("Enter the Semester");
        sem = (int) inputValue();
        string subjectcode;
        
        Console.WriteLine("Enter the subject code");
        subjectcode = Console.ReadLine()
        double p1;
        
        Console.WriteLine("Enter the periodical 1 marks");
        p1 = inputValue();
        double p2;
        
        Console.WriteLine("Enter the periodical 2 marks");
        p2 = inputValue();
        double final;
        
        Console.WriteLine("Enter the Final Exam marks");
        final = inputValue();
        double total;
        
        total = p1 + p2 + final;
        double avg;
        
        avg = total / 3;
        Console.WriteLine("The roll number of student is " + rollno + " The subject code here is " + subjectcode + " The total marks of student is " + total + " The average of the student is " + avg);
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
