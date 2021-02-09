﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string City { get; set; }
    }
}
