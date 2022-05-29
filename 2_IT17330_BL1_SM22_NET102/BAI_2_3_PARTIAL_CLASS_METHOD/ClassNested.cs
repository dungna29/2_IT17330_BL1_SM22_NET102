using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_PARTIAL_CLASS_METHOD
{  /*
     * Trong C# nó cho phép bạn khai báo một lớp (class), giao diện (interface), cấu trúc (struct) trong thân một lớp khác - chúng được gọi là kiểu lồng nhau (Nested Type)
     */
    internal class ClassNested
    {
        public List<ClassD> ListClassD { get; set; }
        public class ClassD
        {
            public int VariableA { get; set; }

            public ClassD()
            {
                
            }

            public ClassD(int variableA)
            {
                VariableA = variableA;
            }

            public void Method1()
            {

            }
        }

        public class ClassE
        {
            
        }
    }
}
