using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_8_DocGhiDoiTuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Tự triển khai lại Menu Switch Case
            NyMoiService ny = new NyMoiService();
            string input;
            do
            {
                Console.WriteLine(Guid.NewGuid());
                Console.WriteLine("Quản lý người yêu mới");
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Xuất ds");
                Console.WriteLine("6. Lưu file");
                Console.WriteLine("7. Đọc file");
                Console.WriteLine("8. Thoát");
                Console.WriteLine("Mời bạn chọn: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ny.ThemNY2();
                        break;
                    case "2":
                        ny.Sua();
                        break;
                    case "3":
                        ny.Xoa();
                        break;
                    case "4":
                        ny.TimKiem();
                        break;
                    case "5":
                        ny.InDanhSash();
                        break;
                    case "6":
                        ny.SaveFile();
                        break;
                    case "7":
                        ny.ReadFile();
                        break;
                    default:
                        break;
                }

            } while (!(input == "6"));
        }
    }
}
