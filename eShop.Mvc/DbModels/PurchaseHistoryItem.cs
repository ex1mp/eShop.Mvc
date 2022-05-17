﻿using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Mvc.DbModels
{
    public class PurchaseHistoryItem
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public DateTime DateTime { get; set; }

        public int Price { get; set; }

    }
}