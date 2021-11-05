using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("DichVuChiTiet")]//Đặt tên bảng
    public class DichVuChiTiet
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int IdDichVu { get; set; }
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }
        public int DonGia { get; set; }
        public bool TrangThai { get; set; }

    }
}
