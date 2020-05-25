using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IQuantityMeasurementBL
    {
        QuantityModel GetQuantity(int Id);
        IEnumerable<QuantityModel> GetQuantities();
        QuantityModel Convert(QuantityModel quantity);
        QuantityModel Delete(int Id);
        decimal Calculate(QuantityModel quantity);
    }
}
