﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Clases
{
    public class Historical
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HistoricalId { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        public List<Invoice> Invoices { get; } = new();

    }
}
