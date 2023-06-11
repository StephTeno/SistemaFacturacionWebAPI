﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Create
{
    public class DescriptionCreateDto
    {
        public int DescriptionId { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        [Required]
        public int ProductsId { get; set; }
        [Required]
        public int Cant { get; set; }
        [Required]
        public decimal UnitePrice { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}
