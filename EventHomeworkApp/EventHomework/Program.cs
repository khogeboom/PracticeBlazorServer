using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// HOMEWORK: Create an event in a class and then consume that class. Attach a listener to the event and have it write to the console.

namespace EventHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassModel math = new ClassModel("Multivariable Calculus", 3);
            ClassModel science = new ClassModel("Physics 101", 2);

            math.ClassFull += ClassModel_ClassFull;

            math.RegisterStudent("Tim Corey");
            math.RegisterStudent("Kasey Hogeboom");
            math.RegisterStudent("Brian Fontana");
            math.RegisterStudent("Ken Small");

            science.ClassFull += ClassModel_ClassFull;

            science.RegisterStudent("Tim Corey");
            science.RegisterStudent("Kasey Hogeboom");
            science.RegisterStudent("Brian Fontana");

            Console.ReadLine();
        }

        private static void ClassModel_ClassFull(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine(e);
            Console.WriteLine();
        }
    }

    public class ClassModel
    {
        public event EventHandler<string> ClassFull;

        private List<string> enrolledStudents = new List<string>();
        private List<string> waitlist = new List<string>();

        public string CourseTitle { get; set; }
        public int MaxStudents { get; set; }

        public ClassModel(string title, int maxStudents)
        {
            CourseTitle = title;
            MaxStudents = maxStudents;
        }

        public void RegisterStudent(string studentName)
        {
            if (enrolledStudents.Count < MaxStudents)
            {
                enrolledStudents.Add(studentName);
                Console.WriteLine($"{studentName} has been enrolled in {CourseTitle}");
                if (enrolledStudents.Count == MaxStudents)
                    ClassFull?.Invoke(this, $"{CourseTitle}: FULL");
            }
            else
            {
                waitlist.Add(studentName);
                Console.WriteLine($"{studentName} has been added to the waitlist for {CourseTitle}");
            }
        }
    }
}
