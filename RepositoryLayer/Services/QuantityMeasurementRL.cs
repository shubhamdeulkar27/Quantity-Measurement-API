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
            try
            {
                dBContext.Quantities.Add(quantity);
                dBContext.SaveChanges();
                return quantity;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public QuantityModel Delete(int Id)
        {
            try
            {
                QuantityModel quantity = dBContext.Quantities.Find(Id);
                if (quantity != null)
                {
                    dBContext.Quantities.Remove(quantity);
                    dBContext.SaveChanges();
                }
                return quantity;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public IEnumerable<QuantityModel> GetQuantities()
        {
            try
            {
                return dBContext.Quantities;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public QuantityModel GetQuantity(int Id)
        {
            try
            {
                QuantityModel quantity = dBContext.Quantities.Find(Id);
                return quantity;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
