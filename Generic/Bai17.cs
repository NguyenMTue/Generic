using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai17
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 17: Phần tử xuất hiện nhiều nhất ===");

            List<int> list = new List<int>();

            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử {i}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            var result = list.GroupBy(x => x)
                             .OrderByDescending(g => g.Count())
                             .First();

            Console.WriteLine($"Phần tử xuất hiện nhiều nhất: {result.Key} ({result.Count()} lần)");
        }
    }
}