using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai15
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 15: Từ điển Anh - Việt ===");

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"hello", "xin chào"},
                {"book", "sách"},
                {"cat", "con mèo"},
                {"dog", "con chó"}
            };

            Console.Write("Nhập từ tiếng Anh: ");
            string input = Console.ReadLine();

            if (dict.ContainsKey(input))
                Console.WriteLine("Nghĩa: " + dict[input]);
            else
                Console.WriteLine("Không tìm thấy!");
        }
    }
}