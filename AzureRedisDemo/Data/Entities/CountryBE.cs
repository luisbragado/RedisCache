﻿using System;

namespace AzureRedisDemo.Data.Entities
{
    [Serializable]
    public class CountryBE
    {
        public int IdCountry { get; set; }
        public string IsoCode { get; set; }
        public string Description { get; set; }

    }
}
