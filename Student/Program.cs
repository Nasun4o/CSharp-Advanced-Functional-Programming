using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ClassStudent
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Maya", "Nikolova", 19, "113214", "099334123", "mokaa@abv.bg", new List<int> { 2, 4, 5, 6, }, 2));
            students.Add(new Student("Nasko", "Cenov", 33, "234114", "0298334111", "mkok@yaho.bg", new List<int> { 2, 4, 4, 6, }, 2));
            students.Add(new Student("Stan", "Azisov", 22, "14232123", "0899934123", "regex@abv.bg", new List<int> { 2, 3, 5, 3, }, 2));
            students.Add(new Student("Daniel", "Petkanov", 25, "14923123", "0898333123", "c#sda@abv.bg", new List<int> { 2, 6, 6, 6, }, 1));
            students.Add(new Student("Asen", "Dobrudjanski", 29, "213993123", "0234334123", "mkod@abv.bg", new List<int> { 2, 3, 5, 3, }, 2));
            students.Add(new Student("Nono", "SkyWallker", 25, "12323123", "12348334123", "xaxaa@gmail.bg", new List<int> { 2, 4, 2, 3, }, 1));
            students.Add(new Student("Borislav", "Svetoslavoc", 26, "132213123", "08123334123", "asdsa@abv.bg", new List<int> { 2, 2, 5, 3, }, 2));
            students.Add(new Student("Maks", "Armenov", 21, "11323123", "0898334123", "arebea@abv.bg", new List<int> { 6, 4, 5, 6, }, 1));
            //Problem 2
            Console.WriteLine("/////////////////////////////////PROBLEM 2/////////////////////////");

            var group2 = from student in students
                         where student.GroupNumber == 2
                         orderby student.FirstName ascending
                         select student;

            foreach (var student in group2)
            {
                Console.WriteLine($"Name: {student.FirstName} - Group: {student.GroupNumber}");
            }
            Console.WriteLine("/////////////////////////////////PROBLEM 3/////////////////////////");

            //Problem 3
            var firstNameBefore = from student in students
                                  where student.FirstName.CompareTo(student.LastName) < 0
                                  select student;
            foreach (var student in firstNameBefore)
            {
                Console.WriteLine($"Name: {student.FirstName}  {student.LastName}");

            }
            Console.WriteLine("/////////////////////////////////PROBLEM 4/////////////////////////");


            //Problem 4

            var orderByAge = from student in students
                             where student.Age >= 18 & student.Age <= 24
                             select student;

            foreach (var student in orderByAge)
            {
                Console.WriteLine($"Name: {student.FirstName}  {student.LastName} - Age: {student.Age}");

            }
            Console.WriteLine("/////////////////////////////////PROBLEM 5/////////////////////////");


            //Problem 5

            List<Student> sortStudents = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
            foreach (var stude in sortStudents)
            {
                Console.WriteLine($" {stude.FirstName}  {stude.LastName}" );
            }
            Console.WriteLine("/////////////////////////////////PROBLEM 6/////////////////////////");

            //Problem 6

            var filterByEmails = from student in students
                                 where Regex.IsMatch(student.Email, @"[\w]+@abv.bg", RegexOptions.IgnoreCase)
                                 select student;
            foreach (var a in filterByEmails)
            {
                Console.WriteLine($"{a.FirstName} {a.LastName} {a.Email}");
            }
            Console.WriteLine("/////////////////////////////////PROBLEM 7/////////////////////////");


            //Problem 7

            var filterByPhone = from student in students
                                where Regex.IsMatch(student.Phone, @"\b02", RegexOptions.IgnoreCase)
                                select student;
            foreach (var a in filterByPhone)
            {
                Console.WriteLine($"{a.FirstName} {a.LastName} {a.Phone}");
            }
            Console.WriteLine("/////////////////////////////////PROBLEM 8/////////////////////////");


            //Problem 8

            var anonymousBULLSHHIT = students.
                Where(student => student.Marks.Contains(6))
                .Select(student => new { student.FirstName, student.LastName, student.Marks });

            foreach (var a in anonymousBULLSHHIT)
            {
                Console.WriteLine("Name: {0} {1} Marks - {2}", a.FirstName, a.LastName ,string.Join(", ", a.Marks));

            }

            Console.WriteLine("/////////////////////////////////PROBLEM 9/////////////////////////");


            //Problem 9

            var weekStudent = students.Where(student => student.Marks.Count(mark => mark == 2)==2).Select(student => new { student.FirstName, student.LastName, student.Marks });

            foreach (var a in weekStudent)
            {
                Console.WriteLine("Name: {0} {1} Marks - {2}", a.FirstName, a.LastName, string.Join(", ", a.Marks));

            }

            //Problem 10
            Console.WriteLine("/////////////////////////////////PROBLEM 10/////////////////////////");

            var sortByYear = from student in students
                             where Regex.IsMatch(student.FacultyNumber, @"14\b")
                             select student;

            foreach (var a in sortByYear)
            {
                Console.WriteLine("{0} Marks: {1}", a.FirstName, string.Join(", ", a.Marks));
            }
        }

    }
}
