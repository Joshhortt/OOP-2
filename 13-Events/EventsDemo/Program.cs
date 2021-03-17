// Object Oriented Programming - part 2 - Events
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolClass history = new SchoolClass("History 101", 4);
            SchoolClass english = new SchoolClass("Public Speaking 302", 3);

			Console.WriteLine("\nSchool Enrollment Report:");
			Console.WriteLine("--------------------------------------\n");

            history.EnrollmentFull += SchoolClass_EnrollmentFull;

            history.SignUpStudent("Josh Hortt").PrintToConsole();
            history.SignUpStudent("Ana Calvario").PrintToConsole();
            history.SignUpStudent("Alex Rebelo").PrintToConsole();
            history.SignUpStudent("Sofia Nasala").PrintToConsole();
            history.SignUpStudent("Bruno Vieira").PrintToConsole();
            history.SignUpStudent("Pedro Guerreiro").PrintToConsole();
            history.SignUpStudent("Mara Horta").PrintToConsole();

            Console.WriteLine();

            english.EnrollmentFull += SchoolClass_EnrollmentFull;

            english.SignUpStudent("Alex Rebelo").PrintToConsole();
            english.SignUpStudent("Sofia Nasala").PrintToConsole();
            english.SignUpStudent("Bruno Vieira").PrintToConsole();
            english.SignUpStudent("Mara Horta").PrintToConsole();

            Console.ReadLine();
        }

        private static void SchoolClass_EnrollmentFull(object sender, string e)
        {
            SchoolClass model = (SchoolClass)sender;

            Console.WriteLine();
            Console.WriteLine($"{ model.CourseTitle }: Full");
            Console.WriteLine();
        }
    }
}
