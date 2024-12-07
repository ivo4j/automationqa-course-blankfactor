using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    static string[] _schoolSubjects = { "Math", "Biology", "History", "English", "Sport", "Physics" };
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Student Data Management System!");
        Dictionary<string, Dictionary<string, List<double>>> students = new Dictionary<string, Dictionary<string, List<double>>>();

        string studentName = null;


        int selection = 0;
        do
        {
            Console.WriteLine("Choose an option:\r\n1. Add a new student\r\n2. Remove a student\r\n3. Assign student to subject\r\n4. Update a student's grades\r\n5. Display all students\r\n6. Exit\r\n\r\nEnter your choice: \r\n");

            bool res = int.TryParse(Console.ReadLine(), out selection);


            switch (selection)
            {
                case 1:
                    AddStudent(students);
                    break;
                case 2:
                    RemoveStudent(students);
                    break;
                case 3:
                    AssignToSubject(students);
                    break;
                case 4:
                    UpdateStudentsGrades(students);
                    break;
                case 5:
                    DisplayAllStudents(students);
                    break;
                case 6:
                    return;
                default:
                    break;

            }
        }
        while (selection < 1 || selection > 6);

    }

    public static void AddStudent(Dictionary<string, Dictionary<string, List<double>>> students)
    {
        Console.WriteLine("Enter student name: ");
        string studentName = Console.ReadLine();

        string message = students.TryAdd(studentName, new Dictionary<string, List<double>>())
            ? $"Student {studentName} added successfully!"
           : $"Student {studentName} already exists!";

        Console.WriteLine(message);
    }

    public static void RemoveStudent(Dictionary<string, Dictionary<string, List<double>>> students)
    {

        Console.WriteLine("Enter student name to remove: ");
        string studentName = Console.ReadLine();

        string message = students.Remove(studentName)
            ? $"Student {studentName} is successfully removed!"
            : $"Student {studentName} is not removed!";

        Console.WriteLine(message);

    }

    public static void AssignToSubject(Dictionary<string, Dictionary<string, List<double>>> students)
    {

        //students[studentName].Add("Subject", new List()) = new Dictionary<string, List<double>>();

        Console.WriteLine("Enter a student and a subject, for example John Doe-Math:");
        string subjectNameinput = Console.ReadLine();

        string[] items = subjectNameinput.Split("-");
        string studentName = items[0];
        string subject = items[1];

        if (!students.ContainsKey(studentName))
        {
            Console.WriteLine($"The student is not present in the system.");
            return;
        }

        if (!_schoolSubjects.Contains(subject))
        {
            Console.WriteLine("The subject is not present in the list.");
            return;
        }

        string message = students[studentName].TryAdd(subject, new List<double>())
        ? $"Student {studentName} has successfully enrolled in the {subject} class!"
            : $"Student is already enrolled!";
        Console.WriteLine(message);

    }

    public static void UpdateStudentsGrades(Dictionary<string, Dictionary<string, List<double>>> students)
    {

        Console.WriteLine($"Enter a student name:");
        string studentName = Console.ReadLine();

        if (!students.ContainsKey(studentName))
        {
            Console.WriteLine($"The student is not present in the system.");
            return;
        }

        Console.WriteLine($"Enter a subject-grade:");
        string subjectAndGrade = Console.ReadLine();

        string[] items = subjectAndGrade.Split("-");
        string subject = items[0];
        if (!double.TryParse(items[1], out double grade))
        {
            Console.WriteLine($"Invalid grade input.");
            return;
        }

        if (grade < 2 || grade > 6)
        {
            Console.WriteLine("Wrong range of the grade.");
            return;
        }

        if (!_schoolSubjects.Contains(subject))
        {
            Console.WriteLine("The subject is not present in the list.");
            return;
        }


        students[studentName][subject].Add(grade);
        Console.WriteLine("The grade is added.");

    }
    public static void DisplayAllStudents(Dictionary<string, Dictionary<string, List<double>>> students)
    {
        Console.WriteLine("Displaying all students:");
        // Iterate through the outer dictionary
        foreach (var studentEntry in students)
        {
            string studentName = studentEntry.Key;
            Console.WriteLine($"Student: {studentName}");

            // Iterate through the inner dictionary
            foreach (var subjectEntry in studentEntry.Value)
            {
                string subjectName = subjectEntry.Key;
                List<double> grades = subjectEntry.Value;

                // Display the subject and grades
                Console.WriteLine($"  Subject: {subjectName}");
                Console.WriteLine($"  Grades: {string.Join(", ", grades)}");
                Console.WriteLine($" Average grades: ", grades.Average());
            }
        }
    }
}


