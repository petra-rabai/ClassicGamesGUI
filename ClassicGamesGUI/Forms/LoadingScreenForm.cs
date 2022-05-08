using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicGamesGUI
{
	public partial class LoadingScreenForm : Form
	{
		private readonly int _progressBarMaxValue = 100;
		private readonly int _progressBarStepValue = 5;

		public LoadingScreenForm()
		{
			InitializeComponent();
		}

		private void LoadingScreenForm_Load(object sender, EventArgs e)
		{
			panelLoadingScreen.BackColor = Color.Beige;
			labelLoadingPercent.Visible = false;
			progressBarLoading.Visible = false;
			progressBarLoading.Style = ProgressBarStyle.Continuous;
			progressBarLoading.ForeColor = Color.DarkGoldenrod;
			progressBarLoading.BackColor = Color.Cornsilk;
			progressBarLoading.Step = _progressBarStepValue;
			progressBarLoading.Maximum = _progressBarMaxValue;
			
		}

		private void timerLoading_Tick(object sender, EventArgs e)
		{
			if (progressBarLoading.Value > _progressBarMaxValue)
			{
				timerLoading.Enabled = false;	
			}
			else
			{
				labelLoadingPercent.Visible = true;
				progressBarLoading.Visible = true;
				progressBarLoading.Increment(1);
				labelLoadingPercent.Text = "Loading... " + progressBarLoading.Value.ToString() + " % ";
			}

			if (progressBarLoading.Value == _progressBarMaxValue)
			{
				Hide();
				MainScreenForm mainScreenForm = new();
				mainScreenForm.Show();
				timerLoading.Enabled = false;
			}
			
		}
	}
}
