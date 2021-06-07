using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBar2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void szinez(object sender, EventArgs e)
        {
            lblSzinez.BackColor = Color.FromArgb(hscbRed.Value, hscbGreen.Value, hscbBlue.Value);
            lblRGB.Text = $"Red: {hscbRed.Value}; Green: {hscbGreen.Value}; Blue: {hscbBlue.Value}";
            // 2. változat
            // lblRGB.Text = "Red: "+hscbRed.Value+"; Green: "+hscbGreen.Value+"; Blue: "+hscbBlue.Value;
        }
    }
}
