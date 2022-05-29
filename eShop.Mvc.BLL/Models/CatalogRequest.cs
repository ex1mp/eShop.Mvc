namespace eShop.Mvc.BLL.Models
{
    public class CatalogRequest
    {
        public string GameName { get; set; }

        public string Genre { get; set; }

        public int MinSum { get; set; }

        public int MaxSum { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }

        public int? PageNumber { get; set; }

        public bool? IsNewSearch { get; set; }
    }
}
