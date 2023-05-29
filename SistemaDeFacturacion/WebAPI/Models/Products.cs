﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductsId { get; set; }
        public int CategoriesId { get; set; }
        [Required]
        [Column("NombreDelProducto")]
        public string Name { get; set; }
        [Required]
        [Column("PrecioUnitario")]
        public decimal UnitPrice { get; set; }
        public int DescriptionId { get; set; }
        public Description Description { get; set; } = null!;
    }
}
