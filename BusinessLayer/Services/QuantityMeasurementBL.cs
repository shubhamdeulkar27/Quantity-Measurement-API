using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    /// <summary>
    /// Class for implementing Repository pattern in Business Layer And 
    /// Containg Business Logic.
    /// </summary>
    public class QuantityMeasurementBL : IQuantityMeasurementBL
    {
        /// <summary>
        /// Repository Layer Reference.
        /// </summary>
        private IQuantityMeasurementRL quantityMeasurementRL;

        /// <summary>
        /// Parameter Cnstructr For Setting Repositoory Layer Reference.
        /// </summary>
        /// <param name="quantityMeasurementRL"></param>
        public QuantityMeasurementBL(IQuantityMeasurementRL quantityMeasurementRL)
        {
            this.quantityMeasurementRL = quantityMeasurementRL;
        }

        /// <summary>
        /// Function To Perform Convertion.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public QuantityModel Convert(QuantityModel quantity)
        {
            try
            {
                quantity.Result = Calculate(quantity);
                if (quantity.Result > 0)
                {
                    return this.quantityMeasurementRL.Add(quantity);
                }
                return quantity;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function To Delete Conversion Details.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public QuantityModel Delete(int Id)
        {
            try
            {
                return this.quantityMeasurementRL.Delete(Id);
            }
            catch (Exception exceptioon)
            {
                throw exceptioon;
            }
        }

        /// <summary>
        /// Function TO Get All Conversion Details.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<QuantityModel> GetQuantities()
        {
            try
            {
                return this.quantityMeasurementRL.GetQuantities();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function To Get Specific Conversion Details.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public QuantityModel GetQuantity(int Id)
        {
            try
            {
                return this.quantityMeasurementRL.GetQuantity(Id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function To Perform Calculations For Conversion.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public decimal Calculate(QuantityModel quantity)
        {
            try
            {
                string operation = quantity.OperationType;
                decimal value = quantity.Value;
                decimal result= quantity.Result;
                const decimal INCH_FEET_CONSTANT = 12;
                const decimal INCH_YARD_CONSTANT = 36;
                const decimal FEET_YARD_CONSTANT = 3;
                const decimal WEIGHT_CONSTANT = 1000;
                const decimal VOLUME_CONSTANT = 1000;

                if (operation == Length.InchToFeet.ToString())
                {
                    result = value / INCH_FEET_CONSTANT;
                }
                else if (operation == Length.InchToYard.ToString())
                {
                    result = value / INCH_YARD_CONSTANT;
                }
                else if (operation == Length.FeetToInch.ToString())
                {
                    result = value * INCH_FEET_CONSTANT;
                }
                else if (operation == Length.FeetToYard.ToString())
                {
                    result = value / FEET_YARD_CONSTANT;
                }
                else if (operation == Length.YardToInch.ToString())
                {
                    result = value * INCH_YARD_CONSTANT;
                }
                else if (operation == Length.YardToFeet.ToString())
                {
                    result = value * FEET_YARD_CONSTANT;
                }
                else if (operation == Weight.GramToKilogram.ToString())
                {
                    result = value / WEIGHT_CONSTANT;
                }
                else if (operation == Weight.GramToTonne.ToString())
                {
                    result = value / (WEIGHT_CONSTANT * WEIGHT_CONSTANT);
                }
                else if (operation == Weight.KilogramToGram.ToString())
                {
                    result = value * WEIGHT_CONSTANT;
                }
                else if (operation == Weight.KilogramToTonne.ToString())
                {
                    result = value / WEIGHT_CONSTANT;
                }
                else if (operation == Weight.TonneToGram.ToString())
                {
                    result = value * (WEIGHT_CONSTANT * WEIGHT_CONSTANT);
                }
                else if (operation == Weight.TonneToKilogram.ToString())
                {
                    result = value * WEIGHT_CONSTANT;
                }
                else if (operation == Volume.MillilitreToLitre.ToString())
                {
                    result = value / VOLUME_CONSTANT;
                }
                else if (operation == Volume.LitreToMillilitre.ToString())
                {
                    result = value * VOLUME_CONSTANT;
                }
                else if (operation == Temperature.FahrenheitToCelsius.ToString())
                {
                    result = (value - 32) * 5 / 9;
                }
                else if (operation == Temperature.CelsiusToFahrenheit.ToString())
                {
                    result = (value * 9 / 5) + 32;
                }
                return Math.Round(result,2);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function To Add Comparison.
        /// </summary>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public ComparisonModel AddComparison(ComparisonModel comparison)
        {
            try
            {
                comparison.Result = Compare(comparison);
                if (comparison.Result != null)
                {
                    return this.quantityMeasurementRL.AddComparison(comparison);
                }
                return comparison;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function To Get Specific Comparison Detail.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ComparisonModel GetComparison(int Id)
        {
            try
            {
                return this.quantityMeasurementRL.GetComparison(Id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function To Get All Comparison Details.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ComparisonModel> GetComparisons()
        {
            try
            {
                return this.quantityMeasurementRL.GetComparisons();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function To Delete Comparison Details.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ComparisonModel DeleteComparison(int Id)
        {
            try
            {
                return this.quantityMeasurementRL.DeleteComparison(Id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function To Perform Comparison.
        /// </summary>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public string Compare(ComparisonModel comparison)
        {
            try
            {
                ComparisonModel comparison1 = new ComparisonModel();
                comparison1.Value_One = comparison.Value_One;
                comparison1.Value_One_Unit = comparison.Value_One_Unit;
                comparison1.Value_Two = comparison.Value_Two;
                comparison1.Value_Two_Unit = comparison.Value_Two_Unit;
                comparison1 = ConvertToBaseUnit(comparison1);

                string result = "";

                if (comparison1.Value_One_Unit == Unit.Inch.ToString() && comparison1.Value_Two_Unit == Unit.Inch.ToString()
                    || comparison1.Value_One_Unit == Unit.Gram.ToString() && comparison1.Value_Two_Unit == Unit.Gram.ToString()
                    || comparison1.Value_One_Unit == Unit.Millilitre.ToString() && comparison1.Value_Two_Unit == Unit.Millilitre.ToString()
                    || comparison1.Value_One_Unit == Unit.Fahreneit.ToString() && comparison1.Value_Two_Unit == Unit.Fahreneit.ToString())
                {
                    if (comparison1.Value_One == comparison1.Value_Two)
                    {
                        result = "Equal";
                    }
                    else if (comparison1.Value_One > comparison1.Value_Two)
                    {
                        result = $"{comparison.Value_One} Is Greater Than {comparison.Value_Two}";
                    }
                    else if (comparison1.Value_One < comparison1.Value_Two)
                    {
                        result = $"{comparison.Value_One} Is Less Than {comparison.Value_Two}";
                    }
                }
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function For Converting To Base Unit.
        /// </summary>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public ComparisonModel ConvertToBaseUnit(ComparisonModel comparison)
        {
            try
            {
                if (comparison.Value_One_Unit==Unit.Inch.ToString() && comparison.Value_Two_Unit==Unit.Inch.ToString()
                    || comparison.Value_One_Unit == Unit.Gram.ToString() && comparison.Value_Two_Unit == Unit.Gram.ToString()
                    || comparison.Value_One_Unit == Unit.Millilitre.ToString() && comparison.Value_Two_Unit == Unit.Millilitre.ToString()
                    || comparison.Value_One_Unit == Unit.Fahreneit.ToString() && comparison.Value_Two_Unit == Unit.Fahreneit.ToString())
                {
                    return comparison;
                }
                QuantityModel quantityOne = new QuantityModel();
                QuantityModel quantityTwo = new QuantityModel();
                quantityOne.Value = comparison.Value_One;
                quantityTwo.Value = comparison.Value_Two;

                quantityOne.OperationType = SetOperationType(comparison.Value_One_Unit);
                quantityTwo.OperationType = SetOperationType(comparison.Value_Two_Unit);

                quantityOne.Result = Calculate(quantityOne);
                quantityTwo.Result = Calculate(quantityTwo);

                comparison.Value_One = quantityOne.Result;
                comparison.Value_Two = quantityTwo.Result;

                comparison.Value_One_Unit = SetBaseUnit(quantityOne);
                comparison.Value_Two_Unit = SetBaseUnit(quantityTwo);

                return comparison;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Function For Setting Base Unit.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public string SetBaseUnit(QuantityModel quantity)
        {
            try
            {
                if (quantity.OperationType == Length.FeetToInch.ToString()
                    || quantity.OperationType == Length.YardToInch.ToString())
                {
                    return "Inch";
                }
                else if (quantity.OperationType == Weight.KilogramToGram.ToString()
                    || quantity.OperationType == Weight.TonneToGram.ToString())
                {
                    return "Gram";
                }
                else if (quantity.OperationType == Volume.LitreToMillilitre.ToString())
                {
                    return "Millilitre";
                }
                else if (quantity.OperationType == Temperature.CelsiusToFahrenheit.ToString())
                {
                    return "Fahrenheit";
                }
                return "Invalid";
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Functin Fr Setting peratin type For Base Unit Cnversion.
        /// </summary>
        /// <param name="Unit_Value"></param>
        /// <returns></returns>
        public string SetOperationType(string Unit_Value)
        {
            try
            {
                string operationType = "";
                if (Unit_Value == Unit.Feet.ToString())
                {
                    operationType = "FeetToInch";
                }
                else if (Unit_Value == Unit.Yard.ToString())
                {
                    operationType = "YardToInch";
                }
                else if (Unit_Value == Unit.Kilogram.ToString())
                {
                    operationType = "KilogramToGram";
                }
                else if (Unit_Value == Unit.Tonne.ToString())
                {
                    operationType = "TonneToGram";
                }
                else if (Unit_Value == Unit.Litre.ToString())
                {
                    operationType = "LitreToMillilitre";
                }
                else if (Unit_Value == Unit.Celsius.ToString())
                {
                    operationType = "CelsiusToFahrenheit";
                }
                return operationType;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
