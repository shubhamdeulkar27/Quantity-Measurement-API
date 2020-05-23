using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Model
{
    /// <summary>
    /// Model Class For Quantity.
    /// </summary>
    public class QuantityModel
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string OperationType { get; set; }
        public decimal Result { get; set; }
    }
}
