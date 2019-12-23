using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11._2
{
    public delegate bool StudentPredicateDelegate(Student student);
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student() { }
        public Student(string LastName, string FirstName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        public static bool AgeMore18(Student student)
        {
            return (student.Age >= 18 ? true : false);
        }
        public static bool IsFirstLetterA(Student student)
        {
            return (student.FirstName.IndexOf("A") == 0 ? true : false);
        }
        public static bool IsLastNameMoreThanThreeSymbols(Student student)
        {
            return (student.LastName.Length > 3 ? true : false);
        }
    }
}
