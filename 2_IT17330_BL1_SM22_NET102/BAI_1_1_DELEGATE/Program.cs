using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_DELEGATE
{
    internal class Program
    {
        #region Delegate
        /*
       * Định nghĩa:
           * ❑Delegate là một biến chứa tham chiếu đến phương thức cần thực thi.
             ❑Một delegate có thể trỏ tới một hoặc nhiều phương thức
             ❑Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi
             ❑
       * + Có thể khai báo trong namespace hoặc khai báo trong class
       * + Khi khai báo giống như khai báo một phương thức
       * + Công thức:
       *      <phạm vi truy cập> delegate <kiểu phương thức> <tên>(<Tham số>); 
       */


        #endregion
        //Khai báo Delegate
        public delegate void ThongBao(string msg);

        public static void ThongTin1(string noiDung)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThongTin1: " + noiDung);
            Console.ResetColor();
        }
        public static void ThongTin2(string noiDung)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThongTin2: " + noiDung);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            #region Phần 1: Khởi tạo delegate null

            Console.WriteLine("====Phần 1: Khởi tạo delegate null====");
            ThongBao thongBao = null;//Khởi tạo delegate null
            thongBao = ThongTin1;//Gán phương thức cho delegate và delegate sẽ trỏ đến phương thức ddos.
            thongBao?.Invoke("Học C#2 dễ");//? Dùng để kiểm tra xem delegate có null hay không. Và nếu không null sẽ thực thi đến phương thức đó.

            #endregion

            #region Phần 2: Khởi tạo delegate
            Console.WriteLine("====Phần 2: Khởi tạo delegate====");
            ThongBao thongBao2 = new ThongBao(ThongTin1);
            thongBao2("Học C#2 cũng không khó");
            ThongTin1("Học C#2 FPOLY");//Gọi trực tiếp phương thức.
            #endregion

            #region Phần 3: Multicast Delegate
            Console.WriteLine("====Phần 3: Multicast Delegate====");
            ThongBao thongBao3 = new ThongBao(ThongTin1);
            ThongBao thongBao4 = new ThongBao(ThongTin2);
            ThongBao multicastDelegate = thongBao3 + thongBao4;
            multicastDelegate += thongBao3;//= multicastDelegate + thongBao3
            //multicastDelegate -= thongBao3;
            multicastDelegate("Học C#3 sẽ nhìn thấy delegate nhiều hơn");

            #endregion

            #region Phần 4: Delegate CallBack
            Console.WriteLine("====Phần 4: Delegate CallBack====");
            DelegateCallBack delegateCall = new DelegateCallBack(ThongTin3);

            CallBack(delegateCall);
            #endregion
        }
        #region Phần 4: Delegate CallBack

        public delegate void DelegateCallBack(string noidung);

        public static void ThongTin3(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThongTin3: " + msg);
            Console.ResetColor();
        }

        public static void CallBack(DelegateCallBack delegateCallBack)
        {
            Console.Write("Mời bạn nhập thông báo: ");
            string temp = Console.ReadLine();
            delegateCallBack(temp);
        }
        #endregion
    }
}
