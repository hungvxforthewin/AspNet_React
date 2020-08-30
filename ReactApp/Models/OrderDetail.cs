﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReactApp.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int FootItemId { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public string Comment { get; set; }
    }
}