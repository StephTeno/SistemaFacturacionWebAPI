﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Update
{
    public class CategoriesUpdateDto
    {
        public int CategoriesId { get; set; }
        public string CategoryName { get; set; }
    }
}
