
namespace Formaz
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
            this.cbxMit = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbxSzin = new System.Windows.Forms.GroupBox();
            this.gbxStilus = new System.Windows.Forms.GroupBox();
            this.gbxFont = new System.Windows.Forms.GroupBox();
            this.cbxPiros = new System.Windows.Forms.CheckBox();
            this.cbxKek = new System.Windows.Forms.CheckBox();
            this.cbxZold = new System.Windows.Forms.CheckBox();
            this.cbxDolt = new System.Windows.Forms.CheckBox();
            this.cbxAlahuzott = new System.Windows.Forms.CheckBox();
            this.cbxFelkover = new System.Windows.Forms.CheckBox();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.rbTimes = new System.Windows.Forms.RadioButton();
            this.rbComic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEredm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtir = new System.Windows.Forms.Button();
            this.btnAlkalmaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbxSzin.SuspendLayout();
            this.gbxStilus.SuspendLayout();
            this.gbxFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxMit
            // 
            this.cbxMit.FormattingEnabled = true;
            this.cbxMit.Items.AddRange(new object[] {
            "Szöveg",
            "Háttér"});
            this.cbxMit.Location = new System.Drawing.Point(125, 13);
            this.cbxMit.Name = "cbxMit";
            this.cbxMit.Size = new System.Drawing.Size(121, 21);
            this.cbxMit.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 65);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // gbxSzin
            // 
            this.gbxSzin.Controls.Add(this.cbxZold);
            this.gbxSzin.Controls.Add(this.cbxKek);
            this.gbxSzin.Controls.Add(this.cbxPiros);
            this.gbxSzin.Location = new System.Drawing.Point(23, 157);
            this.gbxSzin.Name = "gbxSzin";
            this.gbxSzin.Size = new System.Drawing.Size(89, 100);
            this.gbxSzin.TabIndex = 2;
            this.gbxSzin.TabStop = false;
            this.gbxSzin.Text = "Szín";
            // 
            // gbxStilus
            // 
            this.gbxStilus.Controls.Add(this.cbxFelkover);
            this.gbxStilus.Controls.Add(this.cbxDolt);
            this.gbxStilus.Controls.Add(this.cbxAlahuzott);
            this.gbxStilus.Location = new System.Drawing.Point(134, 157);
            this.gbxStilus.Name = "gbxStilus";
            this.gbxStilus.Size = new System.Drawing.Size(112, 100);
            this.gbxStilus.TabIndex = 2;
            this.gbxStilus.TabStop = false;
            this.gbxStilus.Text = "Stílus";
            // 
            // gbxFont
            // 
            this.gbxFont.Controls.Add(this.rbComic);
            this.gbxFont.Controls.Add(this.rbTimes);
            this.gbxFont.Controls.Add(this.rbArial);
            this.gbxFont.Location = new System.Drawing.Point(270, 157);
            this.gbxFont.Name = "gbxFont";
            this.gbxFont.Size = new System.Drawing.Size(147, 100);
            this.gbxFont.TabIndex = 2;
            this.gbxFont.TabStop = false;
            this.gbxFont.Text = "Font";
            // 
            // cbxPiros
            // 
            this.cbxPiros.AutoSize = true;
            this.cbxPiros.ForeColor = System.Drawing.Color.Red;
            this.cbxPiros.Location = new System.Drawing.Point(7, 20);
            this.cbxPiros.Name = "cbxPiros";
            this.cbxPiros.Size = new System.Drawing.Size(49, 17);
            this.cbxPiros.TabIndex = 0;
            this.cbxPiros.Text = "Piros";
            this.cbxPiros.UseVisualStyleBackColor = true;
            // 
            // cbxKek
            // 
            this.cbxKek.AutoSize = true;
            this.cbxKek.ForeColor = System.Drawing.Color.Blue;
            this.cbxKek.Location = new System.Drawing.Point(6, 43);
            this.cbxKek.Name = "cbxKek";
            this.cbxKek.Size = new System.Drawing.Size(45, 17);
            this.cbxKek.TabIndex = 0;
            this.cbxKek.Text = "Kék";
            this.cbxKek.UseVisualStyleBackColor = true;
            // 
            // cbxZold
            // 
            this.cbxZold.AutoSize = true;
            this.cbxZold.ForeColor = System.Drawing.Color.Green;
            this.cbxZold.Location = new System.Drawing.Point(6, 66);
            this.cbxZold.Name = "cbxZold";
            this.cbxZold.Size = new System.Drawing.Size(47, 17);
            this.cbxZold.TabIndex = 0;
            this.cbxZold.Text = "Zöld";
            this.cbxZold.UseVisualStyleBackColor = true;
            // 
            // cbxDolt
            // 
            this.cbxDolt.AutoSize = true;
            this.cbxDolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDolt.Location = new System.Drawing.Point(16, 20);
            this.cbxDolt.Name = "cbxDolt";
            this.cbxDolt.Size = new System.Drawing.Size(45, 17);
            this.cbxDolt.TabIndex = 0;
            this.cbxDolt.Text = "Dőlt";
            this.cbxDolt.UseVisualStyleBackColor = true;
            // 
            // cbxAlahuzott
            // 
            this.cbxAlahuzott.AutoSize = true;
            this.cbxAlahuzott.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlahuzott.Location = new System.Drawing.Point(15, 43);
            this.cbxAlahuzott.Name = "cbxAlahuzott";
            this.cbxAlahuzott.Size = new System.Drawing.Size(70, 17);
            this.cbxAlahuzott.TabIndex = 0;
            this.cbxAlahuzott.Text = "Aláhúzott";
            this.cbxAlahuzott.UseVisualStyleBackColor = true;
            // 
            // cbxFelkover
            // 
            this.cbxFelkover.AutoSize = true;
            this.cbxFelkover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFelkover.Location = new System.Drawing.Point(15, 66);
            this.cbxFelkover.Name = "cbxFelkover";
            this.cbxFelkover.Size = new System.Drawing.Size(75, 17);
            this.cbxFelkover.TabIndex = 0;
            this.cbxFelkover.Text = "Félkövér";
            this.cbxFelkover.UseVisualStyleBackColor = true;
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArial.Location = new System.Drawing.Point(22, 20);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(47, 18);
            this.rbArial.TabIndex = 0;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            // 
            // rbTimes
            // 
            this.rbTimes.AutoSize = true;
            this.rbTimes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTimes.Location = new System.Drawing.Point(22, 43);
            this.rbTimes.Name = "rbTimes";
            this.rbTimes.Size = new System.Drawing.Size(113, 18);
            this.rbTimes.TabIndex = 0;
            this.rbTimes.TabStop = true;
            this.rbTimes.Text = "Times New Roman";
            this.rbTimes.UseVisualStyleBackColor = true;
            // 
            // rbComic
            // 
            this.rbComic.AutoSize = true;
            this.rbComic.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.rbComic.Location = new System.Drawing.Point(22, 65);
            this.rbComic.Name = "rbComic";
            this.rbComic.Size = new System.Drawing.Size(84, 19);
            this.rbComic.TabIndex = 0;
            this.rbComic.TabStop = true;
            this.rbComic.Text = "Comic Sans";
            this.rbComic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mit formázok: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Font méret: ";
            // 
            // lblEredm
            // 
            this.lblEredm.Location = new System.Drawing.Point(270, 13);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(496, 96);
            this.lblEredm.TabIndex = 4;
            this.lblEredm.Text = "Próba";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Új szöveg: ";
            // 
            // btnAtir
            // 
            this.btnAtir.Location = new System.Drawing.Point(532, 233);
            this.btnAtir.Name = "btnAtir";
            this.btnAtir.Size = new System.Drawing.Size(75, 23);
            this.btnAtir.TabIndex = 7;
            this.btnAtir.Text = "Átír";
            this.btnAtir.UseVisualStyleBackColor = true;
            // 
            // btnAlkalmaz
            // 
            this.btnAlkalmaz.Location = new System.Drawing.Point(532, 281);
            this.btnAlkalmaz.Name = "btnAlkalmaz";
            this.btnAlkalmaz.Size = new System.Drawing.Size(75, 23);
            this.btnAlkalmaz.TabIndex = 8;
            this.btnAlkalmaz.Text = "Alkalmaz";
            this.btnAlkalmaz.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlkalmaz);
            this.Controls.Add(this.btnAtir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxFont);
            this.Controls.Add(this.gbxStilus);
            this.Controls.Add(this.gbxSzin);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbxMit);
            this.Name = "MainForm";
            this.Text = "Formázás";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbxSzin.ResumeLayout(false);
            this.gbxSzin.PerformLayout();
            this.gbxStilus.ResumeLayout(false);
            this.gbxStilus.PerformLayout();
            this.gbxFont.ResumeLayout(false);
            this.gbxFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMit;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox gbxSzin;
        private System.Windows.Forms.CheckBox cbxZold;
        private System.Windows.Forms.CheckBox cbxKek;
        private System.Windows.Forms.CheckBox cbxPiros;
        private System.Windows.Forms.GroupBox gbxStilus;
        private System.Windows.Forms.CheckBox cbxFelkover;
        private System.Windows.Forms.CheckBox cbxDolt;
        private System.Windows.Forms.CheckBox cbxAlahuzott;
        private System.Windows.Forms.GroupBox gbxFont;
        private System.Windows.Forms.RadioButton rbComic;
        private System.Windows.Forms.RadioButton rbTimes;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEredm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtir;
        private System.Windows.Forms.Button btnAlkalmaz;
    }
}

