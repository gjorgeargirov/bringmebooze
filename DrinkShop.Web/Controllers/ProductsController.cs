using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using DrinkShop.Services.Interface;
using DrinkShop.Domain.DomainModels;
using DrinkShop.Domain.DTO;

namespace DrinkShop.Web.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Products
        public JsonResult Index()
        {
            var allProducts = this._productService.GetAllProducts();
            return new JsonResult(allProducts);
        }

        [HttpPost]
        public ActionResult AddProductToCart([Bind("ProductId","Quantity")] AddToShoppingCartDto item)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = this._productService.AddToShoppingCart(item, userId);

            if (result)
            {
                return new StatusCodeResult(201);
            }

            return new StatusCodeResult(400);
        }

        // GET: Products/Details/5
        public JsonResult Details(Guid? id)
        {
            if (id == null)
            {
                Response.StatusCode = 400;
                return new JsonResult("");
            }

            var product = this._productService.GetDetailsForProduct(id);
            if (product == null)
            {
                Response.StatusCode = 400;
                return new JsonResult("");
            }

            return new JsonResult(product);
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create([Bind("Id,ProductName,ProductImage,ProductDescription,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = Guid.NewGuid();
                this._productService.CreateNewProduct(product);
                return new StatusCodeResult(201);
            }
            Response.StatusCode = 400;
            return new JsonResult("Missing information!");
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Edit(Guid id, [Bind("Id,ProductName,ProductImage,ProductDescription,Price")] Product product)
        {
            if (id != product.Id)
            {
                Response.StatusCode = 400;
                return new JsonResult("Not found");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._productService.UpdateExistingProduct(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                        Response.StatusCode = 400;
                        return new JsonResult("Not found");
                }
                return new StatusCodeResult(201);
            }
            Response.StatusCode = 400;
            return new JsonResult("Missing information!");
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            if (id == null)
            {
                Response.StatusCode = 400;
                return new JsonResult("Not found");
            }

            var product = this._productService.GetDetailsForProduct(id);
            if (product == null)
            {
                Response.StatusCode = 400;
                return new JsonResult("Not found");
            }
            this._productService.DeleteProduct(id);
            return new StatusCodeResult(200);
        }

        private bool ProductExists(Guid id)
        {
            return this._productService.GetDetailsForProduct(id) != null;
        }
    }
}
