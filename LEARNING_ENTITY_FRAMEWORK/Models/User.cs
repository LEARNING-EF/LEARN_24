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
