namespace Models
{
	public class Group : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Group>
		{
			public Configuration() : base()
			{
				HasMany(current => current.Users)
					.WithMany(other => other.Groups)
					.Map(current =>
					{
						current.ToTable(tableName: "UsersInGroups");

						// MapRightKey را می نويسيم و بعد MapLeftKey اول
						// و سپس قانون دور در دور و نزديک در نزديک را رعايت می کنيم
						current.MapLeftKey("GroupId");
						current.MapRightKey("UserId");
					});
			}
		}
		#endregion /Configuration

		public Group() : base()
		{
		}

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<User> Users { get; set; }
		// **********
	}
}
