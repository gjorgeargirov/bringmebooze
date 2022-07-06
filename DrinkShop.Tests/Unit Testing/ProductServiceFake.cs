using DrinkShop.Domain.DomainModels;
using DrinkShop.Domain.DTO;
using DrinkShop.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DrinkShop.Tests.Unit_Testing
{
    public class ProductServiceFake: IProductService
    {
        private readonly List<Product> _products;
        private readonly ShoppingCart _cart;
        public ProductServiceFake()
        {
            _products = new List<Product>()
            {
                new Product() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"), ProductName = "Wine", ProductImage = "wineimageurl", ProductDescription = "Wine Description", Price = 500},
                new Product() { Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"), ProductName = "Beer", ProductImage = "beerimageurl", ProductDescription = "Beer Description", Price = 200}
            };

            _cart = new ShoppingCart()
            {
                Id = new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
                OwnerId = "123"
            };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetDetailsForProduct(Guid? id)
        {
            return _products.Where(a => a.Id == id).FirstOrDefault();
        }

        public void CreateNewProduct(Product p)
        {
            p.Id = Guid.NewGuid();
            _products.Add(p);
        }

        public void UpdateExistingProduct(Product p)
        {
            p.ProductDescription = "Updated Description";
        }

        public void DeleteProduct(Guid? id)
        {
            var existing = _products.First(a => a.Id == id);
            _products.Remove(existing);
        }

        public AddToShoppingCartDto GetShoppingCartInfo(Guid? id)
        {
            var product = _products.Where(a => a.Id == id).FirstOrDefault();

            AddToShoppingCartDto model = new AddToShoppingCartDto
            {
                SelectedProduct = product,
                ProductId = product.Id,
                Quantity = 1
            };

            return model;
        }

        public bool AddToShoppingCart(AddToShoppingCartDto item, string userID)
        {
            if (item.ProductId != null && !_cart.OwnerId.Equals(userID))
            {
                var product = _products.Where(a => a.Id == item.ProductId).FirstOrDefault(); ;
                if (product != null)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
