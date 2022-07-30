﻿namespace ProductShop.DTOs.Product
{
    using Newtonsoft.Json;
    using ProductShop.Common;
    using System.ComponentModel.DataAnnotations;

    [JsonObject]
    public class ImportProductDTO
    {
        [JsonProperty(nameof(Name))]
        [Required]
        [MinLength(GlobalConstants.ProductNameMinLength)]
        public string Name { get; set; }

        [JsonProperty(nameof(Price))]
        public decimal Price { get; set; }

        [JsonProperty(nameof(SellerId))]
        public int SellerId { get; set; }

        [JsonProperty(nameof(BuyerId))]
        public int? BuyerId { get; set; }
    }
}
