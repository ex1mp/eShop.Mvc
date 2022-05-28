using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DAL.Entities
{
    [Table("ProductKeys")]
    public class ProductKey
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public string KeyOfProduct { get; set; }

        public bool IsSold { get; set; }
    }
}
