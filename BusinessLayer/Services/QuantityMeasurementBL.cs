using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class QuantityMeasurementBL : IQuantityMeasurementBL
    {
        private IQuantityMeasurementRL quantityMeasurementRL;

        public QuantityMeasurementBL(IQuantityMeasurementRL quantityMeasurementRL)
        {
            this.quantityMeasurementRL = quantityMeasurementRL;
        }

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

        public decimal Calculate(QuantityModel quantity)
        {
            try
            {
                string operation = quantity.OperationType;
                decimal value = quantity.Value;
                decimal result= quantity.Result;
                const decimal INCH_TO_FEET = 12;
                const decimal INCH_TO_YARD = 36;
                const decimal FEET_TO_INCH = 12;
                const decimal FEET_TO_YARD = 3;
                const decimal YARD_TO_INCH = 36;
                const decimal YARD_TO_FEET = 3;
                const decimal WEIGHT_CONSTANT = 1000;
                const decimal VOLUME_CONSTANT = 1000;

                if (operation == Length.InchToFeet.ToString())
                {
                    result = value / INCH_TO_FEET;
                }
                else if (operation == Length.InchToYard.ToString())
                {
                    result = value / INCH_TO_YARD;
                }
                else if (operation == Length.FeetToInch.ToString())
                {
                    result = value * FEET_TO_INCH;
                }
                else if (operation == Length.FeetToYard.ToString())
                {
                    result = value / FEET_TO_YARD;
                }
                else if (operation == Length.YardToInch.ToString())
                {
                    result = value * YARD_TO_INCH;
                }
                else if (operation == Length.YardToFeet.ToString())
                {
                    result = value * YARD_TO_FEET;
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
    }
}
