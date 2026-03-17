using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai14
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 14: Xóa sinh viên theo ID ===");

            List<Student> list = new List<Student>()
            {
                new Student{Id = 1, Name = "An"},
                new Student{Id = 2, Name = "Bình"},
                new Student{Id = 3, Name = "Cường"}
            };

            Console.Write("Nhập ID cần xóa: ");
            int id = int.Parse(Console.ReadLine());

            list.RemoveAll(x => x.Id == id);

            Console.WriteLine("Danh sách còn lại:");
            foreach (var sv in list)
                Console.WriteLine($"{sv.Id} - {sv.Name}");
        }
    }
}