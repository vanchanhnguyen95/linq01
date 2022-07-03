using System;
using System.Linq;

namespace Example1
{
    // class Student
    class Student
    {
        public int StudentId {get;set;}
        public string StudentName { get; set; } = "No Name";
        public int? StudentAge { get; set; } = 10;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo 1 danh dách học sinh
            Student[] studentArray =
            {
                new Student() {StudentId = 1, StudentName = "John", StudentAge = 18},
                new Student() { StudentId = 2, StudentName = "Steve",  StudentAge = 21 },
                new Student() { StudentId = 3, StudentName = "Bill",  StudentAge = 25 },
                new Student() { StudentId = 4, StudentName = "Ram" , StudentAge = 20 },
                new Student() { StudentId = 5, StudentName = "Ron" , StudentAge = 31 },
                new Student() { StudentId = 6, StudentName = "Chris",  StudentAge = 17 },
                new Student() { StudentId = 7, StudentName = "Rob",StudentAge = 19  },
            };

            // Tính số lượng học sinh có tuổi: 12 < tuổi < 20  không sử dụng linq
            // Khởi tạo 1 mảng học sinh để chứa danh sách theo đk: học sinh có tuổi: 12 < tuổi < 20  không sử dụng linq
            Student[] studentArrayNew = new Student[7];
            int i = 0;
            foreach(var stu in studentArray)
            {
                if(stu.StudentAge > 12 && stu.StudentAge < 20)
                {
                    studentArrayNew[i] = stu;
                    i++;
                }
            }
            Console.WriteLine(@"Cach 1: Tong cong co " + i.ToString() + "/" + studentArrayNew.Length.ToString() + " hoc sinh thoa man dieu kien. " );
            //Console.ReadLine();
            // Tính số lượng học sinh có tuổi: 12 < tuổi < 20  có sử dụng linq
            Student[] studentArrayNew2 = studentArray.Where(x => x.StudentAge > 12 && x.StudentAge < 20).ToArray();

            Console.WriteLine(@"Cach 2: Tong cong co " + studentArrayNew2.Length.ToString() + "/" + studentArray.Length.ToString() + " hoc sinh thoa man dieu kien. ");
            Console.ReadLine();

        }
    }
}
