using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11._2
{
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> students, StudentPredicateDelegate studentPredicateDelegate)
        {
            //StudentPredicateDelegate del1 = Student.AgeMore18;
            //StudentPredicateDelegate del2 = Student.IsFirstLetterA;
            //StudentPredicateDelegate del3 = Student.IsLastNameMoreThanThreeSymbols;
            List<Student> sortList = new List<Student>();
            for (int i = 0; i < students.Count; i++)
            {
                if (studentPredicateDelegate(students[i]))
                {
                    sortList.Add(students[i]);
                }
            }
            return sortList;
        }
    }
}
