using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_PARTIAL_CLASS_METHOD
{
    internal partial class ClassA
    {
        public int VariableC { get; set; }
        public int VariableD { get; set; }
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
        partial void Method2(string a, int b)
        {
            Console.WriteLine("Method3");
        }
    }
}
