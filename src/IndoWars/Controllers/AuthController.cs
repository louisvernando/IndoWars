using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoWars.Models;
using IndoWars.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IndoWars.Controllers
{
    public class AuthController : Controller
    {
        private SignInManager<DbUser> _signInManager;
        private IWarsRepository _repository;

        public AuthController(SignInManager<DbUser> signInManager,
                                IWarsRepository repository)
        {
            _signInManager = signInManager;
            _repository = repository;
        }

        [Route("/Login")]
        public IActionResult Login()
        {

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "App");
            }
            return View();
        }

        [Route("/Login")]
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel vm, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(vm.Username,
                    vm.Password,
                    true, false);
                if (signInResult.Succeeded)
                {
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return RedirectToAction("Index", "App");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("","Username or Password Incorrect");
                }
            }
            
            return View();
        }


        public async Task<ActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
            }

            return RedirectToAction("Index", "App");
        }

        [Route("/Register")]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "App");
            }

            return View();

        }

        [Route("/Register")]
        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                await _repository.RegisterAccount(vm);
            }

            return RedirectToAction("Login", "Auth");
        }
    }
}
