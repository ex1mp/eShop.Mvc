using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DAL.Entities
{
    public class ProductImages
    {
        [Key]
        public Guid Id { get; set; }

        //public Guid ProductId { get; set; }

        //[ForeignKey(nameof(ProductId))]
        //public Product Product { get; set; }

        public string CatalogImageDataURL { get; set; }

        public string ImageDataURL { get; set; }

        public string BreadcumbImageDataURL { get; set; }
    }
}