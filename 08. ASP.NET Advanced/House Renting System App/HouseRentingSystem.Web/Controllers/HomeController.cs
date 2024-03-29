﻿using HouseRentingSystem.Services.Houses;
using Microsoft.AspNetCore.Mvc;
using static HouseRentingSystem.Services.Data.DataConstants.AdminConstants;

namespace HouseRentingSystem.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly IHouseService houseService;

		public HomeController(IHouseService houseService)
			=> this.houseService = houseService;

		public IActionResult Index()
		{
			if (User.IsInRole(AdminRoleName))
				return RedirectToAction("Index", "Home", new { area = "Admin" });

			return View(houseService.LastThreeHouses());
		}

		public IActionResult Error(int statusCode)
		{
			if (statusCode == 400)
				return View("Error400");

			if (statusCode == 401)
				return View("Error401");

			return View();
		}
	}
}