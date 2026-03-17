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
                    case 3:
                        Bai3.Run();
                        break;
                    case 4:
                        Bai4.Run();
                        break;
                    case 5:
                        Bai5.Run();
                        break;
                    case 6:
                        Bai6.Run();
                        break;
                    case 7:
                        Bai7.Run();
                        break;
                    case 8:
                        Bai8.Run();
                        break;
                    case 9:
                        Bai9.Run();
                        break;
                    // case 10:
                    //     Bai10.Run();
                    //     break;
                    // case 11:
                    //     Bai11.Run();
                    //     break;
                    // case 12:
                    //     Bai12.Run();
                    //     break;
                    // case 13:
                    //     Bai13.Run();
                    //     break;
                    // case 14:
                    //     Bai14.Run();
                    //     break;
                    // case 15:
                    //     Bai15.Run();
                    //     break;
                    // case 16:
                    //     Bai16.Run();
                    //     break;
                    // case 17:
                    //     Bai17.Run();
                    //     break;
                    // case 18:
                    //     Bai18.Run();
                    //     break;
                    default:
                        Console.WriteLine("Không hợp lệ!");
                        break;
                }
            }
        }
    }
}