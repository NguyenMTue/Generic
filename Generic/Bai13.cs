using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai13
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 13: Đếm sinh viên ===");

            List<Student> list = new List<Student>()
            {
                new Student{Id = 1, Name = "An"},
                new Student{Id = 2, Name = "Bình"},
                new Student{Id = 3, Name = "Cường"}
            };

            Console.WriteLine("Số sinh viên: " + list.Count);
        }
    }
}