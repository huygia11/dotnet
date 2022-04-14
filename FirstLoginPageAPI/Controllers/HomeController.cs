using System.Diagnostics;
using FirstLoginPageAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstLoginPageAPI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}


		public List<LoginModel> Userloginvalues()
		{
			List<LoginModel> objModel = new List<LoginModel>();
			objModel.Add(new LoginModel { UserName = "user1", UserPassword = "password1" });
			objModel.Add(new LoginModel { UserName = "user2", UserPassword = "password2" });
			objModel.Add(new LoginModel { UserName = "user3", UserPassword = "password3" });
			objModel.Add(new LoginModel { UserName = "user4", UserPassword = "password4" });
			objModel.Add(new LoginModel { UserName = "user5", UserPassword = "password5" });
			return objModel;
		}
	}
}