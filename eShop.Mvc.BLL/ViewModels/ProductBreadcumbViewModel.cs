using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Mvc.BLL.ViewModels
{
    public class ProductBreadcumbViewModel
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int DiscountAmount { get; set; }

        public string BreadcumbImageDataURL { get; set; }
    }
}
