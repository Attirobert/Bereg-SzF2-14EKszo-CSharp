
namespace Szorzotabla
{
    partial class MainForm
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
            this.dgvSzor = new System.Windows.Forms.DataGridView();
            this.lblJo = new System.Windows.Forms.Label();
            this.lblRossz = new System.Windows.Forms.Label();
            this.btnFeladat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSzor
            // 
            this.dgvSzor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzor.ColumnHeadersVisible = false;
            this.dgvSzor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSzor.Location = new System.Drawing.Point(13, 13);
            this.dgvSzor.Name = "dgvSzor";
            this.dgvSzor.RowHeadersVisible = false;
            this.dgvSzor.Size = new System.Drawing.Size(373, 322);
            this.dgvSzor.TabIndex = 0;
            this.dgvSzor.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSzor_CellEndEdit);
            this.dgvSzor.CurrentCellChanged += new System.EventHandler(this.dgvSzor_CurrentCellChanged);
            // 
            // lblJo
            // 
            this.lblJo.AutoSize = true;
            this.lblJo.Location = new System.Drawing.Point(13, 353);
            this.lblJo.Name = "lblJo";
            this.lblJo.Size = new System.Drawing.Size(102, 13);
            this.lblJo.TabIndex = 1;
            this.lblJo.Text = "Jó válaszok száma: ";
            // 
            // lblRossz
            // 
            this.lblRossz.AutoSize = true;
            this.lblRossz.Location = new System.Drawing.Point(10, 377);
            this.lblRossz.Name = "lblRossz";
            this.lblRossz.Size = new System.Drawing.Size(120, 13);
            this.lblRossz.TabIndex = 1;
            this.lblRossz.Text = "Rossz válaszok száma: ";
            // 
            // btnFeladat
            // 
            this.btnFeladat.Location = new System.Drawing.Point(13, 412);
            this.btnFeladat.Name = "btnFeladat";
            this.btnFeladat.Size = new System.Drawing.Size(75, 23);
            this.btnFeladat.TabIndex = 2;
            this.btnFeladat.Text = "Feladat";
            this.btnFeladat.UseVisualStyleBackColor = true;
            this.btnFeladat.Click += new System.EventHandler(this.btnFeladat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.btnFeladat);
            this.Controls.Add(this.lblRossz);
            this.Controls.Add(this.lblJo);
            this.Controls.Add(this.dgvSzor);
            this.Name = "MainForm";
            this.Text = "Szorzótábla";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSzor;
        private System.Windows.Forms.Label lblJo;
        private System.Windows.Forms.Label lblRossz;
        private System.Windows.Forms.Button btnFeladat;
    }
}

