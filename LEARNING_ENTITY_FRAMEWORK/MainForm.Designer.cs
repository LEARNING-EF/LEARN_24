namespace LEARNING_ENTITY_FRAMEWORK
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.addNewRecordsButton = new System.Windows.Forms.Button();
			this.addGroupsToUserButton = new System.Windows.Forms.Button();
			this.addUsersToGroupButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addNewRecordsButton
			// 
			this.addNewRecordsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addNewRecordsButton.Location = new System.Drawing.Point(12, 12);
			this.addNewRecordsButton.Name = "addNewRecordsButton";
			this.addNewRecordsButton.Size = new System.Drawing.Size(311, 23);
			this.addNewRecordsButton.TabIndex = 0;
			this.addNewRecordsButton.Text = "Add New Records";
			this.addNewRecordsButton.UseVisualStyleBackColor = true;
			this.addNewRecordsButton.Click += new System.EventHandler(this.AddNewRecordsButton_Click);
			// 
			// addGroupsToUserButton
			// 
			this.addGroupsToUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addGroupsToUserButton.Location = new System.Drawing.Point(12, 41);
			this.addGroupsToUserButton.Name = "addGroupsToUserButton";
			this.addGroupsToUserButton.Size = new System.Drawing.Size(311, 23);
			this.addGroupsToUserButton.TabIndex = 1;
			this.addGroupsToUserButton.Text = "Add Groups To User";
			this.addGroupsToUserButton.UseVisualStyleBackColor = true;
			this.addGroupsToUserButton.Click += new System.EventHandler(this.AddGroupsToUserButton_Click);
			// 
			// addUsersToGroupButton
			// 
			this.addUsersToGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addUsersToGroupButton.Location = new System.Drawing.Point(12, 70);
			this.addUsersToGroupButton.Name = "addUsersToGroupButton";
			this.addUsersToGroupButton.Size = new System.Drawing.Size(311, 23);
			this.addUsersToGroupButton.TabIndex = 2;
			this.addUsersToGroupButton.Text = "Add Users To Group";
			this.addUsersToGroupButton.UseVisualStyleBackColor = true;
			this.addUsersToGroupButton.Click += new System.EventHandler(this.AddUsersToGroupButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 106);
			this.Controls.Add(this.addUsersToGroupButton);
			this.Controls.Add(this.addGroupsToUserButton);
			this.Controls.Add(this.addNewRecordsButton);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addNewRecordsButton;
		private System.Windows.Forms.Button addGroupsToUserButton;
		private System.Windows.Forms.Button addUsersToGroupButton;
	}
}
