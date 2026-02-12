using System;
using System.Collections.Generic;

// 1. Student Class with Properties
public class Student {
    public string Name { get; set; } // Property, not a public field
    public Student(string name) => Name = name;
}

// 2. Group Class to manage objects
public class Group {
    private List<Student> students = new List<Student>();

    public void AddStudent(Student s) => students.Add(s);

    public void PrintAll() {
        Console.WriteLine("\n--- Student List ---");
        foreach (var s in students) Console.WriteLine($"- {s.Name}");
    }
}

// 3. Main logic kept short
class Program {
    static Group myGroup = new Group();

    static void Main() {
        string choice;
        do {
            Console.Write("\n1 Add, 2 Show, 0 Exit: ");
            choice = Console.ReadLine();
            if (choice == "1") AddStudentFlow();
            else if (choice == "2") myGroup.PrintAll();
        } while (choice != "0");
    }

    static void AddStudentFlow() {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        myGroup.AddStudent(new Student(name));
    }
}

