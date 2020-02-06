using System;
using System.Collections.Generic;
namespace Lab_11._2
{
    class Program
    {
        static void Main()
    {
        List<Student> myStudents = new List<Student>();
        // 7
        myStudents.Add(new Student("Буряк", "Роман", 33));
        myStudents.Add(new Student("Вероівська", "Анастасія", 18));
        myStudents.Add(new Student("Гаврилюк", "Валерій", 15));
        myStudents.Add(new Student("Гень", "Олександр", 50));
        myStudents.Add(new Student("Дзененко", "Владислав", 56));
        myStudents.Add(new Student("Євтаєв", "Ярослав", 70));
        myStudents.Add(new Student("Зозуля", "Роман", 23));
        myStudents.Add(new Student("Івлєв", "Ростислав", 30));
        myStudents.Add(new Student("Карнацький", "Станіслав", 47));
        myStudents.Add(new Student("Коваль", "Дмитро", 40));
        myStudents.Add(new Student("Troelsen", "Дмитро", 40));
        myStudents.Add(new Student("Коваль", "Andrew", 40));

        // 8
        List<Student> myStudents2 = new List<Student>();
        myStudents2 = Extension.FindStudent(myStudents, Student.AgeMore18);
        Console.WriteLine(myStudents2.Count);
        myStudents2 = Extension.FindStudent(myStudents, Student.IsFirstLetterA);
        Console.WriteLine(myStudents2.Count);
        myStudents2 = Extension.FindStudent(myStudents, Student.IsLastNameMoreThanThreeSymbols);
        Console.WriteLine(myStudents2.Count);
        Console.WriteLine();

        // 9
        StudentPredicateDelegate del1 = Student.AgeMore18;
        StudentPredicateDelegate del2 = Student.IsFirstLetterA;
        StudentPredicateDelegate del3 = Student.IsLastNameMoreThanThreeSymbols;
        StudentPredicateDelegate del = del1 + del2 + del3;
        myStudents2 = Extension.FindStudent(myStudents, del);
        Console.WriteLine(myStudents2.Count);
        Console.WriteLine();

        // лямбда методы
        // 10
        StudentPredicateDelegate del4 = delegate (Student student) { return (student.Age >= 20 && student.Age <= 25 ? true : false); };
        myStudents2 = Extension.FindStudent(myStudents, del4);
        Console.WriteLine(myStudents2.Count);
        Console.WriteLine();

        // 11
        StudentPredicateDelegate del5 = delegate (Student student) { return (student.FirstName == "Andrew" ? true : false); };
        myStudents2 = Extension.FindStudent(myStudents, del5);
        Console.WriteLine(myStudents2.Count);
        Console.WriteLine();

        // 12
        StudentPredicateDelegate del6 = delegate (Student student) { return (student.LastName == "Troelsen" ? true : false); };
        myStudents2 = Extension.FindStudent(myStudents, del6);
        Console.WriteLine(myStudents2.Count);
        Console.WriteLine();

        // лямбда выражения
        // 10
        StudentPredicateDelegate del7 = (Student student) => (student.Age >= 20 && student.Age <= 25 ? true : false);
        myStudents2 = Extension.FindStudent(myStudents, del7);
        Console.WriteLine(myStudents2.Count);
        Console.WriteLine();

        // 11
        StudentPredicateDelegate del8 = (Student student) => (student.FirstName == "Andrew" ? true : false);
        myStudents2 = Extension.FindStudent(myStudents, del8);
        Console.WriteLine(myStudents2.Count);
        Console.WriteLine();

        // 12
        StudentPredicateDelegate del9 = (Student student) => (student.LastName == "Troelsen" ? true : false);
        myStudents2 = Extension.FindStudent(myStudents, del9);
        Console.WriteLine(myStudents2.Count);
        Console.WriteLine();

        Console.ReadKey();
    }
}
}
