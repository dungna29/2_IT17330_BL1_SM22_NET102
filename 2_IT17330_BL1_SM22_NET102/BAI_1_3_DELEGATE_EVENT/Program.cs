using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_3_DELEGATE_EVENT
{
    internal class Program
    { /*
       * ❑Sự kiện (Event) là các hành động, ví dụ như nhấn phím, click, di chuyển chuột...
         ❑Trong C#, Event là một đối tượng đặc biệt của  Delegate, nó là nơi chứa các phương thức, các phương thức này sẽ được thực thi khi sự kiện xảy ra
         ❑Đặc điểm của event:
             ❖Được khai báo trong các lớp hoặc interface
             ❖Được khai báo là abstract hoặc sealed, virtual
             ❖Được thực thi thông qua delegate
         ❑Tạo và sử dụng event
             ❖Đinh nghĩa delegate cho event
             ❖Tạo event thông qua delegate
             ❖Đăng ký để lắng nghe và xử lý event
             ❖Kích hoạt event
       */
        //Bước 1: Tạo 1 delegate
        delegate void UpdateNameHandler(string studentName);
        //Bước 2: Tạo 1 Class dối tượng
        class Student
        {
            public event UpdateNameHandler nameChanged;
            private string name;
            public string Name
            {
                get => name;
                set
                {
                    name = value;
                    //Kiểm tra gọi ra sự kiện mỗi khi name bị thay đổi
                    if (nameChanged != null)
                    {
                        nameChanged(name);
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Student st = new Student();
            st.nameChanged += st_nameChanged;//Gõ += và tab sẽ có tia chớp chính là 1 sự kiện và nó sẽ tự động zen ra cho 1 phương thức sự kiện
            st.Name = "Dũng";
            Console.WriteLine("Sinh viên tên: " + st.Name);
            st.Name = "Hùng";
            Console.WriteLine("Sinh viên tên: " + st.Name);
        }

        private static void st_nameChanged(string studentname)
        {
            Console.WriteLine("Thông báo có giá trị mới của name = " + studentname);
        }
    }
}
