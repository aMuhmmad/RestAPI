﻿using System.ComponentModel.DataAnnotations;

namespace RestAPI.DTOs
{
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(200)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }

    }
}
