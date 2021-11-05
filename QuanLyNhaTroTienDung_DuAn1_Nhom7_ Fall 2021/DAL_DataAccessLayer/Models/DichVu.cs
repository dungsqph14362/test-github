using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Models
{
    [Table("DichVu")]//Đặt tên bảng
    public class DichVu
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public string TenDichVu { get; set; }
    }
}
