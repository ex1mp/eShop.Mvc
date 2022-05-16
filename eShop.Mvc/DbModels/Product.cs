using eShop.Mvc.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DbModels
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Genre> Genres { get; set; }

        public Guid SystemRequirmentsId { get; set; }

        [ForeignKey(nameof(SystemRequirmentsId))]
        public SystemRequirments SystemRequirments { get; set; }

        public List<Language> Languages { get; set; }

        public string Description { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public AgeRating AgeRating { get; set; }

        public Guid DeveloperId { get; set; }

        [ForeignKey(nameof(DeveloperId))]
        public Company Developer { get; set; }

        public Guid PublisherId { get; set; }

        [ForeignKey(nameof(PublisherId))]
        public Company Publisher { get; set; }

        public Guid ImagesId { get; set; }

        [ForeignKey(nameof(ImagesId))]
        public ProductImages Images { get; set; }
    }
}
