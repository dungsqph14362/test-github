using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("PhongTro")]//Đặt tên bảng
    public class PhongTro
    {
        [Key]
        [Required]
        public int MaPhongTro { get; set; }
        public int MaLoaiPhong { get; set; }
        public float GiaPhong { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(100)]
        public string MoTa { get; set; }
        [StringLength(50)]
        public string DienTich { get; set; }
        public bool TrangThai { get; set; }
        [StringLength(50)]
        public string HinhAnh { get; set; }
        
    }
}
