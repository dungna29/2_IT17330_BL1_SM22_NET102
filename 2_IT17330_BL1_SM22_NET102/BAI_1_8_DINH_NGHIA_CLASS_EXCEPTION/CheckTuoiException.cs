using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_DINH_NGHIA_CLASS_EXCEPTION
{
    internal class CheckTuoiException: Exception
    {
        //prop + tab
        public int Age { get; set; }

        public CheckTuoiException(string message, int age) : base(message)
        {
            Age = age;
        }

        public void ThoBaoLoi()
        {
            Console.WriteLine($"Tuổi của bạn là: {Age} chưa đủ tuổi nhập học tại ngành PTPM FPOLY");
        }
    }
}
