﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationsApi.Application.Searches
{
    public abstract class BaseSearch
    {
        public int? Page { get; set; }
        public int? ItemsPerPage { get; set; }
        public bool? OnlyActive { get; set; }
    }
}
