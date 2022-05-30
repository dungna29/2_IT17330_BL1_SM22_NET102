using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_ANONYMOUS_TYPED
{
    internal class Program
    {
        #region ANONYMOUS TYPED
        /*
         * Phần 1:  Định nghĩa:
             * ❑Kiểu ẩn danh (Anonymous Type) cung cấp một cách thuận tiện để đóng gói (encapsulate) một tập các thuộc tính chỉ đọc (read-only properties) vào một đối tượng mà không cần phải xác định rõ ràng loại (type) của nó ngay lúc viết code
             * ❑Cho phép tạo type mới (user-defined) mà không cần xác định tên của nó
               ❑Tạo các type ẩn danh này bằng cách sử dụng toán tử new
           Phần 2: ANONYMOUS METHOD
            ❑Phương thức vô danh (anonymous method) là một phương thức:
               ❖Không cần khai báo tên phương thức khi định nghĩa phương thức
               ❖Có thể khai báo trực tiếp ở chỗ cần dùng, không cần định nghĩa trước
               ❖Đươc dùng như tham số của deleg
            ❑Một số giới hạn Anonymous methods
                ❖Không khái báo được các lệnh goto, break or continue bên trong phương thức
                ❖Không truy cập được các tham số ref hoặc out bên ngoài
                ❖Phải được dùng kết hợp với delegate
         */
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Phần 1: Khai báo Anonymous và Anonymous lồng nhau
             */
            var SinhVienFpoly = new
            {
                Msv = "PH00533",
                Ten = "Dũng",
                Nganh = ".NET"
            };
            Console.WriteLine($"{SinhVienFpoly.Ten} {SinhVienFpoly.Msv}");

            //Lồng nhau
            var SinhVienFpoly1 = new
            {
                Msv = "PH00533",
                Ten = "Dũng",
                Nganh = ".NET",
                DiaChi = new
                {
                    SoNha = 33,
                    Duong = "Trịnh Văn Bô"
                }
            };
            Console.WriteLine($"{SinhVienFpoly1.Ten} {SinhVienFpoly1.Msv} {SinhVienFpoly1.DiaChi.SoNha}");
            /*
            * Phần 2: Phương thức nặc danh
            */
            Method1 method1 = delegate(int x, int y)
            {
                //Có thể gọi biến cục bộ bên ngoài phương thức nặc danh như bt
                Console.WriteLine($"Đây là phương thức nặc danh {x} + {y}");
            };
            Method1 method2 = new Method1(method1);
            method2 += method1;
            method1(5, 6);
        }

        // static void PhuongThuc(int a, int b)
        // {
        //
        // }
        public delegate void Method1(int a, int b);
    }
}
