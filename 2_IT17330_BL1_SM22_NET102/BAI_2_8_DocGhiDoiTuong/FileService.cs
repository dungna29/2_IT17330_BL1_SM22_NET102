using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_8_DocGhiDoiTuong
{
    internal class FileService
    {
        private static FileStream _fs;
        private static BinaryFormatter _bf;
      
        /// <summary>
        /// Phương thức lưu file
        /// </summary>
        /// <param name="path">Đường dẫn lưu file</param>
        /// <param name="datas">Các đối tượng cần lưu</param>
        /// <returns></returns>
        public static string SaveFile(string path,List<NYMoi> datas)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();//Khởi tạo
            _bf.Serialize(_fs, datas);//Serialize Tuần tự hóa hoặc tuần tự hóa là quá trình dịch cấu trúc dữ liệu hoặc trạng thái đối tượng sang định dạng có thể được lưu trữ hoặc truyền và tái tạo lại sau này.
            _fs.Close();
            return "Lưu file thành công";
        }

        public static List<NYMoi> ReadFile(string path)
        {
            List<NYMoi> lstTempData = new List<NYMoi>();
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();//Khởi tạo
            var data = _bf.Deserialize(_fs);//Đọc đối tượng lên
            lstTempData = (List<NYMoi>) data;//Gán lại List data đọc lên cho list đối tượng nhưng phải ép kiểu.
            return lstTempData;
        }
    }
}
