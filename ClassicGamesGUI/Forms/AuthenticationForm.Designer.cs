namespace ClassicGamesGUI.Forms
{
	partial class AuthenticationForm
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
			this.panelTitle = new System.Windows.Forms.Panel();
			this.panelButtonGroup = new System.Windows.Forms.Panel();
			this.labelAuthenticationTitle = new System.Windows.Forms.Label();
			this.buttonAuthenticationScreenRegistration = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonAuthenticationScreenLogin = new System.Windows.Forms.Button();
			this.panelTitle.SuspendLayout();
			this.panelButtonGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.labelAuthenticationTitle);
			this.panelTitle.Location = new System.Drawing.Point(3, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(796, 110);
			this.panelTitle.TabIndex = 0;
			// 
			// panelButtonGroup
			// 
			this.panelButtonGroup.Controls.Add(this.buttonAuthenticationScreenRegistration);
			this.panelButtonGroup.Controls.Add(this.buttonAuthenticationScreenLogin);
			this.panelButtonGroup.Controls.Add(this.buttonExit);
			this.panelButtonGroup.Location = new System.Drawing.Point(3, 339);
			this.panelButtonGroup.Name = "panelButtonGroup";
			this.panelButtonGroup.Size = new System.Drawing.Size(796, 110);
			this.panelButtonGroup.TabIndex = 1;
			// 
			// labelAuthenticationTitle
			// 
			this.labelAuthenticationTitle.AutoSize = true;
			this.labelAuthenticationTitle.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelAuthenticationTitle.Location = new System.Drawing.Point(198, 31);
			this.labelAuthenticationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelAuthenticationTitle.Name = "labelAuthenticationTitle";
			this.labelAuthenticationTitle.Size = new System.Drawing.Size(370, 48);
			this.labelAuthenticationTitle.TabIndex = 1;
			this.labelAuthenticationTitle.Text = "AUTHENTICATION";
			// 
			// buttonAuthenticationScreenRegistration
			// 
			this.buttonAuthenticationScreenRegistration.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAuthenticationScreenRegistration.Image = global::ClassicGamesGUI.Properties.Resources.icons8_registration_60;
			this.buttonAuthenticationScreenRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAuthenticationScreenRegistration.Location = new System.Drawing.Point(300, 15);
			this.buttonAuthenticationScreenRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAuthenticationScreenRegistration.Name = "buttonAuthenticationScreenRegistration";
			this.buttonAuthenticationScreenRegistration.Size = new System.Drawing.Size(230, 82);
			this.buttonAuthenticationScreenRegistration.TabIndex = 5;
			this.buttonAuthenticationScreenRegistration.Text = "REGISTRATION";
			this.buttonAuthenticationScreenRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAuthenticationScreenRegistration.UseVisualStyleBackColor = true;
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonExit.Image = global::ClassicGamesGUI.Properties.Resources.icons8_exit_48;
			this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonExit.Location = new System.Drawing.Point(670, 15);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(114, 82);
			this.buttonExit.TabIndex = 4;
			this.buttonExit.Text = "EXIT";
			this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonAuthenticationScreenLogin
			// 
			this.buttonAuthenticationScreenLogin.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAuthenticationScreenLogin.Image = global::ClassicGamesGUI.Properties.Resources.icons8_login_67;
			this.buttonAuthenticationScreenLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAuthenticationScreenLogin.Location = new System.Drawing.Point(10, 15);
			this.buttonAuthenticationScreenLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAuthenticationScreenLogin.Name = "buttonAuthenticationScreenLogin";
			this.buttonAuthenticationScreenLogin.Size = new System.Drawing.Size(144, 82);
			this.buttonAuthenticationScreenLogin.TabIndex = 3;
			this.buttonAuthenticationScreenLogin.Text = "LOGIN";
			this.buttonAuthenticationScreenLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAuthenticationScreenLogin.UseVisualStyleBackColor = true;
			this.buttonAuthenticationScreenLogin.Click += new System.EventHandler(this.buttonAuthenticationScreenLogin_Click);
			// 
			// AuthenticationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panelButtonGroup);
			this.Controls.Add(this.panelTitle);
			this.Name = "AuthenticationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Authentication";
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.panelButtonGroup.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panelTitle;
		private Panel panelButtonGroup;
		private Label labelAuthenticationTitle;
		private Button buttonAuthenticationScreenRegistration;
		private Button buttonAuthenticationScreenLogin;
		private Button buttonExit;
	}
}