using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai12
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 12: Tìm sinh viên theo tên ===");

            List<Student> list = new List<Student>()
            {
                new Student{Id = 1, Name = "An"},
                new Student{Id = 2, Name = "Bình"},
                new Student{Id = 3, Name = "Ngoc"}
            };

            Console.Write("Nhập tên cần tìm: ");
            string name = Console.ReadLine();

            var result = list.Where(x => x.Name == name);

            Console.WriteLine("Kết quả:");
            foreach (var sv in result)
                Console.WriteLine($"{sv.Id} - {sv.Name}");
        }
    }
}