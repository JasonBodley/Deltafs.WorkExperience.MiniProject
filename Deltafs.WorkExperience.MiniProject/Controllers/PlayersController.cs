using Deltafs.WorkExperience.MiniProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Deltafs.WorkExperience.MiniProject.Controllers
{
	public class PlayersController : Controller
	{
		private readonly LeagueContext _context;

		public PlayersController(LeagueContext context)
		{
			_context = context;
		}

		// GET: Players
		public async Task<IActionResult> Index()
		{
			return View(await _context.Players.ToListAsync());
		}

		// GET: Players/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var player = await _context.Players
					.Include(p => p.Team)
					.FirstOrDefaultAsync(m => m.Id == id);
			if (player == null)
			{
				return NotFound();
			}

			return View(player);
		}

		// GET: Players/Create
		public async Task<IActionResult> Create()
		{
			var teams = await _context.Teams.Select(t => new { t.Id, t.Name }).OrderBy(t => t.Name).ToListAsync();
			teams.Add(new { Id = 0, Name = " -- Select -- " });
			ViewBag.Teams = teams;
			return View();
		}

		// POST: Players/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		// TODO: 3a) Make sure that this is binding to the 'Position' property
		public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Number,TeamId")] Player player)
		{
			if (ModelState.IsValid)
			{
				_context.Add(player);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(player);
		}

		// GET: Players/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var player = await _context.Players.FindAsync(id);
			if (player == null)
			{
				return NotFound();
			}
			return View(player);
		}

		// POST: Players/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		// TODO: 3b) Make sure that this is binding to the 'Position' property
		public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Number")] Player player)
		{
			if (id != player.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(player);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!PlayerExists(player.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(player);
		}

		// GET: Players/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var player = await _context.Players
					.FirstOrDefaultAsync(m => m.Id == id);
			if (player == null)
			{
				return NotFound();
			}

			return View(player);
		}

		// POST: Players/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var player = await _context.Players.FindAsync(id);
			_context.Players.Remove(player);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool PlayerExists(int id)
		{
			return _context.Players.Any(e => e.Id == id);
		}
	}
}
