using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonLayer.Model
{
    public class ComparisonModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Value_One { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string Value_One_Unit { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Value_Two { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string Value_Two_Unit { get; set; }

        [Required]
        public string Result { get; set; }
    }
}
