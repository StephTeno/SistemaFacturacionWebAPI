﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Update
{
    public class HistoricalUpdateDto
    {
        public int HistoricalId { get; set; }
        [Required]
        public int InvoiceId { get; set; }
    }
}
