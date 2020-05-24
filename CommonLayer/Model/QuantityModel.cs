﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommonLayer.Model
{
    /// <summary>
    /// Model Class For Quantity.
    /// </summary>
    public class QuantityModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="decimal(18,2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Value { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string OperationType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Result { get; set; }
    }
}
