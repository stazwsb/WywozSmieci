﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WywozSmieci.Model
{
    public class Rejon
    {
        [Key]
        public int Id { get; set; }
        public string Miejsce { get; set; }
    }
}
