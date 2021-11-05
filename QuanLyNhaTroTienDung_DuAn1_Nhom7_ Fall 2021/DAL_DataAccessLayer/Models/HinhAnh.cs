using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("HinhAnh")]//Đặt tên bảng
    public class HinhAnh
    {
        [Key]
        [Required]
        public int id { get; set; }
        [StringLength(50)]
        public string HinhAnhPhong { get; set; }

        [ForeignKey("MaPhong")]
        public int MaPhong { get; set; }
       // public LoaiPhong LoaiPhongs { get; set; }
    }
}
