using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;
using QuantityMeasurementAPI.Controllers;
using System;
using Xunit;


namespace QuantityMeasuremetXUnitTests
{
    /// <summary>
    /// Class For Test Cases.
    /// </summary>
    public class QunatityMeasurementTests
    {
        //QauntityController reference.
        QuantityController controller;

        // Creating a mock reference for Business Layer.
        private readonly Mock<IQuantityMeasurementBL> mock;

        //Constructor for Providing mock and controller instances.
        public QunatityMeasurementTests()
        {
            mock = new Mock<IQuantityMeasurementBL>();
            controller = new QuantityController(mock.Object);
        }

        /// <summary>
        /// Test Case For Checking GetQuantities Function.
        /// </summary>
        [Fact]
        public void GetQuantitiesCalledShouldReturnOkResult()
        {
            //Calling The GetQuantites Function.
            var OkResult = controller.GetQuantities();

            //Asserting Values.
            Assert.IsType<OkObjectResult>(OkResult);
        }

        /// <summary>
        /// Test Case For Invalid Quantity Model Should Return Bad Request.
        /// </summary>
        [Fact]
        public void InvalidObjectShouldReturnBadRequest()
        {
            //Creating Model Object.
            var data = new QuantityModel()
            {
                Value = 10,
                OperationType = ""
            };

            controller.ModelState.AddModelError("OperationType", "Required");

            //Calling Convert Funtion.
            var badResponse = controller.Convert(data);

            //Asserting Values.
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }

        /// <summary>
        /// Test Case Calling GetQuantity By Id Should Returm OkResult.
        /// </summary>
        [Fact]
        public void GetQuantityByIdShouldReturnOk()
        {
            //Calling GetQuantity By Id Function.
            var OkResult = controller.GetQuantity(15);

            //Asserting Values.
            Assert.IsType<OkObjectResult>(OkResult);
        }

        /// <summary>
        /// Test Case Calling GetQuantity By Invalid Id Should Return BadRequest.
        /// </summary>
        [Fact]
        public void GetQuantityByInvalidIdShouldBadResult()
        {
            //Calling GetQuantity By Id Function.
            var Result = controller.GetQuantity(-15);

            //Asserting Values.
            Assert.IsType<BadRequestObjectResult>(Result);
        }

        /// <summary>
        /// Test Case For Delete Function.
        /// </summary>
        [Fact]
        public void DeletingQauntityByIdShouldReturnOkResult()
        {
            //Calling Delete Function.
            var OkResult = controller.Delete(15);

            //Asserting Values.
            Assert.IsType<OkObjectResult>(OkResult);
        }

        /// <summary>
        /// Test Case For Delete Function With Invalid Id.
        /// </summary>
        [Fact]
        public void DeletingQauntityByInvalidIdShouldReturnBadRequest()
        {
            //Calling Delete Function.
            var Result = controller.Delete(-19);

            //Asserting Values.
            Assert.IsType<BadRequestObjectResult>(Result);
        }

        /// <summary>
        /// Test Case For GetComparisons Function.
        /// </summary>
        [Fact]
        public void WhenGetComparisonsCalledShouldReturnOkResult()
        {
            //Calling GetComparisons To Get Comparisosns Details.
            var OkResult = controller.GetComparisons();

            //Asserting Values.
            Assert.IsType<OkObjectResult>(OkResult);
        }

        /// <summary>
        /// Test Case For GetComparison Function.
        /// </summary>
        [Fact]
        public void WhenGetComparisonCalledShouldReturnOkResult()
        {
            //Calling GetComparison to Get Specific Comparison Details.
            var OkResult = controller.GetComparison(15);

            //Assserting Values.
            Assert.IsType<OkObjectResult>(OkResult);
        }

        /// <summary>
        /// Test Case For GetComparison Function With Invalid Id.
        /// </summary>
        [Fact]
        public void WhenGetComparisonWithInvalidIdCalledShouldReturnBadRequest()
        {
            //Calling GetComparison to Get Specific Comparison Details.
            var Result = controller.GetComparison(-22);

            //Assserting Values.
            Assert.IsType<BadRequestObjectResult>(Result);
        }

        /// <summary>
        /// Test CAse For Compare Function With Invalid Data.
        /// </summary>
        [Fact]
        public void InvalidObjectPassedToCompareShouldReturnBadRequesst()
        {
            //Creating Commparison Model.
            ComparisonModel model = new ComparisonModel()
            {
                Id = 1,
                Value_One = 5,
                Value_One_Unit = "Inch",
                Value_Two = 5,
                Value_Two_Unit = "",
                Result = ""
            };

            //Calling Compare Function.
            var BadResult = controller.Compare(model);

            //Asserting Values.
            Assert.IsType<BadRequestObjectResult>(BadResult);
        }

        /// <summary>
        /// Test Case For DeleteComparison Function.
        /// </summary>
        [Fact]
        public void WheneDeleteComparisonCalledShouldReturnOkResul()
        {
            //Calling DeleteComparison Function.
            var OkResult = controller.DeleteComparison(25);

            //Asserting Values.
            Assert.IsType<OkObjectResult>(OkResult);
        }

        /// <summary>
        /// Test Case For DeleteComparison Function With Invalid Id.
        /// </summary>
        [Fact]
        public void WheneDeleteComparisonCalledWithInvalidIdShouldReturnBadRequest()
        {
            //Calling DeleteComparison Function.
            var Result = controller.DeleteComparison(-25);

            //Asserting Values.
            Assert.IsType<BadRequestObjectResult>(Result);
        }
    }
}
