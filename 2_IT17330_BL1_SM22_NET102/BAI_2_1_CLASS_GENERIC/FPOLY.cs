using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_CLASS_GENERIC
{
    //T là kiểu dữ liệu
    internal class FPOLY<T>
    {
        private T temp;

        public FPOLY()
        {
            
        }

        public FPOLY(T temp)
        {
            this.temp = temp;
        }

        public T Temp
        {
            get => temp;
            set => temp = value;
        }

        public T GetValueDungna()
        {
            Console.WriteLine(temp);
            return temp;
        }
    }
}
