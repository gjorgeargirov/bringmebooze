using DrinkShop.Domain.DomainModels;
using DrinkShop.Domain.DTO;
using DrinkShop.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkShop.Tests.Unit_Testing
{
    public class ShoppingCartServiceFake : IShoppingCartService
    {
        private readonly List<ProductInShoppingCart> _shoppingCart;
        public ShoppingCartServiceFake()
        {
            _shoppingCart = new List<ProductInShoppingCart>()
            {
                new ProductInShoppingCart() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"), Quantity = 1},
                new ProductInShoppingCart() { Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"), Quantity = 1}
            };
        }

        public bool deleteProductFromShoppingCart(string userId, Guid id)
        {
            if (!string.IsNullOrEmpty(userId) && id != null)
            {
                return true;
            }
            var product = _shoppingCart.Where(a => a.Id == id).FirstOrDefault();
            _shoppingCart.Remove(product);
            return false;
        }

        public ShoppingCartDTO getShoppingCartInfo(string userId)
        {
            var totalPrice = _shoppingCart.Count * 100;
            ShoppingCartDTO scDto = new ShoppingCartDTO
            {
                ProductInShoppingCarts = _shoppingCart,
                TotalPrice = totalPrice
            };
            return scDto;
        }

        public bool orderNow(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                foreach (ProductInShoppingCart p in _shoppingCart)
                {
                    _shoppingCart.Remove(p);
                }
                return true;
            }
            return false;
        }
    }
}
