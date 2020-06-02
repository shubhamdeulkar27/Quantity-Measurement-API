using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer.Exceptions;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace QuantityMeasurementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuantityController : ControllerBase
    {
        //Business Layer Reference.
        private IQuantityMeasurementBL quantityMeasurementBL;

        /// <summary>
        /// Parameter Cnstrcutor For Setting Business Layer Reference.
        /// </summary>
        /// <param name="quantityMeasurementBL"></param>
        public QuantityController(IQuantityMeasurementBL quantityMeasurementBL)
        {
            this.quantityMeasurementBL = quantityMeasurementBL;
        }

        /// <summary>
        /// Function For Handlling Request For Conversion.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Convert([FromBody]QuantityModel quantity)
        {
            try
            {
                //Throw Custom Exception For Null Field.
                if (quantity == null)
                {
                    return BadRequest(new { Success = false, message = QuantityException.ExceptionType.NULL_FIELD_EXCEPTION });
                }
                
                //Calling Convert Function Of BL.
                QuantityModel quantity1 = quantityMeasurementBL.Convert(quantity);

                //Returning Response.
                if (quantity1.Result != 0)
                {
                    return Ok(new { Success = true, Message = "Conversion Successful", Data = quantity1 });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Conversion Failed", Data = quantity1 });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        /// <summary>
        /// Function To Handle Get All Conversions Request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetQuantities()
        {
            try
            {
                //Calling GetQuantity Of BL.
                IEnumerable <QuantityModel> quantities = this.quantityMeasurementBL.GetQuantities();

                //Returning Response.
                if (quantities != null)
                {
                    return Ok(new { Success = true, Message = "Conversions Data Fetched Successfully", Data = quantities });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Conversions Data Fetched Failed", Data = quantities });

                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success=false, message=exception.Message});
            }
        }

        /// <summary>
        /// Function to Hnadle Specific Get Request.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public IActionResult GetQuantity([FromRoute]int Id)
        {
            try
            {
                //Throw Custom Exception For Invalid Id Field.
                if (Id <= 0)
                {
                    return BadRequest(new { Success = false, Message = QuantityException.ExceptionType.INVALID_FIELD_EXCEPTION });
                }

                //Calling GetQuantity From BL.
                QuantityModel quantity = this.quantityMeasurementBL.GetQuantity(Id);
                
                //Returning Response.
                if (quantity != null)
                {
                    return Ok(new { Success = true, Message = "Conversion Data Fetched Successfully", Data = quantity });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Conversion Data Fetched Failed", Data = quantity });

                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        /// <summary>
        /// Function To Handle Delete Comparison Request.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute]int Id)
        {
            try
            {
                //Throw Custom Exception For Invalid Id Field.
                if (Id<=0)
                {
                    return BadRequest(new { Success = false, Message = QuantityException.ExceptionType.INVALID_FIELD_EXCEPTION });
                }

                //Calling Delete From BL For Deletinng Conversion Detail.
                QuantityModel quantity = this.quantityMeasurementBL.Delete(Id);

                //Returning Response.
                if (quantity != null)
                {
                    return Ok(new { Success = true, Message = "Data Deleted Successfully", Data = quantity });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Data Deletion Failed", Data = quantity });

                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success=false,Message=exception.Message });
            }
        }

        /// <summary>
        /// Function To Handle Compare Request.
        /// </summary>
        /// <param name="comparison"></param>
        /// <returns></returns>
        [HttpPost("compare")]
        public IActionResult Compare([FromBody]ComparisonModel comparison)
        {
            try
            {
                //Throw Custom Exception For Null Field.
                if (comparison == null)
                {
                    return BadRequest(new { Success = false, message = QuantityException.ExceptionType.NULL_FIELD_EXCEPTION });
                }

                //Calling Add Comparison From BL.
                ComparisonModel comparison1 = quantityMeasurementBL.AddComparison(comparison);

                //Returning Response.
                if (comparison.Result != null)
                {
                    return Ok(new { Success = true, Message = "Comparison Successful", Data = comparison1 });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Comparison Failed", Data = comparison1 });
                }
            }            
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        /// <summary>
        /// Function To Handle Get All Comparisons Request.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getcomparisons")]
        public IActionResult GetComparisons()
        {
            try
            {
                //Calling GetComparisons From BL To Get All Comparisons Details.
                IEnumerable<ComparisonModel> comparisons = this.quantityMeasurementBL.GetComparisons();

                //Returning Response.
                if (comparisons != null)
                {
                    return Ok(new { Success = true, Message = "Comparisons Data Fetched Successfully", Data = comparisons });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Conversions Data Fetched Failed", Data = comparisons });

                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        /// <summary>
        /// Function To Handle Get Comparison Request.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("getcomparison/{Id}")]
        public IActionResult GetComparison([FromRoute]int Id)
        {
            try
            {
                //Throw Custom Exception For Invalid Id Field.
                if (Id <= 0)
                {
                    return BadRequest(new { Success = false, message = QuantityException.ExceptionType.INVALID_FIELD_EXCEPTION });
                }

                //Calling GetCompariosn From BL For Getting Specific Comparison Detail.
                ComparisonModel comparison = this.quantityMeasurementBL.GetComparison(Id);

                //Returning Response.
                if (comparison != null)
                {
                    return Ok(new { Success = true, Message = "Comparisons Data Fetched Successfully", Data = comparison });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Conversions Data Fetched Failed", Data = comparison });

                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        /// <summary>
        /// Function To Handle Delete Comparison Request.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("deletecomparison/{Id}")]
        public IActionResult DeleteComparison([FromRoute]int Id)
        {
            try
            {
                //Throw Custom Exception For Invalid Id Field.
                if (Id <= 0)
                {
                    return BadRequest(new { Success = false, Message = QuantityException.ExceptionType.INVALID_FIELD_EXCEPTION });
                }

                //Calling DeleteCmparison From BL.
                ComparisonModel comparison = this.quantityMeasurementBL.DeleteComparison(Id);

                //Returning Response.
                if (comparison != null)
                {
                    return Ok(new { Success = true, Message = "Comparisons Data Deleted Successfully", Data = comparison });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Conversions Data Deletion Failed", Data = comparison });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }
    }
}