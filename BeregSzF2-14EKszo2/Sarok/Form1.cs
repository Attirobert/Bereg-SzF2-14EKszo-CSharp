using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarok
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBalFel_Click(object sender, EventArgs e)
        {
            // A form ugorjon fel a képernyő bal felső sarkába
            Left = 0;
            Top = 0;
        }

        private void btnJobbFel_Click(object sender, EventArgs e)
        {
            // A form ugorjon fel a képernyő jobb felső sarkába
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = 0;
        }

        private void btnBalLe_Click(object sender, EventArgs e)
        {
            // A form ugorjon fel a képernyő bal alsó sarkába
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void btnJobbLe_Click(object sender, EventArgs e)
        {
            // A form ugorjon fel a képernyő jobb alsó sarkába
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }
    }
}
