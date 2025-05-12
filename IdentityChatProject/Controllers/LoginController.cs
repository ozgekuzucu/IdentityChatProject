﻿using IdentityChatProject.Entities;
using IdentityChatProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatProject.Controllers
{
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult UserLogin()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UserLogin(LoginViewModel model)
		{
			var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Default");
			}
			return View();
		}
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("UserLogin","Login");
		}
	}
}
