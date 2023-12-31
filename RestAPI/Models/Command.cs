﻿using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models
{
    public class Command
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}
