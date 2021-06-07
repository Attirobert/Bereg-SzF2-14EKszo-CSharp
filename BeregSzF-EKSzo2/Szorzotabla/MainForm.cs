using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szorzotabla
{
    // Hibás!!!!
    public partial class MainForm : Form
    {
        // Osztályváltozók
        private int szeles = 35,    // Mező szélessége
            sorOszlop = 10,    // Sorok és oszlopok száma
            keret = 50,     // A táblázat körüli keret mérete
            joValasz = 0,
            rosszValasz = 0,   // Azért, mert a CurrentCellChanged esemény a DataGridView létrehozásakor is bekövetkezik
            /* Az aktuális sor és oszlop index kimentésére, hogy azt is vizsgálni tudjuk, ha nem ír semmit a cellába */
            aktSor,         
            aktOszlop;

        private string txtJo = "A jó válaszok száma: {0}",
            txtRossz = "A rossz válaszok száma: {0}";

        private Random rnd = new Random();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TablaEpit(sorOszlop);
        }

        private void dgvSzor_CurrentCellChanged(object sender, EventArgs e)
        {
            // Ha nem írt a cellába semmit és tovább lép, akkor növeljük a rossz válaszok számát.
            //if (dgvSzor[aktOszlop, aktSor].Value == null) Valasz(false);
        }

        private void TablaEpit(int sor)
        {
            // Töröljük a sorokat és oszlopokat
            dgvSzor.Columns.Clear();
            dgvSzor.Rows.Clear();

            // Táblázat méretének meghatározása
            dgvSzor.Width = sorOszlop * szeles + 2 * keret;

            // Generálom az oszlopokat
            for (int i = 0; i < sorOszlop; i++)
            {
                dgvSzor.Columns.Add(String.Empty, String.Empty);
                dgvSzor.Columns[i].Width = szeles;
            }

            // Sorok elkészítése
            for (int i =0; i < sorOszlop; i++)
            {
                object[] intSor = new object[sorOszlop];
                dgvSzor.Rows.Add(intSor);
            }

            // Táblázat fejsorának és oszlopának feltöltése és formázása
            for (int i = 1; i < sorOszlop; i++)
            {
                dgvSzor[0, i].Value = i;
                dgvSzor[i, 0].Value = i;
                dgvSzor[0, i].Style.Font = new Font(dgvSzor.Font, FontStyle.Bold);
                dgvSzor[i, 0].Style.Font = new Font(dgvSzor.Font, FontStyle.Italic);
            }
        }

        private void btnFeladat_Click(object sender, EventArgs e)
        {
            Sorsol();
        }

        // Véletlen szerűen kijelöli a szorzót és szorzandót
        private void Sorsol()
        {
            int aktI = rnd.Next(1, sorOszlop);
            int aktJ = rnd.Next(1, sorOszlop);

            // Addig próbálkozunk az indexxekkel, amíg olyan cellát nem találunk ami még nem szerepelt
            while (dgvSzor[aktI, aktJ].Style.BackColor == Color.LightBlue)
            {
                aktI = rnd.Next(1, sorOszlop);
                aktJ = rnd.Next(1, sorOszlop);
            }

            // Aktuális sor- és oszlop index kimentése
            aktOszlop = aktI;
            aktSor = aktJ;

            // A cellák beszínezése
            dgvSzor[aktI, aktJ].Style.BackColor = Color.LightBlue;
            dgvSzor[0, aktJ].Style.BackColor = Color.Orange;
            dgvSzor[aktI, 0].Style.BackColor = Color.Orange;

            // Fókusz beállítása a cellára. Azonnal lehet bele írni.
            dgvSzor.Focus();
            dgvSzor.CurrentCell = dgvSzor.Rows[aktJ].Cells[aktI];
        }

        private void dgvSzor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Ellenoriz(e.RowIndex, e.ColumnIndex);
        }

        private void Ellenoriz(int indSor, int indOszlop)
        {
            if (dgvSzor[indOszlop, indSor].Value == null) return;

            if (indSor * indOszlop == Convert.ToInt32(dgvSzor[indOszlop, indSor].Value)) Valasz(true);
            else Valasz(false);

            // Kilépünk, ha minden variációt elvégeztünk
            if ((joValasz + rosszValasz) == sorOszlop*sorOszlop)
            {
                MessageBox.Show("Vége a feladatnak, a teljes táblázatot kitöltötte!");
                // this.Close();   Valamiért nem működik!
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void Valasz(bool v)
        {
            if (v)
            {
                joValasz++;
                lblJo.Text = String.Format(txtJo, joValasz);
            }
            else
            {
                rosszValasz++;
                lblRossz.Text = String.Format(txtRossz, rosszValasz);
            }
        }
    }
}
