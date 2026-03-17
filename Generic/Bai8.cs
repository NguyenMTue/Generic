using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai8
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 8: Đảo ngược danh sách ===");

            List<int> list = new List<int>();

            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử {i}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            list.Reverse();

            Console.WriteLine("Danh sách sau khi đảo:");
            foreach (var x in list)
                Console.Write(x + " ");
        }
    }
}