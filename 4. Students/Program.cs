using System.Security.Cryptography;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string information = " ";

            List<Students> dataBase = new List<Students>();
            while ((information = Console.ReadLine())!= "end")
            {
                List<string> studentInformation = information
                    .Split()
                    .ToList();
                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                int age = int.Parse(studentInformation[2]);
                string homeTown = studentInformation[3];

                Students student = new Students(firstName, lastName, age, homeTown);
                dataBase.Add(student);

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
    }
    public class Students
    {
        public Students (string firstName, string lastName, int age, string homeTown)
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