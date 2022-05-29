using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_PARTIAL_CLASS_METHOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Phần 1: Sử dụng Partial Class
             * Khi sử dụng đối tượng Class A hoàn toàn bình thường như các Class khác nhưng nó được phân tách thành 2 file
             */
            ClassA classA = new ClassA();
            classA.VariableA = 1;
            classA.VariableB = "";
            classA.VariableC = 1;
            classA.VariableD = 1;
            classA.Method1();
            classA.Method3();

            /*
             * Phần 2: Sử dụng Nested Type
             * Lớp Nested được khai báo, định nghĩa trong lớp Container, nếu phạm vị lớp public, thì bên ngoài sử dụng lớp con này bằng cách chỉ rõ Container.Nested
             */
            ClassNested classNested = new ClassNested();
            ClassNested.ClassD classD = new ClassNested.ClassD();
            classD.Method1();
            classD.VariableA = 1;

        }
    }
}
