using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pipmix.Data;
using Pipmix.Models;


namespace Pipmix.Controllers
{


	public class BrowseController : Controller
	{

		private readonly PipmixContext _context;

		public BrowseController(PipmixContext context)
		{
			_context = context;
		}


		public async Task<IActionResult> Index()
		{
			return View(await _context.GameInfos.ToListAsync());
		}


		public async Task<IActionResult> Item(int id)
		{
			var gameInfo = await _context.GameInfos.SingleOrDefaultAsync(m => m.Id == id);
			return View(gameInfo);
		}

		
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)

			{
				return NotFound();
			}

			var gameInfo = await _context.GameInfos.SingleOrDefaultAsync(m => m.Id == id);
			if (gameInfo == null)
			{
				return NotFound();
			}

			return View(gameInfo);
		}

	}


}
