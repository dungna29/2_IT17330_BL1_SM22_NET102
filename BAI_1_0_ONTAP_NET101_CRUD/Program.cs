using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_ONTAP_NET101_CRUD
{
    internal class Program
    {
        //CRUD người yêu mới
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            NyMoiService ny = new NyMoiService();
            do
            {
                ny.InDanhSash();
                ny.ThemNY1();
            } while (true);
        }
    }
}
