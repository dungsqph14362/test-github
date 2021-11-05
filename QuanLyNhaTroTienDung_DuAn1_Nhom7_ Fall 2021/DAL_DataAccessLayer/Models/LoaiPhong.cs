using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("LoaiPhong")]//Đặt tên bảng
    public class LoaiPhong
    {
        [Key]
        [Required]
        public int MaLoaiPhong { get; set; }
        [StringLength(50)]
        public string TenLoaiPhong { get; set; }
    }
}
