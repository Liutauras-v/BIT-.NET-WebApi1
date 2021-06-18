﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiApp.Entities
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public bool Deleted { get; set; } = false;
    }
}
