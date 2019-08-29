using Millionaire.DataService;
using Millionaire.GameRules;
using System;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void ConstructButton_Click(object sender, EventArgs e)
        {
            ConstructForm constructForm = new ConstructForm(new XmlDataProvider(), new DefaultGameRules());
            constructForm.ShowDialog();
        }

        private void RecordsButton_Click(object sender, EventArgs e)
        {
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(new XmlDataProvider(), new DefaultGameRules());
            gameForm.ShowDialog();
        }
    }
}
