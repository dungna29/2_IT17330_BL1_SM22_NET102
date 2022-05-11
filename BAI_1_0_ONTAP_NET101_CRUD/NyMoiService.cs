using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_ONTAP_NET101_CRUD
{
    //Code các chức năng
    internal class NyMoiService
    {
        private List<NYMoi> _lstNyMois;
        private NYMoi _nyMoi;
        private string _input;
        public NyMoiService()
        {
            FakeData();
        }

        private void FakeData()
        {
            _lstNyMois = new List<NYMoi>()
            {
                new NYMoi(1, "Nguyễn Thị A", 60, 1995, 100),
                new NYMoi(2, "Nguyễn Thị B", 80, 1995, 120),
            };

        }

        public void ThemNY1()
        {
            int soluong = Convert.ToInt32(GetInputValue("số lượng"));
            for (int i = 0; i < soluong; i++)
            {
                _nyMoi = new NYMoi();
                _nyMoi.Id = Convert.ToInt32(GetInputValue("mã"));
                _nyMoi.Ten = GetInputValue("tên");
                _nyMoi.Ns = Convert.ToInt32(GetInputValue("năm sinh"));
                _nyMoi.CanNang = Convert.ToDouble(GetInputValue("cân nặng"));
                _nyMoi.Vong3 = Convert.ToDouble(GetInputValue("cân nặng"));
                //Sau khi gán giá trị cho đối tượng thì tiến hành add đối tượng vào List
                _lstNyMois.Add(_nyMoi);
            }
        }
        public void ThemNY2()
        {
            int soluong = Convert.ToInt32(GetInputValue("số lượng"));
            for (int i = 0; i < soluong; i++)
            {
                
                _lstNyMois.Add(new NYMoi(Convert.ToInt32(GetInputValue("mã")), GetInputValue("tên"), Convert.ToDouble(GetInputValue("cân nặng")), Convert.ToInt32(GetInputValue("năm sinh")), Convert.ToDouble(GetInputValue("vòng 3"))));
            }
        }

        public void InDanhSash()
        {
            foreach (var x in _lstNyMois) x.InRaManHinh();
        }
        //Coi phương thức trả về là 1 GIÁ TRỊ hoặc TẬP GIÁ TRỊ
        public string GetInputValue(string msg)
        {
            Console.WriteLine($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }
    }
}
