using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("HoaDonChiTiet")]//Đặt tên bảng
    public class HoaDonChiTiet
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int MaHoaDon { get; set; }
        public int MaPhong { get; set; }
        public int MaDichVu { get; set; }
        public float TienDien { get; set; }
        public float TienNuoc { get; set; }
        public float TienPhong { get; set; }
        public float TienMang { get; set; }
        public float TienVeSinh { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayXuat { get; set; }
        public bool TrangThai { get; set; }
    }
}
