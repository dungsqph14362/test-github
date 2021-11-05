using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("NhanVien")]//Đặt tên bảng
    public class NhanVien
    {
        [Key]
        [Required]
        public int MaNV { get; set; }
        [StringLength(50)]
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        [StringLength(50)]
        public string SDT { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        public DateTime NamSinh { get; set; }
        public bool TrangThai { get; set; }
        public int ChucVu { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string MatKhau { get; set; }
    }
}
