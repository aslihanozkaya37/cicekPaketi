using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "lütfen ürünün adını boş geçmeyiniz.")]
        [StringLength(20, ErrorMessage = "Ürün ismi maksimum 20 karakredir.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "lütfen ürünün bir adet resmini mutlaka koyunuz.")]
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        [Required(ErrorMessage = "lütfen adeti boş geçmeyiniz.")]
        public int Quantity { get; set; }


        [Required(ErrorMessage = "lütfen fiyatını boş geçmeyiniz.")]
        public decimal Price { get; set; }
    }
}
