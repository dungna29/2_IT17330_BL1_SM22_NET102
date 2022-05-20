using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_DELEGATE_FUNC_PREDICATE_ACTION
{
    internal class Program
    {
        #region  Bài Action, Predicate, Func: Delegate - Generic(Sử dụng sẵn tham số Generic để khai báo)
        /*
         Thay vì chúng ta phải khai báo định nghĩa trước delegate thì chúng ta sẽ sử dụng 3 kiểu dưới đây khai báo cho nhanh.
          Action, Predicate, Func (Viết tắt là APF là cho nhanh) trong C#
            + Action: Action<T in1, T in2, …>. Action tương đương 1 delegate với kiểu trả về là void, với in1, in2 là các params nhận vào.
            + Predicate: Predicate<T in>. Predicate tương đương 1 delegate với kiểu trả về là bool, với in là các param nhận vào. Predicate chỉ có thể nhận vào 1 param duy nhất.
            + Func: Func<T in1, T in2, … , T result>. Function tương đương 1 delegate với kiểu trả về do ta khai báo (result), in1, in2 là các params nhận vào. Func bắt buộc phải trả ra giá trị, không thể trả void.
            Bảng so sánh cách khai báo bằng delegate cùng với cách khai báo tương ứng bằng Action, Predicate, Func:
            delegate void VoidDelegate(int input1, bool input2)	- Action<int, bool>	
            
            delegate bool BoolDelegate(int input1)	-  Predicate<int>	|| Func<int, bool>
            delegate int intDelegate(bool input2)	- Func<bool, int>
            
            delegate void HelloWorldDelegate()	- Action
            delegate bool HelloWorldBoolDelegate()	- Predicate -  Func<bool>
        */
        public static void ThongTin1(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThongTin1: " + msg);
            Console.ResetColor();
        }
        public static void ThongTin2(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThongTin1: " + msg);
            Console.ResetColor();
        }
        public static void ThongTin3(string msg, int msg2)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("ThongTin1: " + msg);
            Console.ResetColor();
        }

        static int PhepTru(int a, int b)
        {
            return a - b;
        }

        static bool CheckChuVietHoa(string value)
        {
            return value.Equals(value.ToUpper());//dung = DUNG
        }

        delegate void tempDeleagate();
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            List<string> lstInt;

            #region Phần 1: Action - Chỉ đi với phương thức void

            Action action;//Tương đương như delegate void tempDelegate();
            Action<string, int> action1;//Tương đương như delegate void tempDelegate(string a, int b);
            Action<string> action2;//Tương đương như 1 delegate void tempDelegate(string a)
            action1 = ThongTin3;
            action1?.Invoke("action",1);
            #endregion

            #region Phần 2: Predicate - Chỉ đi với phương thức trả về kiểu bool - Chỉ đi với 1 tham số

            Predicate<string> predicate;//tương đương delegate bool tenDelegate(string a);
            predicate = CheckChuVietHoa;
            Console.WriteLine("Chữ Dung có viết hoa hay không? " + predicate.Invoke("Dung"));//== false

            #endregion

            #region Phan 3: Func - Chỉ đi với các phương thức trả về
            //Kiểu trả về của phương thức nằm ở cuối tham số
            Func<int, int, int> func1;//tương đương delegate int tenDelegate(int a,int b);
            func1 = PhepTru;
            Func<string, int, string, int, double> func2;

            #endregion
            /*
            * Bài tập ví dụ:
            * Viết 4 phương thức để gán được cho các delegate dưới đây
            * Func<double,double,string,int> funcbt1;
            * Predicate<string,string,bool> predbt2; // ĐỎ mới đúng
            * Action<string,int,double> actionbt3;
            * Func<int,string,string> funcbt4;
             * Action action2;
            */
            Action actions2 = method1;
        }

        static void method1()
        {
            Action<string, int, double> actionbt3 = method2;
            Func<string, string, bool> predbt2 = method3;
        }

        static void method2(string a,int b,double c)
        {

        }

        static bool method3(string a,string b)
        {
            return true;
        }
    }
}
