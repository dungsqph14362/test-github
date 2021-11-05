using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("ChucVu")]//Đặt tên bảng
    class ChucVu
    {
        [Key]
        [Required]
        public int MaChucVu { get; set; }
        [StringLength(50)]
        public string TenChucVu { get; set; }
    }
}
