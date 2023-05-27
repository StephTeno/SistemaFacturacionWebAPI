﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Historical
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HistoricalId { get; set; }
        public ICollection<Invoice> Invoices { get; } = new List<Invoice>();

    }
}
