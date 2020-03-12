using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deltafs.WorkExperience.MiniProject.Models
{
	public class LeagueContext : DbContext
	{

		public LeagueContext(DbContextOptions<LeagueContext> options) : base(options)
		{

		}

		public DbSet<Team> Teams { get; set; }
		public DbSet<Player> Players { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

	}
}
