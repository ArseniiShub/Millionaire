using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void constructButton_Click(object sender, EventArgs e)
        {
            IDataProvider dataProvider = new XmlDataProvider();
            ConstructForm constructForm = new ConstructForm(dataProvider);
            constructForm.ShowDialog();
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            IDataProvider dataProvider = new XmlDataProvider();
            GameForm gameForm = new GameForm(dataProvider);
            gameForm.ShowDialog();
        }
    }
}
