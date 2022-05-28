using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DAL.Entities
{
    [Table("Companys")]
    public class Company
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
