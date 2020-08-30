﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReactApp.Models
{
    public class FootItem
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public Decimal Price { get; set; }

        [NotMapped]
        public int Quantity { get; set; }
        [NotMapped]
        public string Comment { get; set; }

    }
}