using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "lütfen adınızı boş geçmeyiniz.")]
        [StringLength(20, ErrorMessage = "Maximum length is 20")]
        public string Name { get; set; }
        [Required(ErrorMessage = "lütfen soyadınızı boş geçmeyiniz.")]
        [StringLength (20, ErrorMessage = "Maximum length is 20")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "lütfen telefonnumaranızı boş geçmeyiniz.")]
        [StringLength(11, ErrorMessage = "Maximum length is 20")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "lütfen emailinizi boş geçmeyiniz.")]
        [StringLength(200, ErrorMessage = "Maximum length is 20")]
        public string Email { get; set; }
        [Required(ErrorMessage = "lütfen adresinizi boş geçmeyiniz.")]
        [StringLength(200, ErrorMessage = "Maximum length is 20")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "lütfen bir password giriniz.")]
        [StringLength(8, ErrorMessage = "Maximum length is 20")]
        public string Password { get; set; }

        public List<Basket> Baskets { get; set; }
    }
}
