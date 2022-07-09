using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Bo",  Age = 23 } ,
                new Student() { StudentID = 5, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 19 }
            };

            // Lấy ra tất cả nhân viên mà sắp xếp theo tên Alphabet tăng dần, mặc định là tăng dần
            // Query
            Console.WriteLine("ascending ==============================================================================");
            var orderedByResult = from s in studentList
                                  orderby s.StudentName
                                  select s;

            foreach(var s in orderedByResult)
            {
                Console.WriteLine(s.StudentName);
            }
            Console.WriteLine("descending method 01=====================================================================");
            // Lấy ra tất cả nhân viên mà sắp xếp theo tên Alphabet giảm dần
            var orderedByResultDesc = from s in studentList
                                  orderby s.StudentName descending
                                  select s;

            foreach (var s in orderedByResultDesc)
            {
                Console.WriteLine(s.StudentName);
            }

            Console.WriteLine("descending method 02=====================================================================");
            var orderedByResultDesc02 = studentList.OrderByDescending(X => X.StudentName);
            foreach (var s in orderedByResultDesc02)
            {
                Console.WriteLine(s.StudentName);
            }
            Console.WriteLine("order by, then by=====================================================================");
            var orderedByThenBy = studentList.OrderByDescending(X => X.StudentName).ThenBy(x => x.Age);
            foreach (var s in orderedByThenBy)
            {
                Console.WriteLine(s.StudentName);
            }
            Console.WriteLine("order by, then by 02=====================================================================");
            var orderedByThenBy02 = from s in studentList
                                    orderby s.StudentName descending, s.Age descending
                                    select s;
            foreach (var s in orderedByThenBy02)
            {
                Console.WriteLine(s.StudentName + "-" + s.Age.ToString());
            }
            Console.Read();
        }
    }
}
