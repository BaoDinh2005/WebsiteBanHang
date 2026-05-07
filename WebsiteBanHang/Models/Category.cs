using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanHang.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; }

        // Một danh mục có nhiều sản phẩm
        public List<Product> Products { get; set; }
    }
}