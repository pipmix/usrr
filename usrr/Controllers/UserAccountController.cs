using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pipmix.Data;

namespace Pipmix.Controllers
{
	

    public class UserAccountController : Controller
    {

		//private IUserAccount _userAccount;

		//public UserAccountController(IUserAccount userAcounts)
		//{
		//	_userAccount = userAcounts;
		//}


		public IActionResult Index()
        {
            return View();
        }
    }
}