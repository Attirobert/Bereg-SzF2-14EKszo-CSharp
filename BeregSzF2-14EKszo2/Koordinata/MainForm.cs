using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koordinata
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Kiírjuk a form fejlécébe az egér koordinátáit
            Text = String.Format("Az egér koordinátái: X={0}, Y={1}", e.X, e.Y);
        }

        private void PanelIgazit()
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Height = (ClientSize.Height - panel1.Height) / 2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            PanelIgazit();
        }
    }
}
