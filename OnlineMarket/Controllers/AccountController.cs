using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Account;

namespace OnlineMarket.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Register()
        {
            RegisterVM vm = new RegisterVM();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountService.Register(registerVM);
                if (result != null)
                {
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new System.Security.Claims.ClaimsPrincipal(result));
                    return RedirectToAction("Index", "Home");
                }
                return NotFound();
            }
            return View(registerVM);
        }

        public IActionResult Login() 
        {LoginVM vm = new LoginVM();
            return View(vm); 
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountService.Login(loginVM);
                if (result != null)
                {
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new System.Security.Claims.ClaimsPrincipal(result));
                    return RedirectToAction("Index", "Home");
                }
                return View(loginVM);
            }
            return View(loginVM);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM passwordVM)
        {
            if (ModelState.IsValid) 
            {
                await _accountService.ChangePassword(passwordVM);
                return RedirectToAction("Index", "Home");
            }
            return View(passwordVM);
        }
    }
}
