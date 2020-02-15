﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    [Bind(Include = "Content.UserId")]
    public class TestFormModel
    {
        [Required]
        public string Content { get; set; }
        [Required]
        public string UserId { get; set; }
        public int Age { get; set; }
        public DateTime? Time { get; set; }
    }
}