using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DAL.Entities
{
    public class SystemRequirments
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProguctId { get; set; }

        [Required]
        [ForeignKey(nameof(ProguctId))]
        public Product Proguct { get; set; }

        public string Os { get; set; }

        public string Processor { get; set; }

        public string Ram { get; set; }

        public string GraphicCard { get; set; }

        public string DiretX { get; set; }

        public string Hdd { get; set; }
    }
}
