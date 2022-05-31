using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DAL.Entities
{
    public class GameRating
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public int? ProductRating { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

    }
}
