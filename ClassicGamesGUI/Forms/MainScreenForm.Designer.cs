namespace ClassicGamesGUI
{
	partial class MainScreenForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelMainScreen = new System.Windows.Forms.Panel();
			this.paneLMainScreenButtonGroup = new System.Windows.Forms.Panel();
			this.buttonMaintenance = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonMainScreenStart = new System.Windows.Forms.Button();
			this.panelMainScreenTitle = new System.Windows.Forms.Panel();
			this.labelMainScreenTitle = new System.Windows.Forms.Label();
			this.panelMainScreen.SuspendLayout();
			this.paneLMainScreenButtonGroup.SuspendLayout();
			this.panelMainScreenTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMainScreen
			// 
			this.panelMainScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelMainScreen.Controls.Add(this.paneLMainScreenButtonGroup);
			this.panelMainScreen.Controls.Add(this.panelMainScreenTitle);
			this.panelMainScreen.Location = new System.Drawing.Point(2, 2);
			this.panelMainScreen.Name = "panelMainScreen";
			this.panelMainScreen.Size = new System.Drawing.Size(798, 450);
			this.panelMainScreen.TabIndex = 0;
			// 
			// paneLMainScreenButtonGroup
			// 
			this.paneLMainScreenButtonGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.paneLMainScreenButtonGroup.Controls.Add(this.buttonMaintenance);
			this.paneLMainScreenButtonGroup.Controls.Add(this.buttonExit);
			this.paneLMainScreenButtonGroup.Controls.Add(this.buttonMainScreenStart);
			this.paneLMainScreenButtonGroup.Location = new System.Drawing.Point(3, 347);
			this.paneLMainScreenButtonGroup.Name = "paneLMainScreenButtonGroup";
			this.paneLMainScreenButtonGroup.Size = new System.Drawing.Size(792, 100);
			this.paneLMainScreenButtonGroup.TabIndex = 1;
			// 
			// buttonMaintenance
			// 
			this.buttonMaintenance.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonMaintenance.Image = global::ClassicGamesGUI.Properties.Resources.icons8_settings_50;
			this.buttonMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMaintenance.Location = new System.Drawing.Point(299, 26);
			this.buttonMaintenance.Name = "buttonMaintenance";
			this.buttonMaintenance.Size = new System.Drawing.Size(210, 49);
			this.buttonMaintenance.TabIndex = 2;
			this.buttonMaintenance.Text = "MAINTENANCE";
			this.buttonMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMaintenance.UseVisualStyleBackColor = true;
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonExit.Image = global::ClassicGamesGUI.Properties.Resources.icons8_exit_48;
			this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonExit.Location = new System.Drawing.Point(649, 27);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(134, 49);
			this.buttonExit.TabIndex = 1;
			this.buttonExit.Text = "EXIT";
			this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonMainScreenStart
			// 
			this.buttonMainScreenStart.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonMainScreenStart.Image = global::ClassicGamesGUI.Properties.Resources.icons8_start_50;
			this.buttonMainScreenStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMainScreenStart.Location = new System.Drawing.Point(7, 27);
			this.buttonMainScreenStart.Name = "buttonMainScreenStart";
			this.buttonMainScreenStart.Size = new System.Drawing.Size(134, 49);
			this.buttonMainScreenStart.TabIndex = 0;
			this.buttonMainScreenStart.Text = "START";
			this.buttonMainScreenStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMainScreenStart.UseVisualStyleBackColor = true;
			// 
			// panelMainScreenTitle
			// 
			this.panelMainScreenTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelMainScreenTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMainScreenTitle.Controls.Add(this.labelMainScreenTitle);
			this.panelMainScreenTitle.Location = new System.Drawing.Point(3, 3);
			this.panelMainScreenTitle.Name = "panelMainScreenTitle";
			this.panelMainScreenTitle.Size = new System.Drawing.Size(792, 100);
			this.panelMainScreenTitle.TabIndex = 0;
			// 
			// labelMainScreenTitle
			// 
			this.labelMainScreenTitle.AutoSize = true;
			this.labelMainScreenTitle.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelMainScreenTitle.Location = new System.Drawing.Point(201, 26);
			this.labelMainScreenTitle.Name = "labelMainScreenTitle";
			this.labelMainScreenTitle.Size = new System.Drawing.Size(338, 33);
			this.labelMainScreenTitle.TabIndex = 0;
			this.labelMainScreenTitle.Text = "CLASSIC RETRO GAMES";
			// 
			// MainScreenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panelMainScreen);
			this.Name = "MainScreenForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CRG";
			this.Load += new System.EventHandler(this.MainScreenForm_Load);
			this.panelMainScreen.ResumeLayout(false);
			this.paneLMainScreenButtonGroup.ResumeLayout(false);
			this.panelMainScreenTitle.ResumeLayout(false);
			this.panelMainScreenTitle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panelMainScreen;
		private Panel panelMainScreenTitle;
		private Label labelMainScreenTitle;
		private Panel paneLMainScreenButtonGroup;
		private Button buttonMainScreenStart;
		private Button buttonExit;
		private Button buttonMaintenance;
	}
}