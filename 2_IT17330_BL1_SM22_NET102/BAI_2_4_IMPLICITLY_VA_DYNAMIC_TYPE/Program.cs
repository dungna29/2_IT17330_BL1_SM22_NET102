using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_IMPLICITLY_VA_DYNAMIC_TYPE
{
    internal class Program
    {
        /*
       * Phần 1: Implicitly,Dynamic
       *          1.1 Implicitly (KIỀU NGẦM ĐỊNH):
       *             ❑Khai báo biến kiểu ngầm định (khai báo không tường minh) là biến được khai báo mà không cần phải chỉ ra kiểu dữ liệu
                     ❑Kiểu dữ liệu của biến sẽ được xác định bởi trình biên dịch dựa vào biểu thức được gán khi khai báo biến
                     ❑Sử dụng từ khóa “var” khi khai báo và cần khởi tạo giá trị
                  1.2 Công thức:
                      var varialble_name = value;
                  1.3 Hạn chế:
                     + Không thể sử dụng từ khóa var bên ngoài phạm vi của một method
                     + Không thể khởi tạo giá trị là null.
                     + Biến phải được khởi tạo giá trị khi nó được khai báo 
                     + Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống        nhau
                     + Giá trị khởi tạo phải là một biểu thức. Giá trị khởi tạo     không được là một đối tượng hay tập hợp các giá trị. Nhưng nó có thể sử dụng toán tử new bởi một đối tượng hoặc tập hợp các giá trị.
                  2.1 Dynamic
                      Kiểu động - ngầm định - khai báo với từ khóa dynamic, thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy (khác với kiểu ngầm định var kiểu xác định ngay        thời điểm biên dịch)
       */
        static void Main(string[] args)
        {
            #region  Phần 1: Impliciyly
            //1. Khai báo
            var temp1 = 1;//Impliciyly - Ngầm định
            var temp2 = "2";//Impliciyly
            var temp3 = '5';//Impliciyly
            var temp4 = true;//Impliciyly
            //.......... 
            int temp5 = 6;//Explicitly - Tường minh

            //2. Hạn chế khi khai báo không sẽ xảy ra lỗi
            // - Không thể khởi tạo giá trị null
            //var temp6 = null;

            // - Phải khởi tạo giá trị ngay khi sử dụng.
            //var temp6;

            //  - Nếu biến được gán giá trị thì kiểu dữ liệu phải giống như lúc khởi tạo
            // var temp6 = 5;
            // temp6 = "6";

            // - Giá trị khởi tạo phải là 1 biểu thức. Giá trị khởi tạo không được là 1 đối tượng hay tập giá trị. Nó có thể sử dụng toán tử new bởi 1 đối tượng hoặc tập giá trị
            //var temp6 = {5, 9, 8};
            var temp6 = new int[] {5, 9, 8};
            var temp7 = new List<int>() {5, 9, 8};

            // - Var không thể đưa ra bên ngoài làm biến toàn cục, và var không được sử dụng để làm kiểu dữ liệu tham số cho phương thức.
            #endregion

            #region Phần 2: Dynamic - Tại thời điểm chạy mới xác định kiểu dữ liệu
            //Phần sử dụng tương tự như var ở trên
            dynamic x;
            x = 1;
            x = "1";

            //Khai báo nặc danh
            var student = new
            {
                Msv = "PH00111",
                Ten = "Nam",
                NganhHoc = "UDPM .NET"
            };

            Method2(student,student.NganhHoc);

            #endregion
        }

        private dynamic a;

        static void Method2(dynamic temp1,dynamic temp2)
        {
            Console.WriteLine(temp1.Ten + " " + temp2);
        }

        // void method1(var temp)
        // {
        //
        // }
    }
}
