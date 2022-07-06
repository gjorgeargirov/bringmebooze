using DrinkShop.Web.Controllers;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Xunit;

namespace DrinkShop.Tests.Unit_Testing
{
    public class HomeControllerUnitTests
    {
        private readonly HomeController _controller;
        public ILogger<HomeController> _logger;

        public HomeControllerUnitTests()
        {
            _logger = (ILogger<HomeController>)NLog.LogManager.GetCurrentClassLogger();
            _controller = new HomeController(_logger);
        }

        [Fact]
        public void Index_WhenCalled_ReturnsView()
        {
            //Act
            var result = _controller.Index() as ViewResult;

            //Assert
            Assert.Equal("Index", result.ViewName);
        }
    }
}
