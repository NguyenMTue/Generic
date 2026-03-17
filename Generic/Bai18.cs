using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai18
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 18: Sinh viên điểm cao nhất ===");

            List<Student> list = new List<Student>()
            {
                new Student{Id=1, Name="An", Score=8.5},
                new Student{Id=2, Name="Bình", Score=9.2},
                new Student{Id=3, Name="Cường", Score=9.2}
            };

            double maxScore = list.Max(x => x.Score);

            var result = list.Where(x => x.Score == maxScore);

            Console.WriteLine("Sinh viên điểm cao nhất:");
            foreach (var sv in result)
                Console.WriteLine($"{sv.Id} - {sv.Name} - {sv.Score}");
        }
    }
}