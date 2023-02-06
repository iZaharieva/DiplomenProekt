﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Сладкарница_Наслада.Entities
{
    public class Maker
    {
        public int Id { get; set; }
        [Required]
        public string MakerName { get; set; }

        public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
