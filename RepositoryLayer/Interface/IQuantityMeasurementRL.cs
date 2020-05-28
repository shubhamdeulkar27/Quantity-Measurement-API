using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    /// <summary>
    /// Interface For Implementing Repository Pattern.
    /// </summary>
    public interface IQuantityMeasurementRL
    {
        /// <summary>
        /// Abstract Function for Geting Specific Conversion Detail.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        QuantityModel GetQuantity(int Id);

        /// <summary>
        /// Abstract Function for Geting All Conversions Detail.
        /// </summary>
        /// <returns></returns>
        IEnumerable<QuantityModel> GetQuantities();

        /// <summary>
        /// Abstract Function for Adding Conversion Detail.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        QuantityModel Add(QuantityModel quantity);

        /// <summary>
        /// Abstract Function for Deleting Specific Conversion Detail.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        QuantityModel Delete(int Id);

        /// <summary>
        /// Abstract Function for Adding Specific Comparison Detail.
        /// </summary>
        /// <param name="comparison"></param>
        /// <returns></returns>
        ComparisonModel AddComparison(ComparisonModel comparison);

        /// <summary>
        /// Abstract Function for Geting Specific Comparison Detail.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        ComparisonModel GetComparison(int Id);

        /// <summary>
        /// Abstract Function for Geting All Comparison Detail.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ComparisonModel> GetComparisons();

        /// <summary>
        /// Abstract Function For Deleting Comparison Details.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        ComparisonModel DeleteComparison(int Id);
    }
}
