﻿using FirstAuthAPI.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FirstAuthAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]


	public class AuthenticateController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> userManager;
	}
}