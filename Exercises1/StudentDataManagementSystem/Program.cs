using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, List<double>>> students = new Dictionary<string, Dictionary<string, List<double>>>();

        Console.WriteLine("Welcome to the Student Data Management System!");

        int selection = 0;
        do
        {
            Console.WriteLine("Choose an option:\r\n1. Add a new student\r\n2. Remove a student\r\n3. Assign student to subject\r\n4. Update a student's grades\r\n5. Display all students\r\n6. Exit\r\n\r\nEnter your choice: \r\n");

            bool res = int.TryParse(Console.ReadLine(), out selection);
        }
        while (selection < 1 || selection > 6);

        switch (selection)
        {
            case 1:
                AddStudent(students);
                break;
            case 2:
                break;
            case 3:
                AssignToSubject(students);
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;

        }

    }

    public static void AddStudent(Dictionary<string, Dictionary<string, List<double>>> students)
    {
        Console.WriteLine("Enter student name: ");
        string studentName = Console.ReadLine();
        if (!students.ContainsKey(studentName))
            students.Add(studentName, new Dictionary<string, List<double>>());
            //students[studentName].Add("Subject", new List()) = new Dictionary<string, List<double>>();

        Console.WriteLine($"Student {studentName} added successfully!");
    }

    public static void RemoveStudent(Dictionary<string, Dictionary<string, List<double>>> students)
    {
        bool isRemoved = false;
        Console.WriteLine("Enter student name to remove: ");
        string studentName = Console.ReadLine();
        if (!students.ContainsKey(studentName))
           isRemoved = students.Remove(studentName);

        //students[studentName].Add("Subject", new List()) = new Dictionary<string, List<double>>();

        if (isRemoved)
        {
            Console.WriteLine($"Student is successfully removed!");
        }
        else {
            Console.WriteLine($"Student is not removed!");
        }
        
    }

    public static void AssignToSubject(Dictionary<string, Dictionary<string, List<double>>> students) 
    {
        students[studentName].Add("Subject", new List()) = new Dictionary<string, List<double>>();

    }

}


