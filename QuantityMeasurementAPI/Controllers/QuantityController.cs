using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuantityMeasurementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuantityController : ControllerBase
    {
        private IQuantityMeasurementBL quantityMeasurementBL;

        public QuantityController(IQuantityMeasurementBL quantityMeasurementBL)
        {
            this.quantityMeasurementBL = quantityMeasurementBL;
        }

        [HttpPost]
        public IActionResult Convert([FromBody]QuantityModel quantity)
        {
            try
            {
                QuantityModel quantity1 = quantityMeasurementBL.Convert(quantity);
                if (quantity1.Result != 0)
                {
                    return Ok(new { Success = true, Message = "Conversion Successful", Data=quantity1 });
                }
                else
                {
                    return Ok(new { Success = false, Message = "Conversion Failed", Data=quantity1 });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success=false , message=exception.Message });
            }
        }

        [HttpGet]
        public IActionResult GetQuantities()
        {
            try
            {
                IEnumerable <QuantityModel> quantities = this.quantityMeasurementBL.GetQuantities();
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
    }
}