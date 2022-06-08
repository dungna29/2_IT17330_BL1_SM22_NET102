using System;
using System.CodeDom;
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
            //Về nhà gọi các phương thức vào đây để chạy test
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program pg = new Program();
            LINQ_GROUPBY();
        }
        /*
         * IEnumerable là Interface và là 1 mảng chỉ có thể Read-Only, không thể thêm bớt phần tử. Duyệt theo 1 chiều từ đầu tới cuối.
         */
        #region 1. Where điều kiện lọc

        static void LINQ_WHERE()
        {
            //Lấy danh sách những người có điện thoại của VINA và Viettel 091 098
            var lstSdt =
                (from a in _lstNhanViens
                 where a.Sdt.StartsWith("091") || a.Sdt.StartsWith("098")
                 select a).ToList();//= List object

            var lstSdtLambda = _lstNhanViens.Where(c => c.Sdt.StartsWith("091") || c.Sdt.StartsWith("098")).ToList();

            foreach (var x in _lstNhanViens.Where(c => c.Sdt.StartsWith("091") || c.Sdt.StartsWith("098")).ToList())
            {
                x.InRaManHinh();
            }

        }

        #endregion

        #region 2. Toán tử OfType để lọc các kiểu dữ liệu

        static void LINQ_OfType()
        {
            List<dynamic> lstString = new List<dynamic>() { 9, "Chín", 7, "bẩy" };
            var lst1 =
                from a in lstString.OfType<string>()
                select a;
            var lst2 =
                from a in lstString.OfType<int>()
                select a;
            Console.WriteLine("lstString.OfType<string>()");
            foreach (var x in lst1) Console.WriteLine(x);
            Console.WriteLine("lstString.OfType<int>()");
            foreach (var x in lst2) Console.WriteLine(x);
        }

        #endregion
        #region 3. Orderby dùng sắp xếp ngược xuôi và mặc định là ASC theo 1 điều kiện cụ thể

        static void LINQ_Orderby()
        {
            var lstDsNV =
                from a in _lstNhanViens
                orderby a.TenNV  // ascending và descending 
                select a;
            var lstDsNV1 = _lstNhanViens.OrderBy(c => c.TenNV);
        }

        //ThenBy đi với Orderby giúp mở rộng để sắp xếp thêm nhiều cột cùng 1 lúc
        static void LINQ_ThenBy()
        {
            var lst1 = _lstNhanViens.OrderBy(c => c.TenNV).ThenBy(c => c.Sdt);
            var lst2 = _lstNhanViens.OrderBy(c => c.TenNV).ThenByDescending(c => c.Sdt);
        }

        #endregion
        #region 4. Group By nhóm các phần giống nhau

        static void LINQ_GROUPBY()
        {
            List<string> lstName = new List<string> { "A", "A", "A", "NHAM", "NHAM", "NAM", "NAM" };
            var lst1 =
                from a in lstName
                group a by a
                into g
                select g.Key;//Lấy ra dữ liệu các phần tử không trùng nhau vì đã bị nhóm lại
            foreach (var x in lst1)
            {
                Console.WriteLine(x);   
            }
            //Dừng lại ở đây
        }


        #endregion
        #region Temp

        static void Temp()
        {

        }


        #endregion
    }
}
