using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("NguoiDung")]//Đặt tên bảng
    public class NguoiDung
    {
        [Key]//Chỉ định dưới nó sẽ là khóa chính
        [Required]
        public int MaNguoiDung { get; set; }
        [StringLength(50)]
        public string TenNguoiDung { get; set; }
        [StringLength(50)]
        public string SoDienThoai { get; set; }
        [StringLength(100)]
        public string QueQuan { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public float TienCoc { get; set; }
        [StringLength(50)]
        public string CCCD { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        public int GioiTinh { get; set; }
        [StringLength(200)]
        public string GhiChu { get; set; }


        [ForeignKey("MaPhongTro")]//Tạo tên cột khóa phụ
        public int MaPhongTro { get; set; }
        public PhongTro PhongTros { get; set; }
    }
}
