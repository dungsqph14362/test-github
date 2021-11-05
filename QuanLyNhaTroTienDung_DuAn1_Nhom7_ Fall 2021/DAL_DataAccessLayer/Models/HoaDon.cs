using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("HoaDon")]//Đặt tên bảng
    public class HoaDon
    {
        [Key]
        [Required]
        public int MaHoaDon { get; set; }
        public int MaNguoiDung { get; set; }
        public int MaPhongTro { get; set; }
        public int IdDichVu { get; set; }
        public float TongTien { get; set; }
        public bool TrangThai { get; set; }
        public int MaNhanVien { get; set; }
    }
}
