using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string information = " ";

            List<Students> dataBase = new List<Students>();
            while ((information = Console.ReadLine()) != "end")
            {
                List<string> studentInformation = information
                    .Split()
                    .ToList();
                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                int age = int.Parse(studentInformation[2]);
                string homeTown = studentInformation[3];


                
                if (IsStudentExisting(dataBase, firstName, lastName))
                {
                    Students student = GetStudent(dataBase, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Students student = new Students(firstName, lastName, age, homeTown);
                    dataBase.Add(student);
                }

            }
            string cityName = Console.ReadLine();

            foreach (Students student in dataBase)
            {
                if (cityName == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        static bool IsStudentExisting(List<Students> students,  string firstName , string lastName)
        {
            foreach (Students student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Students GetStudent(List<Students> students, string firstName,string lastName)
        {
            Students existingStudent = null;
            foreach (Students student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }
    public class Students
    {
        public Students(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}