using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamikus
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        int db = 0,
            osszeg = 0,
            min = int.MaxValue,
            max = int.MinValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            int i = rnd.Next(100) + 1;

            // Label objektum összeállítása
            Label lbl = new Label();
            lbl.Location = new Point(e.X, e.Y);
            lbl.Text = i.ToString();
            lbl.AutoSize = true;

            // Megjelenítés
            Controls.Add(lbl);

            statisztika(i);
        }

        private void statisztika(int i)
        {
            db++;
            osszeg += i;
            if (i < min) min = i;
            if (i > max) max = i;

            lblEredm.Text = String.Format(
                "Darabszám: {0}, " +
                "Összeg: {1}, " +
                "Átlag: {2}, " +
                "Minimum: {3}, " +
                "Maximum: {4}", 
                db, osszeg, (float)osszeg/db, min, max);
        }
    }
}
