using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services
{
    public class QuantityMeasurementRL : IQuantityMeasurementRL
    {
        private QuantityDBContext dBContext;

        public QuantityMeasurementRL(QuantityDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public QuantityModel Add(QuantityModel quantity)
        {
            dBContext.Quantities.Add(quantity);
            dBContext.SaveChanges();
            return quantity;
        }

        public QuantityModel Delete(int Id)
        {
            QuantityModel quantity = dBContext.Quantities.Find(Id);
            if (quantity != null)
            {
                dBContext.Quantities.Remove(quantity);
                dBContext.SaveChanges();
            }
            return quantity;
        }

        public IEnumerable<QuantityModel> GetQuantities()
        {
            return dBContext.Quantities;
        }

        public QuantityModel GetQuantity(int Id)
        {
            QuantityModel quantity = dBContext.Quantities.Find(Id);
            return quantity;
        }
    }
}
