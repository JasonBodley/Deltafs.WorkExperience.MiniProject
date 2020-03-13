using Deltafs.WorkExperience.MiniProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Deltafs.WorkExperience.MiniProject.Controllers
{
	public class TeamsController : Controller
	{
		private readonly LeagueContext _context;

		public TeamsController(LeagueContext context)
		{
			_context = context;
		}

		// GET: Teams
		public async Task<IActionResult> Index()
		{
			return View(await _context.Teams.ToListAsync());
		}

		// GET: Teams/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			// TODO: 7a) Run this in debug and put a breakpoint here. By default, the 'Players' list won't be populated. We need to 'Include' it.
			// _context.Teams.Include(???).FirstOrDefaultAsync(m => m.Id == id);
			// Run it in debug again and ensure the 'Players' list no has a list of player values in it.
			var team = await _context.Teams
					.FirstOrDefaultAsync(m => m.Id == id);
			if (team == null)
			{
				return NotFound();
			}

			return View(team);
		}

		// GET: Teams/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Teams/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name")] Team team)
		{
			if (ModelState.IsValid)
			{
				_context.Add(team);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(team);
		}

		// GET: Teams/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var team = await _context.Teams.FindAsync(id);
			if (team == null)
			{
				return NotFound();
			}
			return View(team);
		}

		// POST: Teams/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Team team)
		{
			if (id != team.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(team);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!TeamExists(team.Id))
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
			return View(team);
		}

		// GET: Teams/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var team = await _context.Teams
					.FirstOrDefaultAsync(m => m.Id == id);
			if (team == null)
			{
				return NotFound();
			}

			return View(team);
		}

		// POST: Teams/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var team = await _context.Teams.FindAsync(id);
			_context.Teams.Remove(team);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool TeamExists(int? id)
		{
			return _context.Teams.Any(e => e.Id == id);
		}
	}
}
