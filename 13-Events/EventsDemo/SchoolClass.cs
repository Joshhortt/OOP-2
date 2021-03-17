using System;
using System.Collections.Generic;

namespace EventsDemo
{
    public class SchoolClass
    {
        public event EventHandler<string> EnrollmentFull;

        private readonly List<string> enrolledStudents = new List<string>();
        private readonly List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; private set; }

        public SchoolClass(string title, int maximumStudents)
        {
            CourseTitle = title;
            MaximumStudents = maximumStudents;
        }

        public string SignUpStudent(string studentName)
        {
            string output = "";

            if (enrolledStudents.Count < MaximumStudents)
            {
                enrolledStudents.Add(studentName);
                output = $"{ studentName } was enrolled in { CourseTitle }";

                // Check to see if reached maximum
                if (enrolledStudents.Count == MaximumStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{ CourseTitle } enrollment is now full.");
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{ studentName } was added to the wait list in { CourseTitle }";
            }

            return output;
        }
    }
}
