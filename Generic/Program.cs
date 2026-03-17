using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mã SV: 23115053122342");
            Console.WriteLine("Tên SV: Nguyễn Minh Tuệ");
            Console.WriteLine("Lớp: 225LTC01");

            while (true)
            {
                Console.WriteLine("\nChọn bài (1-18), nhập 0 để thoát:");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Kết thúc chương trình.");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Bai1.Run();
                        break;
                    case 2:
                        Bai2.Run();
                        break;
                    // case 3:
                    //     Bai3.Run();
                    //     break;
                    // case 4:
                    //     Bai4.Run();
                    //     break;
                    default:
                        Console.WriteLine("Không hợp lệ!");
                        break;
                }
            }
        }
    }
}