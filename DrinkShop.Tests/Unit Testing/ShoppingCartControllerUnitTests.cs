using DrinkShop.Domain.DomainModels;
using DrinkShop.Domain.DTO;
using DrinkShop.Services.Interface;
using DrinkShop.Web.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Xunit;

namespace DrinkShop.Tests.Unit_Testing
{
    public class ShoppingCartControllerUnitTests
    {
        private readonly ShoppingCartController _controller;
        private readonly IShoppingCartService _service;

        public ShoppingCartControllerUnitTests()
        {
            _service = new ShoppingCartServiceFake();
            _controller = new ShoppingCartController(_service);
            var fakeUser = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                new Claim(ClaimTypes.NameIdentifier, "test"),
                new Claim(ClaimTypes.Name, "test@mail.com")
            }, "TestAuthentication"));
            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = fakeUser
                }
            };
            _controller.ControllerContext = context;
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
        public void Index_WhenCalled_ReturnsShoppingCart()
        {
            // Act
            var JsonResult = _controller.Index() as JsonResult;
            // Assert
            var shoppingCart = Assert.IsType<ShoppingCartDTO>(JsonResult.Value);
        }

    }
}
