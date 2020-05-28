using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services
{
    /// <summary>
    /// Class Implementing Repository Pattern And Entity Frameork Core.
    /// </summary>
    public class QuantityMeasurementRL : IQuantityMeasurementRL
    {
        //DBContext Refernce.
        private QuantityDBContext dBContext;

        /// <summary>
        /// Parameter Constructor For Seting DbContext Reference by DI.
        /// </summary>
        /// <param name="dBContext"></param>
        public QuantityMeasurementRL(QuantityDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        /// <summary>
        /// Function to Add Conversion Detail to Database.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Function to Delete Specific Data From DataBase.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Function To Get All Convserion Details.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Function to get Specific Conversion Detail.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Function To Add Comparison Detail to Database.
        /// </summary>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public ComparisonModel AddComparison(ComparisonModel comparison)
        {
            try
            {
                dBContext.Comparisons.Add(comparison);
                dBContext.SaveChanges();
                return comparison;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function to get Sppecific Comparison Details.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ComparisonModel GetComparison(int Id)
        {
            try
            {
                ComparisonModel comparison = dBContext.Comparisons.Find(Id);
                return comparison;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function to Get All Comparison Details.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ComparisonModel> GetComparisons()
        {
            try
            {
                return dBContext.Comparisons;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Functionn To Delete  Specific Comparison Detail.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ComparisonModel DeleteComparison(int Id)
        {
            try
            {
                ComparisonModel comparison = dBContext.Comparisons.Find(Id);
                if (comparison != null)
                {
                    dBContext.Comparisons.Remove(comparison);
                    dBContext.SaveChanges();
                }
                return comparison;
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }
    }
}
