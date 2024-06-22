
using System;
class Student
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string City;

    public Student(string firstName, string lastName, int age, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        City = city;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> students = new Dictionary<string, Student>();

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] studentInfo = input.Split(' ');

            if (students.ContainsKey(studentInfo[0] + " " + studentInfo[1]))
            {
                students[studentInfo[0] + " " + studentInfo[1]] = new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]);
            }
            else
            {
                students.Add(studentInfo[0] + " " + studentInfo[1], new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]));
            }

            input = Console.ReadLine();
        }

        string city = Console.ReadLine();

        foreach (var student in students)
        {
            if (student.Value.City == city)
            {
                Console.WriteLine("{0} {1} is {2} years old.", student.Value.FirstName, student.Value.LastName, student.Value.Age);
            }
        }

        Console.ReadLine();
    }
}




