namespace Models
{
	public class User : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
		{
			public Configuration() : base()
			{
				//HasMany(current => current.Groups)
				//	.WithMany(other => other.Users)
				//	.Map(current =>
				//	{
				//		current.ToTable(tableName: "UsersInGroups");

				//		// MapRightKey را می نويسيم و بعد MapLeftKey اول
				//		// و سپس قانون دور در دور و نزديک در نزديک را رعايت می کنيم
				//		current.MapLeftKey("UserId");
				//		current.MapRightKey("GroupId");
				//	});
			}
		}
		#endregion /Configuration

		public User() : base()
		{
		}

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<Group> Groups { get; set; }
		// **********
	}
}
