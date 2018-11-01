﻿namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}

		// **********
		public System.Data.Entity.DbSet<User> Users { get; set; }
		// **********

		// **********
		public System.Data.Entity.DbSet<Group> Groups { get; set; }
		// **********

		protected override void OnModelCreating
			(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Configurations.Add(new User.Configuration());
			modelBuilder.Configurations.Add(new Group.Configuration());
		}
	}
}
