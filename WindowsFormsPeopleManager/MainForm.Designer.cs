namespace WindowsFormsPeopleManager
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.listOfPeopleListbox = new System.Windows.Forms.ListBox();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.RedirectToAddNewPersonFormButton = new System.Windows.Forms.Button();
			this.openRecordButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listOfPeopleListbox
			// 
			this.listOfPeopleListbox.FormattingEnabled = true;
			this.listOfPeopleListbox.ItemHeight = 20;
			this.listOfPeopleListbox.Location = new System.Drawing.Point(12, 219);
			this.listOfPeopleListbox.Name = "listOfPeopleListbox";
			this.listOfPeopleListbox.Size = new System.Drawing.Size(488, 84);
			this.listOfPeopleListbox.TabIndex = 0;
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(12, 187);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(159, 26);
			this.searchTextBox.TabIndex = 1;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(213, 178);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(100, 35);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.Button1_Click);
			// 
			// RedirectToAddNewPersonFormButton
			// 
			this.RedirectToAddNewPersonFormButton.Location = new System.Drawing.Point(118, 12);
			this.RedirectToAddNewPersonFormButton.Name = "RedirectToAddNewPersonFormButton";
			this.RedirectToAddNewPersonFormButton.Size = new System.Drawing.Size(100, 42);
			this.RedirectToAddNewPersonFormButton.TabIndex = 3;
			this.RedirectToAddNewPersonFormButton.Text = "Insert";
			this.RedirectToAddNewPersonFormButton.UseVisualStyleBackColor = true;
			this.RedirectToAddNewPersonFormButton.Click += new System.EventHandler(this.RedirectToAddNewPersonFormButton_Click);
			// 
			// openRecordButton
			// 
			this.openRecordButton.Location = new System.Drawing.Point(12, 12);
			this.openRecordButton.Name = "openRecordButton";
			this.openRecordButton.Size = new System.Drawing.Size(100, 42);
			this.openRecordButton.TabIndex = 4;
			this.openRecordButton.Text = "Open";
			this.openRecordButton.UseVisualStyleBackColor = true;
			this.openRecordButton.Click += new System.EventHandler(this.OpenRecordButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.openRecordButton);
			this.Controls.Add(this.RedirectToAddNewPersonFormButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.listOfPeopleListbox);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listOfPeopleListbox;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button RedirectToAddNewPersonFormButton;
		private System.Windows.Forms.Button openRecordButton;
	}
}

