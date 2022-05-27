using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_DINH_NGHIA_CLASS_EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                DangKyNhapHocCNTTFPOLY("BK", 17);
            }
            catch (CheckTuoiException e)
            {
                Console.WriteLine(e.Message);
                e.ThoBaoLoi();
            }
            catch (CheckTruongException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        static void DangKyNhapHocCNTTFPOLY(string TenTruong, int tuoi)
        {
            if (TenTruong != "FPOLY")
            {
                CheckTruongException exception = new CheckTruongException("Bạn điền nhầm tên trường trong form đăng ký");
                throw exception;
            }

            if (tuoi < 18)
            {
                throw new CheckTuoiException("CheckTuoiException: ", tuoi);
            }

            Console.WriteLine("Chúc mừng bạn đăng ký nhập học thành công.");
        }
    }
}
