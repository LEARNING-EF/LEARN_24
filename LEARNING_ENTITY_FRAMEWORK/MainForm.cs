using System.Linq;

namespace LEARNING_ENTITY_FRAMEWORK
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}


		private void AddNewRecordsButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				Models.Group group1 =
					new Models.Group
					{
						Name = "Group 1",
					};

				databaseContext.Groups.Add(group1);
				// **************************************************

				// **************************************************
				Models.Group group2 =
					new Models.Group
					{
						Name = "Group 2",
					};

				databaseContext.Groups.Add(group2);
				// **************************************************

				// **************************************************
				Models.Group group3 =
					new Models.Group
					{
						Name = "Group 3",
					};

				databaseContext.Groups.Add(group3);
				// **************************************************

				// **************************************************
				Models.User user1 =
					new Models.User
					{
						Name = "User 1",
					};

				databaseContext.Users.Add(user1);
				// **************************************************

				// **************************************************
				Models.User user2 =
					new Models.User
					{
						Name = "User 2",
					};

				databaseContext.Users.Add(user2);
				// **************************************************

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void AddGroupsToUserButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				Models.User user1 =
					databaseContext.Users
					.Where(current => current.Name.ToLower() == "User 1".ToLower())
					.FirstOrDefault();

				Models.Group group1 =
					databaseContext.Groups
					.Where(current => current.Name.ToLower() == "Group 1".ToLower())
					.FirstOrDefault();

				Models.Group group2 =
					databaseContext.Groups
					.Where(current => current.Name.ToLower() == "Group 2".ToLower())
					.FirstOrDefault();
				// **************************************************

				// **************************************************
				user1.Groups.Add(group1);
				user1.Groups.Add(group2);
				// **************************************************

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void AddUsersToGroupButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				Models.Group group3 =
					databaseContext.Groups
					.Where(current => current.Name.ToLower() == "Group 3".ToLower())
					.FirstOrDefault();

				Models.User user1 =
					databaseContext.Users
					.Where(current => current.Name.ToLower() == "User 1".ToLower())
					.FirstOrDefault();

				Models.User user2 =
					databaseContext.Users
					.Where(current => current.Name.ToLower() == "User 2".ToLower())
					.FirstOrDefault();
				// **************************************************

				// **************************************************
				group3.Users.Add(user1);
				group3.Users.Add(user2);
				// **************************************************

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
