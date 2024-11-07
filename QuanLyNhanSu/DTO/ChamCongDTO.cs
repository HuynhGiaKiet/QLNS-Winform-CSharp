using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
    class ChamCongDTO
    {
        public int Id { get; set; }
        public int Idnhanvien { get; set; }
        public string Giokiemtra { get; set; }
        public string Ngay { get; set; }
        public string Thang { get; set; }
        public string Nam { get; set; }
        public int Trangthai { get; set; }
        public string Noidung { get; set; }
        public string Ghichu { get; set; }
        public string Dieukien { get; set; }
    }
}
