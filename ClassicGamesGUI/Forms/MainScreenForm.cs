namespace ClassicGamesGUI
{
	public partial class MainScreenForm : Form
	{
		public MainScreenForm()
		{
			InitializeComponent();
		}

		private void MainScreenForm_Load(object sender, EventArgs e)
		{
			panelMainScreen.BackColor = Color.Beige;
			panelMainScreenTitle.BackColor = Color.BlanchedAlmond;
			paneLMainScreenButtonGroup.BackColor = Color.BurlyWood;
			buttonMainScreenStart.BackColor = Color.Coral;
			buttonMaintenance.BackColor = Color.Coral;
			buttonExit.BackColor = Color.Coral;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}