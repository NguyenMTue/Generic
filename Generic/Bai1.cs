using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai1
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 1: Tạo danh sách số nguyên ===");

            List<int> list = new List<int>();

            Console.WriteLine("Nhập 5 số nguyên:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Phần tử {i}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Danh sách:");
            foreach (var x in list)
                Console.Write(x + " ");
        }
    }
}