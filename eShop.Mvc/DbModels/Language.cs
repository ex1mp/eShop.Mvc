using System.ComponentModel.DataAnnotations;

namespace eShop.Mvc.DbModels
{
    public class Language
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
