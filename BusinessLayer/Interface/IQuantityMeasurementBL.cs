using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    /// <summary>
    /// Interface for Implementing Repository Pattern In Business Layer.
    /// </summary>
    public interface IQuantityMeasurementBL
    {
        /// <summary>
        /// Abstract Function For Get Specific Conversion Detail.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        QuantityModel GetQuantity(int Id);

        /// <summary>
        /// Abstract Function For Getting All Conversion Detail.
        /// </summary>
        /// <returns></returns>
        IEnumerable<QuantityModel> GetQuantities();

        /// <summary>
        /// Function to Perform Conversion.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        QuantityModel Convert(QuantityModel quantity);

        /// <summary>
        /// Function To Delete Cnversion Detail.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        QuantityModel Delete(int Id);

        /// <summary>
        /// Function to Perform Calculation For Conversion.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        decimal Calculate(QuantityModel quantity);

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

        /// <summary>
        /// Abstract Comparison.
        /// </summary>
        /// <param name="comparison"></param>
        /// <returns></returns>
        string Compare(ComparisonModel comparison);

        /// <summary>
        /// Abstract function For Base Unit Conversion Implementation.
        /// </summary>
        /// <param name="comparison"></param>
        /// <returns></returns>
        ComparisonModel ConvertToBaseUnit(ComparisonModel comparison);

        /// <summary>
        /// Abstract Function For Setting Base Unit.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        string SetBaseUnit(QuantityModel quantity);

        /// <summary>
        /// Abstract Functio For Setting Operation Type Implementation.
        /// </summary>
        /// <param name="Unit_Value"></param>
        /// <returns></returns>
        string SetOperationType(string Unit_Value);
    }
}
