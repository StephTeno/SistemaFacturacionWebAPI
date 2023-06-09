﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Base
{
    public class CategoriesDto
    {
        public int CategoriesId { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
