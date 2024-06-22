
using System;
namespace StudentInfo
{
    class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public string homeTown;

        public Student(string fName, string lName, int studentAge, string town)
        {
            firstName = fName;
            lastName = lName;
            age = studentAge;
            homeTown = town;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] info = input.Split();

            Student[] students = new Student[10];
            int index = 0;

            while (input != "end")
            {
                string fName = info[0];
                string lName = info[1];
                int studentAge = int.Parse(info[2]);
                string town = info[3];

                Student student = new Student(fName, lName, studentAge, town);
                students[index] = student;
                index++;

                input = Console.ReadLine();
                info = input.Split();
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student != null && student.homeTown == city)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }
}

