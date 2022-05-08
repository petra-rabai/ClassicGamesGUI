namespace ClassicGamesGUI.Forms
{
	partial class LoginForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAuthenticationScreenLogin = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelAuthenticationTitle = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.buttonAuthenticationScreenLogin);
			this.panel1.Controls.Add(this.buttonExit);
			this.panel1.Controls.Add(this.labelAuthenticationTitle);
			this.panel1.Location = new System.Drawing.Point(0, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(439, 569);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(51, 85);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(322, 327);
			this.panel2.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(18, 194);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(283, 31);
			this.textBox2.TabIndex = 10;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(18, 111);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(283, 31);
			this.textBox1.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(18, 163);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 28);
			this.label2.TabIndex = 8;
			this.label2.Text = "Password: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(18, 80);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 28);
			this.label1.TabIndex = 7;
			this.label1.Text = "Login Name: ";
			// 
			// buttonAuthenticationScreenLogin
			// 
			this.buttonAuthenticationScreenLogin.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAuthenticationScreenLogin.Image = global::ClassicGamesGUI.Properties.Resources.icons8_login_67;
			this.buttonAuthenticationScreenLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAuthenticationScreenLogin.Location = new System.Drawing.Point(4, 473);
			this.buttonAuthenticationScreenLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAuthenticationScreenLogin.Name = "buttonAuthenticationScreenLogin";
			this.buttonAuthenticationScreenLogin.Size = new System.Drawing.Size(144, 82);
			this.buttonAuthenticationScreenLogin.TabIndex = 5;
			this.buttonAuthenticationScreenLogin.Text = "LOGIN";
			this.buttonAuthenticationScreenLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAuthenticationScreenLogin.UseVisualStyleBackColor = true;
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonExit.Image = global::ClassicGamesGUI.Properties.Resources.icons8_exit_48;
			this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonExit.Location = new System.Drawing.Point(295, 473);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(140, 82);
			this.buttonExit.TabIndex = 6;
			this.buttonExit.Text = "CANCEL";
			this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelAuthenticationTitle
			// 
			this.labelAuthenticationTitle.AutoSize = true;
			this.labelAuthenticationTitle.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelAuthenticationTitle.Location = new System.Drawing.Point(134, 8);
			this.labelAuthenticationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelAuthenticationTitle.Name = "labelAuthenticationTitle";
			this.labelAuthenticationTitle.Size = new System.Drawing.Size(145, 48);
			this.labelAuthenticationTitle.TabIndex = 2;
			this.labelAuthenticationTitle.Text = "LOGIN";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 570);
			this.Controls.Add(this.panel1);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Label labelAuthenticationTitle;
		private Panel panel2;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label2;
		private Label label1;
		private Button buttonAuthenticationScreenLogin;
		private Button buttonExit;
	}
}