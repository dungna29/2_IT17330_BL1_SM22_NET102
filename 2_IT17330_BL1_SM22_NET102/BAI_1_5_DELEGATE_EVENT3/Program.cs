using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_5_DELEGATE_EVENT3
{
    internal class Program
    {
        /*
         * Ngoài ra trong C# có sẵn chuẩn tạo ra sự kiện Delegate
        
         */

        class NguoiDung
        {
            public event EventHandler suKienNhapSo;//Tương đương delegate void ten(object sender, EventArgs e)

            public void Nhap2So()
            {
                Console.WriteLine("Mời bạn nhập số 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập số 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                suKienNhapSo.Invoke(this,new NguoiDung1(a,b));
            }
        }

        class NguoiDung1 : EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }

            public NguoiDung1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class TinhToan
        {
            public void thiHanhTinhTong(NguoiDung nguoidung)
            {
                nguoidung.suKienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì sẽ tiến hành tính tổng.
            }

            public void tinhTong(object sender,EventArgs e)
            {
                NguoiDung1 nguoidung1 = (NguoiDung1)e;
                Console.WriteLine($"{nguoidung1.a} + {nguoidung1.b} = {nguoidung1.a + nguoidung1.b}");
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
