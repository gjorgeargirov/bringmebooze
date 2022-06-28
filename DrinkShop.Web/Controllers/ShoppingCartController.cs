using DrinkShop.Domain.DomainModels;
using DrinkShop.Domain.DTO;
using DrinkShop.Domain.Identity;
using DrinkShop.Repository;
using DrinkShop.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DrinkShop.Web.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        public IActionResult Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return new JsonResult(this._shoppingCartService.getShoppingCartInfo(userId));
        }

        public IActionResult DeleteProductFromShoppingCart(Guid productId)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._shoppingCartService.deleteProductFromShoppingCart(userId, productId);

            if (result)
            {
                return new StatusCodeResult(200);
            }
            else
            {
                return new StatusCodeResult(400);
            }
        }

        public IActionResult OrderNow()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._shoppingCartService.orderNow(userId);

            if (result)
            {
                return new StatusCodeResult(200);
            }
            else
            {
                return new StatusCodeResult(400);
            }
        }
    }
}
