using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_NULLABLE_TYPED
{
    internal class Program
    {
        #region Định nghĩa
        /*
        * 1. Từ khóa null
        *    + null là một giá trị cố định nó biểu thị không có đối tượng nào cả, có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).
             + null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...
        */

        /*
         *2. Sử dụng nullable
         *    + Nếu bạn muốn sử dụng các kiểu dữ liệu nguyên tố như int, float, double ... như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, có thể sử dụng như đối tượng ... thì khai báo nó có khả năng nullable, khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value, cách làm như sau:
         *    + Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu      
         */
        #endregion
        static void Main(string[] args)
        {
            #region Phần 1: Null

            ClassA classA1, classA2;
            classA1 = new ClassA();//Khởi tạo tham chiếu bằng 1 đối tượng
            classA2 = classA1;//ClassA2 được gán ClassA1 tham chiếu đến cùng 1 đối tượng ClassA1
            classA2.Method1();

            classA1 = null;//ClassA1 đang không tham chiếu đến đối tượng nào cả
            //classA1.Method1();//Chết chương trình

            string s1 = null;
            //int s2 = null; //int là kiểu tham trị, nó chỉ có thể gán biến s2 = 1. Và tham trị thì không thể gán null
            //double s3 = null; Lỗi

            #endregion

            #region Phần 2: NULLABLE TYPED
            /*2.  NULLABLE TYPED
                + Cú pháp: 
                    - Nullable<T> tên biến;
                    - T? tên biến;
                + Cần gán gia trị cho biến khi khai báo nếu không sẽ bị lỗi và nên kiểm tra giá tị trước khi dùng bằng HasValue
                + Dùng phương thức GetValueOrDefault() để lấy giá mặc định của kiểu dữ liệu
                + Dùng toán tử ?? thực hiện gán Nullable Type cho Non-Nullable Type
                */
            Nullable<long> l1 = null;
            Nullable<int> i1 = null;
            int? i2 = 20;
            int? i3 = null;
            int?[] arr = new int?[5];
            int temp = 5;
            if (i3.HasValue)//Kiểm tra giá trị trước khi dùng
            {
                //Body Code
            }

            Console.WriteLine(i3.GetValueOrDefault());//Giá trị mặc định int là 0

            //Toán tử ?? thực hiện Nullable cho non-NullAble
            int? temp1 = null;
            //temp1 = 20;
            int temp2 = temp1??0;//temp2 = temp1 khi temp1 != null, temp2 = 0 khi temp1 bị null

            #endregion
        }

        class ClassA
        {
            public ClassA()
            {
                
            }
            public void Method1()
            {

            }
        }
    }
}
