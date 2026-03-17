using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai16
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 16: Đếm ký tự ===");

            Console.Write("Nhập chuỗi: ");
            string str = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict[c] = 1;
            }

            Console.WriteLine("Kết quả:");
            foreach (var item in dict)
                Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}