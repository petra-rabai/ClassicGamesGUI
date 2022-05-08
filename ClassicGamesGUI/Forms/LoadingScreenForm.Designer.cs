namespace ClassicGamesGUI
{
	partial class LoadingScreenForm
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
			this.components = new System.ComponentModel.Container();
			this.panelLoadingScreen = new System.Windows.Forms.Panel();
			this.labelLoadingPercent = new System.Windows.Forms.Label();
			this.progressBarLoading = new System.Windows.Forms.ProgressBar();
			this.timerLoading = new System.Windows.Forms.Timer(this.components);
			this.panelLoadingScreen.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLoadingScreen
			// 
			this.panelLoadingScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelLoadingScreen.Controls.Add(this.labelLoadingPercent);
			this.panelLoadingScreen.Controls.Add(this.progressBarLoading);
			this.panelLoadingScreen.Location = new System.Drawing.Point(2, 1);
			this.panelLoadingScreen.Name = "panelLoadingScreen";
			this.panelLoadingScreen.Size = new System.Drawing.Size(625, 100);
			this.panelLoadingScreen.TabIndex = 0;
			// 
			// labelLoadingPercent
			// 
			this.labelLoadingPercent.AutoSize = true;
			this.labelLoadingPercent.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelLoadingPercent.Location = new System.Drawing.Point(243, 68);
			this.labelLoadingPercent.Name = "labelLoadingPercent";
			this.labelLoadingPercent.Size = new System.Drawing.Size(109, 19);
			this.labelLoadingPercent.TabIndex = 1;
			this.labelLoadingPercent.Text = "Loading...";
			// 
			// progressBarLoading
			// 
			this.progressBarLoading.BackColor = System.Drawing.Color.Cornsilk;
			this.progressBarLoading.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.progressBarLoading.Location = new System.Drawing.Point(0, 20);
			this.progressBarLoading.Name = "progressBarLoading";
			this.progressBarLoading.Size = new System.Drawing.Size(625, 35);
			this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarLoading.TabIndex = 0;
			// 
			// timerLoading
			// 
			this.timerLoading.Enabled = true;
			this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
			// 
			// LoadingScreenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 107);
			this.ControlBox = false;
			this.Controls.Add(this.panelLoadingScreen);
			this.Name = "LoadingScreenForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.LoadingScreenForm_Load);
			this.panelLoadingScreen.ResumeLayout(false);
			this.panelLoadingScreen.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panelLoadingScreen;
		private Label labelLoadingPercent;
		private ProgressBar progressBarLoading;
		private System.Windows.Forms.Timer timerLoading;
	}
}