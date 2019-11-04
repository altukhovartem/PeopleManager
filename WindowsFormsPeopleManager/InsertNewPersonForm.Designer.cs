namespace WindowsFormsPeopleManager
{
	partial class InsertNewPersonForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.FirstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.stateTextBox = new System.Windows.Forms.TextBox();
			this.stateLabel = new System.Windows.Forms.Label();
			this.countryTextbox = new System.Windows.Forms.TextBox();
			this.countryLabel = new System.Windows.Forms.Label();
			this.streetLabel = new System.Windows.Forms.Label();
			this.cityTextbox = new System.Windows.Forms.TextBox();
			this.cityLabel = new System.Windows.Forms.Label();
			this.streetTextbox = new System.Windows.Forms.TextBox();
			this.addressGroupBox = new System.Windows.Forms.GroupBox();
			this.zIPCodeTextBox = new System.Windows.Forms.TextBox();
			this.zIPCodeLabel = new System.Windows.Forms.Label();
			this.deleteButton = new System.Windows.Forms.Button();
			this.previousPersonButton = new System.Windows.Forms.Button();
			this.nextPersonButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.insertButton = new System.Windows.Forms.Button();
			this.addressGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Create New Person";
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(23, 132);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
			this.firstNameLabel.TabIndex = 1;
			this.firstNameLabel.Text = "First Name:";
			// 
			// FirstNameTextBox
			// 
			this.FirstNameTextBox.Location = new System.Drawing.Point(133, 129);
			this.FirstNameTextBox.Name = "FirstNameTextBox";
			this.FirstNameTextBox.Size = new System.Drawing.Size(144, 26);
			this.FirstNameTextBox.TabIndex = 2;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(133, 163);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(144, 26);
			this.lastNameTextBox.TabIndex = 4;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(23, 166);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
			this.lastNameLabel.TabIndex = 3;
			this.lastNameLabel.Text = "Last Name:";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(340, 9);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(82, 66);
			this.saveButton.TabIndex = 5;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.Button1_Click);
			// 
			// stateTextBox
			// 
			this.stateTextBox.Location = new System.Drawing.Point(126, 79);
			this.stateTextBox.Name = "stateTextBox";
			this.stateTextBox.Size = new System.Drawing.Size(144, 26);
			this.stateTextBox.TabIndex = 9;
			// 
			// stateLabel
			// 
			this.stateLabel.AutoSize = true;
			this.stateLabel.Location = new System.Drawing.Point(16, 82);
			this.stateLabel.Name = "stateLabel";
			this.stateLabel.Size = new System.Drawing.Size(52, 20);
			this.stateLabel.TabIndex = 8;
			this.stateLabel.Text = "State:";
			// 
			// countryTextbox
			// 
			this.countryTextbox.Location = new System.Drawing.Point(126, 45);
			this.countryTextbox.Name = "countryTextbox";
			this.countryTextbox.Size = new System.Drawing.Size(144, 26);
			this.countryTextbox.TabIndex = 7;
			// 
			// countryLabel
			// 
			this.countryLabel.AutoSize = true;
			this.countryLabel.Location = new System.Drawing.Point(16, 48);
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Size = new System.Drawing.Size(68, 20);
			this.countryLabel.TabIndex = 6;
			this.countryLabel.Text = "Country:";
			// 
			// streetLabel
			// 
			this.streetLabel.AutoSize = true;
			this.streetLabel.Location = new System.Drawing.Point(16, 150);
			this.streetLabel.Name = "streetLabel";
			this.streetLabel.Size = new System.Drawing.Size(57, 20);
			this.streetLabel.TabIndex = 12;
			this.streetLabel.Text = "Street:";
			// 
			// cityTextbox
			// 
			this.cityTextbox.Location = new System.Drawing.Point(126, 113);
			this.cityTextbox.Name = "cityTextbox";
			this.cityTextbox.Size = new System.Drawing.Size(144, 26);
			this.cityTextbox.TabIndex = 11;
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(16, 116);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(39, 20);
			this.cityLabel.TabIndex = 10;
			this.cityLabel.Text = "City:";
			// 
			// streetTextbox
			// 
			this.streetTextbox.Location = new System.Drawing.Point(126, 144);
			this.streetTextbox.Name = "streetTextbox";
			this.streetTextbox.Size = new System.Drawing.Size(144, 26);
			this.streetTextbox.TabIndex = 13;
			// 
			// addressGroupBox
			// 
			this.addressGroupBox.Controls.Add(this.zIPCodeTextBox);
			this.addressGroupBox.Controls.Add(this.countryLabel);
			this.addressGroupBox.Controls.Add(this.zIPCodeLabel);
			this.addressGroupBox.Controls.Add(this.countryTextbox);
			this.addressGroupBox.Controls.Add(this.stateLabel);
			this.addressGroupBox.Controls.Add(this.streetTextbox);
			this.addressGroupBox.Controls.Add(this.stateTextBox);
			this.addressGroupBox.Controls.Add(this.streetLabel);
			this.addressGroupBox.Controls.Add(this.cityLabel);
			this.addressGroupBox.Controls.Add(this.cityTextbox);
			this.addressGroupBox.Location = new System.Drawing.Point(16, 212);
			this.addressGroupBox.Name = "addressGroupBox";
			this.addressGroupBox.Size = new System.Drawing.Size(293, 254);
			this.addressGroupBox.TabIndex = 14;
			this.addressGroupBox.TabStop = false;
			this.addressGroupBox.Text = "Address";
			// 
			// zIPCodeTextBox
			// 
			this.zIPCodeTextBox.Location = new System.Drawing.Point(126, 179);
			this.zIPCodeTextBox.Name = "zIPCodeTextBox";
			this.zIPCodeTextBox.Size = new System.Drawing.Size(144, 26);
			this.zIPCodeTextBox.TabIndex = 16;
			// 
			// zIPCodeLabel
			// 
			this.zIPCodeLabel.AutoSize = true;
			this.zIPCodeLabel.Location = new System.Drawing.Point(16, 185);
			this.zIPCodeLabel.Name = "zIPCodeLabel";
			this.zIPCodeLabel.Size = new System.Drawing.Size(80, 20);
			this.zIPCodeLabel.TabIndex = 15;
			this.zIPCodeLabel.Text = "ZIP Code:";
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(428, 9);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(82, 66);
			this.deleteButton.TabIndex = 15;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// previousPersonButton
			// 
			this.previousPersonButton.Location = new System.Drawing.Point(587, 9);
			this.previousPersonButton.Name = "previousPersonButton";
			this.previousPersonButton.Size = new System.Drawing.Size(82, 66);
			this.previousPersonButton.TabIndex = 16;
			this.previousPersonButton.Text = "<<<";
			this.previousPersonButton.UseVisualStyleBackColor = true;
			// 
			// nextPersonButton
			// 
			this.nextPersonButton.Location = new System.Drawing.Point(675, 9);
			this.nextPersonButton.Name = "nextPersonButton";
			this.nextPersonButton.Size = new System.Drawing.Size(82, 66);
			this.nextPersonButton.TabIndex = 17;
			this.nextPersonButton.Text = ">>>";
			this.nextPersonButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(164, 9);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(82, 66);
			this.cancelButton.TabIndex = 18;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// insertButton
			// 
			this.insertButton.Location = new System.Drawing.Point(252, 9);
			this.insertButton.Name = "insertButton";
			this.insertButton.Size = new System.Drawing.Size(82, 66);
			this.insertButton.TabIndex = 19;
			this.insertButton.Text = "Insert";
			this.insertButton.UseVisualStyleBackColor = true;
			this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
			// 
			// InsertNewPersonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 597);
			this.Controls.Add(this.insertButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.nextPersonButton);
			this.Controls.Add(this.previousPersonButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.addressGroupBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.FirstNameTextBox);
			this.Controls.Add(this.firstNameLabel);
			this.Controls.Add(this.label1);
			this.Name = "InsertNewPersonForm";
			this.Text = "Insert New Person";
			this.addressGroupBox.ResumeLayout(false);
			this.addressGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox FirstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox stateTextBox;
		private System.Windows.Forms.Label stateLabel;
		private System.Windows.Forms.TextBox countryTextbox;
		private System.Windows.Forms.Label countryLabel;
		private System.Windows.Forms.Label streetLabel;
		private System.Windows.Forms.TextBox cityTextbox;
		private System.Windows.Forms.Label cityLabel;
		private System.Windows.Forms.TextBox streetTextbox;
		private System.Windows.Forms.GroupBox addressGroupBox;
		private System.Windows.Forms.TextBox zIPCodeTextBox;
		private System.Windows.Forms.Label zIPCodeLabel;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button previousPersonButton;
		private System.Windows.Forms.Button nextPersonButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button insertButton;
	}
}