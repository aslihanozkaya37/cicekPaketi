using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [ForeignKey("ProductId")]
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }

    }
}
