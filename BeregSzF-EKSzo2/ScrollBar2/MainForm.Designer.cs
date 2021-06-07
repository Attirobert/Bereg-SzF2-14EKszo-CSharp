
namespace ScrollBar2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblSzinez = new System.Windows.Forms.Label();
            this.hscbRed = new System.Windows.Forms.HScrollBar();
            this.hscbBlue = new System.Windows.Forms.HScrollBar();
            this.hscbGreen = new System.Windows.Forms.HScrollBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSzinez
            // 
            this.lblSzinez.AllowDrop = true;
            this.lblSzinez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSzinez.Location = new System.Drawing.Point(12, 9);
            this.lblSzinez.Name = "lblSzinez";
            this.lblSzinez.Size = new System.Drawing.Size(776, 159);
            this.lblSzinez.TabIndex = 0;
            this.lblSzinez.Text = resources.GetString("lblSzinez.Text");
            this.lblSzinez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hscbRed
            // 
            this.hscbRed.Location = new System.Drawing.Point(48, 217);
            this.hscbRed.Maximum = 255;
            this.hscbRed.MaximumSize = new System.Drawing.Size(300, 20);
            this.hscbRed.MinimumSize = new System.Drawing.Size(10, 20);
            this.hscbRed.Name = "hscbRed";
            this.hscbRed.Size = new System.Drawing.Size(300, 20);
            this.hscbRed.TabIndex = 1;
            this.hscbRed.Value = 10;
            this.hscbRed.ValueChanged += new System.EventHandler(this.szinez);
            // 
            // hscbBlue
            // 
            this.hscbBlue.Location = new System.Drawing.Point(48, 259);
            this.hscbBlue.Maximum = 255;
            this.hscbBlue.MaximumSize = new System.Drawing.Size(300, 20);
            this.hscbBlue.MinimumSize = new System.Drawing.Size(10, 20);
            this.hscbBlue.Name = "hscbBlue";
            this.hscbBlue.Size = new System.Drawing.Size(300, 20);
            this.hscbBlue.TabIndex = 1;
            this.hscbBlue.Value = 10;
            this.hscbBlue.ValueChanged += new System.EventHandler(this.szinez);
            // 
            // hscbGreen
            // 
            this.hscbGreen.Location = new System.Drawing.Point(48, 301);
            this.hscbGreen.Maximum = 255;
            this.hscbGreen.MaximumSize = new System.Drawing.Size(300, 20);
            this.hscbGreen.MinimumSize = new System.Drawing.Size(10, 20);
            this.hscbGreen.Name = "hscbGreen";
            this.hscbGreen.Size = new System.Drawing.Size(300, 20);
            this.hscbGreen.TabIndex = 1;
            this.hscbGreen.Value = 10;
            this.hscbGreen.ValueChanged += new System.EventHandler(this.szinez);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(395, 223);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(33, 13);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "Piros ";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(395, 266);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(29, 13);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Kék ";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(395, 301);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(31, 13);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Zöld ";
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(59, 352);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(0, 13);
            this.lblRGB.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.hscbGreen);
            this.Controls.Add(this.hscbBlue);
            this.Controls.Add(this.hscbRed);
            this.Controls.Add(this.lblSzinez);
            this.Name = "MainForm";
            this.Text = "ScrollBar példa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSzinez;
        private System.Windows.Forms.HScrollBar hscbRed;
        private System.Windows.Forms.HScrollBar hscbBlue;
        private System.Windows.Forms.HScrollBar hscbGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRGB;
    }
}

