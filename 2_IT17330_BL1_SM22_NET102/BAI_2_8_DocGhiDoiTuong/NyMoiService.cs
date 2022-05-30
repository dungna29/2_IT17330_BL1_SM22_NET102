using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_8_DocGhiDoiTuong
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

       
        public void ThemNY2()
        {
            int soluong = Convert.ToInt32(GetInputValue("số lượng"));
            for (int i = 0; i < soluong; i++)
            {

                _lstNyMois.Add(new NYMoi(GetAuToId(), GetInputValue("tên"), Convert.ToDouble(GetInputValue("cân nặng")),
                    Convert.ToInt32(GetInputValue("năm sinh")), Convert.ToDouble(GetInputValue("vòng 3"))));
            }
        }

        public void InDanhSash()
        {
            foreach (var x in _lstNyMois) x.InRaManHinh();
        }
        /*
         * Sửa, Xóa, Tìm kiếm(Tuyệt đối)
         *
         */
        public void TimKiem()
        {
            Console.WriteLine("Mời bạn nhập ID: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNyMois.Count; i++)
            {
                if (_lstNyMois[i].Id==Convert.ToInt16(_input))
                {
                    _lstNyMois[i].InRaManHinh();
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy");
        }
        public void Xoa()
        {
            int temp = FindIndexObj();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            _lstNyMois.RemoveAt(temp);
            Console.WriteLine("Xóa thành công");
        }  
        public void Sua()
        {
            int temp = FindIndexObj();
            if (temp == -1 )
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            Console.WriteLine("Mời bạn nhập lại tên: ");
            _lstNyMois[temp].Ten = Console.ReadLine();
            Console.WriteLine("Sửa thành công");
        }
        //Coi phương thức trả về là 1 GIÁ TRỊ hoặc TẬP GIÁ TRỊ
        public string GetInputValue(string msg)
        {
            Console.WriteLine($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }

        public int FindIndexObj()
        {
            Console.WriteLine("Mời bạn nhập ID: ");
            _input = Console.ReadLine();
            return _lstNyMois.FindIndex(dungna => dungna.Id == Convert.ToInt16(_input));
        }

        //Có rất nhiều cách lưu file và đọc file
        //Lưu file
        public void SaveFile()
        {
            string path =
                @"H:\Dungna29 Fpoly\8. Demo\Demo C#2\SM22_BL1\2_IT17330_BL1_SM22_NET102\2_IT17330_BL1_SM22_NET102\BAI_2_8_DocGhiDoiTuong\data.bin";//ĐƯờng dẫn file lưu
            Console.WriteLine(FileService.SaveFile(path, _lstNyMois));
        }
        //Đọc file
        public void ReadFile()
        {
            string path =
                @"H:\Dungna29 Fpoly\8. Demo\Demo C#2\SM22_BL1\2_IT17330_BL1_SM22_NET102\2_IT17330_BL1_SM22_NET102\BAI_2_8_DocGhiDoiTuong\data.bin";//ĐƯờng dẫn file lưu
            _lstNyMois = new List<NYMoi>();
            _lstNyMois = FileService.ReadFile(path);
        }

        public int GetAuToId()
        {
            if (_lstNyMois.Count < 0)
            {
                return 1;
            }
            return _lstNyMois.Max(c => c.Id) + 1;
        }

        
      

       
    }
}
