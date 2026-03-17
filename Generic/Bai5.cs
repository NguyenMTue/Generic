using System;
using System.Collections.Generic;

namespace Generic
{
    // Mã SV: 23115053122342
    // Tên SV: Nguyễn Minh Tuệ
    class Bai5
    {
        public static void Run()
        {
            Console.WriteLine("=== Bài 5: Xóa phần tử khỏi List ===");

            List<string> list = new List<string> { "An", "Bình", "Cường", "Dũng" };

            Console.Write("Nhập tên cần xóa: ");
            string name = Console.ReadLine();

            bool removed = list.Remove(name);

            if (removed)
                Console.WriteLine("Đã xóa!");
            else
                Console.WriteLine("Không tìm thấy!");

            Console.WriteLine("Danh sách còn lại:");
            foreach (var x in list)
                Console.Write(x + " ");
        }
    }
}