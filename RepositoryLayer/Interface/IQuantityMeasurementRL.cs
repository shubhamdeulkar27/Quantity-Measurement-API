using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IQuantityMeasurementRL
    {
        QuantityModel GetQuantity(int Id);
        IEnumerable<QuantityModel> GetQuantities();
        QuantityModel Add(QuantityModel quantity);
        QuantityModel Delete(int Id);
    }
}
