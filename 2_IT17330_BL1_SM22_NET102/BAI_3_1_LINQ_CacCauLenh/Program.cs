using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_1_LINQ_CacCauLenh
{
    internal class Program
    {
        private static ServiceAll _sv = new ServiceAll();
        private static List<NhanVien> _lstNhanViens;
        private static List<TheLoai> _lstTheLoais;
        private static List<SanPham> _lsSanPhams;
        public Program()
        {
            _lstNhanViens = _sv.GetListNhanViens();
            _lstTheLoais = _sv.GetListTheLoais();
            _lsSanPhams = _sv.GetListSanPhams();
        }
        static void Main(string[] args)
        {
        }
    }
}
