﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationsApi.Application.Dto.CountryStats
{
    public class GetCountryStatDto
    {
        public int Year { get; set; }
        public int CountryId { get; set; }
        public int Population { get; set; }
        public decimal Gdp { get; set; }
    }
}
