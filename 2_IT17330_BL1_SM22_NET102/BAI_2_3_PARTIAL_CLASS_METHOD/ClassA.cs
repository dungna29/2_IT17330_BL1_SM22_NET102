using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_PARTIAL_CLASS_METHOD
{
    /*
     * Partial Class chỉ là kỹ thuật giúp phân tách code của 1 class ra nhiều file khác nhau. Ứng dụng của nó thường là các file sinh code động trong C# như WINFORM.
     */
    internal partial class ClassA//partial trước tên class
    {
        public int VariableA { get; set; }
        public string VariableB { get; set; }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        //Phương thức partial khai báo không có thân code.
        partial void Method2(string a, int b);
    }
}
