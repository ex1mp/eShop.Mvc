using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DAL.Entities
{
    [Table("Catalog")]
    public class CatalogItem
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int Price { get; set; }

        public int Discount { get; set; }

        public bool IsDeleted { get; set; }
    }
}
