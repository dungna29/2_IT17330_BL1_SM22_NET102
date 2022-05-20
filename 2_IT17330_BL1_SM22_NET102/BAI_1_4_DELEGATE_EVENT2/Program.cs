using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_4_DELEGATE_EVENT2
{
    internal class Program
    {
        public delegate void SuKienNhap2So(int x,int y);

        class NguoiDung
        {
            public event SuKienNhap2So suKienNhapSo;

            public void Nhap2So()
            {
                Console.WriteLine("Mời bạn nhập số 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập số 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                suKienNhapSo.Invoke(a,b);
            }
        }

        class TinhToan
        {
            public void thiHanhTinhTong(NguoiDung nguoidung)
            {
                nguoidung.suKienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì sẽ tiến hành tính tổng.
            }

            public void tinhTong(int d,int e)
            {
                Console.WriteLine($"{d} + {e} = {d+e}");
            }

        }

        static void Main(string[] args)
        {
            //Phát đi sự kiện
            NguoiDung nguoiDung = new NguoiDung();

            //Nhận sự kiện
            TinhToan tinhToan = new TinhToan();
            tinhToan.thiHanhTinhTong(nguoiDung);

            //Thực thi
            nguoiDung.Nhap2So();
        }
    }
}
