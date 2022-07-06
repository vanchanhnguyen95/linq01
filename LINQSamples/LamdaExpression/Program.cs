using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                    new Employee() { Id = 1, Name = "Alex"},
                    new Employee() { Id = 2, Name = "Bary"},
            };

            // dùng cách bình thường
            foreach(var employee in developers.Where(NameStartWithA))
            {
                Console.WriteLine(employee.Name);
            }

            // Cách 2
            foreach (var employee in developers.Where(delegate (Employee employee) {
                return employee.Name.StartsWith(value: "A");
            }))
            {
                Console.WriteLine(employee.Name);
            }


            // Cách 3
            foreach (var employee in developers.Where(employee => employee.Name.StartsWith("A"))) {
                Console.WriteLine(employee.Name);
            }
            

            Console.Read();
        }

        // Lấy ra những nhân viên có tên bắt đầu bằng chữ A

        // cách 1: cách bình thường
        private static bool NameStartWithA(Employee employee)
        {
            return employee.Name.StartsWith(value: "A");
        }
    }
}
