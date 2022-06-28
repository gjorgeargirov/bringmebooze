using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DrinkShop.Domain.Identity;
using DrinkShop.Domain.DomainModels;

namespace EShop.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<DrinkShopApplicationUser> userManager;
        private readonly SignInManager<DrinkShopApplicationUser> signInManager;
        public AccountController(UserManager<DrinkShopApplicationUser> userManager, SignInManager<DrinkShopApplicationUser> signInManager)
        {

            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Register(UserRegistrationDto request)
        {
            if (ModelState.IsValid)
            {
                var userCheck = await userManager.FindByEmailAsync(request.Email);
                if (userCheck == null)
                {
                    var user = new DrinkShopApplicationUser
                    {
                        UserName = request.Email,
                        NormalizedUserName = request.Email,
                        Email = request.Email,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        UserCart = new ShoppingCart()
                    };
                    var result = await userManager.CreateAsync(user, request.Password);
                    if (result.Succeeded)
                    {
                        return new StatusCodeResult(200);
                    }
                    else
                    {
                        return StatusCode(400, "Bad request!");
                    }
                }
                else
                {
                    return StatusCode(400, "User exists!");
                }
            }
            return StatusCode(400, "Missing information!");
        }

        [HttpPost,AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null && !user.EmailConfirmed)
                {
                    return StatusCode(400, "Email not confirmed yet");

                }
                if (await userManager.CheckPasswordAsync(user, model.Password) == false)
                {
                    return StatusCode(400, "Invalid credentials");

                }

                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, true);

                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(user, new Claim("UserRole", "User"));
                    return new StatusCodeResult(200);
                }
                else if (result.IsLockedOut)
                {
                    return StatusCode(400, "AccountLocked");
                }
                else
                {
                    return StatusCode(400, "Invalid login attempt");
                }
            }
            return StatusCode(400, "Missing information!");
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return new StatusCodeResult(200);
        }
    }
}