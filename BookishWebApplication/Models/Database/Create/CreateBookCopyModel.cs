﻿using System.ComponentModel.DataAnnotations;

namespace BookishWebApplication.Models.Database.Create
{
    public class CreateBookCopyModel
    {
        [Required]
        public int BookId { get; set; }

    }
}