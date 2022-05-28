using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DAL.Entities
{
    [Table("Orders")]
    public class OrderItem
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Email { get; set; }

        public DateTime DateTime { get; set; }

        public Guid ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int Price { get; set; }
    }
}
