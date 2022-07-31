﻿namespace CarDealer.DTO.Car
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using CarDealer.Models;

    [JsonObject]
    public class ImportCarDTO
    {
        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("travelledDistance")]
        public long TravelledDistance { get; set; }

        [JsonProperty("partsId")]
        public int[] PartsId { get; set; }
    }
}
