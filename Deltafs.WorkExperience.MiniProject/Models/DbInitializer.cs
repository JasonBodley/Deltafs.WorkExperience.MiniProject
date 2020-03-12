using System.Linq;

namespace Deltafs.WorkExperience.MiniProject.Models
{
	public static class DbInitializer
	{
		public static void Initialize(LeagueContext context)
		{
			context.Database.EnsureCreated();

			// Look for any students.
			if (context.Teams.Any())
			{
				return;   // DB has been seeded
			}

			var wolves = new Team
			{
				Name = "Wolverhampton Wanderers"
			};

			context.Teams.Add(wolves);

			context.SaveChanges();
		}
	}
}