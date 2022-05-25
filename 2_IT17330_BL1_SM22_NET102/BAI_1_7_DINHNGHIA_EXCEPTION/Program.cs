using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_7_DINHNGHIA_EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                DangKyNhapHocCNTTFPOLY("FPOLY",17);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Main");
        }

      

        
        //Tự định nghĩa ra 1 Exception bên trong 1 phương thức
        static void DangKyNhapHocCNTTFPOLY(string TenTruong,int tuoi)
        {
            if (TenTruong != "FPOLY")
            {
                Exception exception = new Exception("Bạn điền nhầm tên trường trong form đăng ký");
                throw exception;
            }

            if (tuoi <18)
            {
                throw new Exception("Bạn chưa đủ tuổi nhập học.");
            }

            Console.WriteLine("Chúc mừng bạn đăng ký nhập học thành công.");
        }
    }
}
