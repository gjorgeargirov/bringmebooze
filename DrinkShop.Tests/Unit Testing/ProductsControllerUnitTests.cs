using DrinkShop.Domain.DomainModels;
using DrinkShop.Services.Interface;
using DrinkShop.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DrinkShop.Tests.Unit_Testing
{
    public class ProductsControllerUnitTests
    {
        private readonly ProductsController _controller;
        private readonly IProductService _service;

        public ProductsControllerUnitTests()
        {
            _service = new ProductServiceFake();
            _controller = new ProductsController(_service);
        }

        [Fact]
        public void Index_WhenCalled_ReturnsJsonResult()
        {
            // Act
            var JsonResult = _controller.Index();
            // Assert
            Assert.IsType<JsonResult>(JsonResult);
        }

        [Fact]
        public void Index_WhenCalled_ReturnsAllProducts()
        {
            // Act
            var JsonResult = _controller.Index() as JsonResult;
            // Assert
            var products = Assert.IsType<List<Product>>(JsonResult.Value);
            Assert.Equal(2, products.Count);
        }

        [Fact]
        public void Details_ValidId_ReturnsJsonResult()
        {
            // Arrange
            Guid? id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200");
            // Act
            var JsonResult = _controller.Details(id);
            // Assert
            Assert.IsType<JsonResult>(JsonResult);
        }

        [Fact]
        public void Details_ValidId_ReturnsProduct()
        {
            // Arrange
            Guid? id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200");
            // Act
            var JsonResult = _controller.Details(id) as JsonResult;
            // Assert
            var product = Assert.IsType<Product>(JsonResult.Value);
            Assert.Equal(id, product.Id);
        }
    }
}
