﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.EntityModels
{
    public class Header
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Avatar { get; set; }

        //public int FileId { get; set; }
        //public virtual File File { get; set; }
    }
}
