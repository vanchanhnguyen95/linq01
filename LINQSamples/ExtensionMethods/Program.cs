using Extensions.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "43.35";
            double data = text.ToDouble();
            Console.WriteLine(data);
            //Console.ReadLine();

            IEnumerable<Employee> developers = new Employee[]
            {
                    new Employee() { Id = 1, Name = "A"},
                    new Employee() { Id = 2, Name = "B"},
            };

            //var enumerator = developers.GetEnumerator();
            //int count = 0;
            //while (enumerator.MoveNext())
            //{
            //    count++;
            //}
            var count = developers.Count();
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
