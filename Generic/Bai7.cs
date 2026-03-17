using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai7
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 7: Sắp xếp danh sách ===");

            List<int> list = new List<int>();

            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử {i}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            list.Sort();

            Console.WriteLine("Danh sách tăng dần:");
            foreach (var x in list)
                Console.Write(x + " ");
        }
    }
}