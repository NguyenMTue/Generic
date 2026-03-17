using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai6
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 6: Kiểm tra phần tử tồn tại ===");

            List<string> list = new List<string> { "An", "Bình", "Cường" };

            Console.Write("Nhập tên cần kiểm tra: ");
            string name = Console.ReadLine();

            if (list.Contains(name))
                Console.WriteLine("Có trong danh sách");
            else
                Console.WriteLine("Không có trong danh sách");
        }
    }
}