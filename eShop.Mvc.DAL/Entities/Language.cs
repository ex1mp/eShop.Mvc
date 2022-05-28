using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DAL.Entities
{
    [Table("Languages")]
    public class Language
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
