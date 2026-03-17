using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai4
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 4: Đếm số chẵn ===");

            List<int> list = new List<int>();

            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử {i}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            int count = list.Count(x => x % 2 == 0);

            Console.WriteLine("Số lượng số chẵn = " + count);
        }
    }
}