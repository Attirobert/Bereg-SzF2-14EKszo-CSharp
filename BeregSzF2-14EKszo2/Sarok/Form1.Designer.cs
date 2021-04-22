
namespace Sarok
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
            this.btnBalFel = new System.Windows.Forms.Button();
            this.btnJobbFel = new System.Windows.Forms.Button();
            this.btnBalLe = new System.Windows.Forms.Button();
            this.btnJobbLe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalFel
            // 
            this.btnBalFel.Location = new System.Drawing.Point(81, 55);
            this.btnBalFel.Name = "btnBalFel";
            this.btnBalFel.Size = new System.Drawing.Size(75, 23);
            this.btnBalFel.TabIndex = 0;
            this.btnBalFel.Text = "Balra, fel";
            this.btnBalFel.UseVisualStyleBackColor = true;
            this.btnBalFel.Click += new System.EventHandler(this.btnBalFel_Click);
            // 
            // btnJobbFel
            // 
            this.btnJobbFel.Location = new System.Drawing.Point(553, 54);
            this.btnJobbFel.Name = "btnJobbFel";
            this.btnJobbFel.Size = new System.Drawing.Size(75, 23);
            this.btnJobbFel.TabIndex = 1;
            this.btnJobbFel.Text = "Jobbra, fel";
            this.btnJobbFel.UseVisualStyleBackColor = true;
            this.btnJobbFel.Click += new System.EventHandler(this.btnJobbFel_Click);
            // 
            // btnBalLe
            // 
            this.btnBalLe.Location = new System.Drawing.Point(80, 246);
            this.btnBalLe.Name = "btnBalLe";
            this.btnBalLe.Size = new System.Drawing.Size(75, 23);
            this.btnBalLe.TabIndex = 2;
            this.btnBalLe.Text = "Balra, le";
            this.btnBalLe.UseVisualStyleBackColor = true;
            this.btnBalLe.Click += new System.EventHandler(this.btnBalLe_Click);
            // 
            // btnJobbLe
            // 
            this.btnJobbLe.Location = new System.Drawing.Point(553, 245);
            this.btnJobbLe.Name = "btnJobbLe";
            this.btnJobbLe.Size = new System.Drawing.Size(75, 23);
            this.btnJobbLe.TabIndex = 3;
            this.btnJobbLe.Text = "Jobbra, le";
            this.btnJobbLe.UseVisualStyleBackColor = true;
            this.btnJobbLe.Click += new System.EventHandler(this.btnJobbLe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJobbLe);
            this.Controls.Add(this.btnBalLe);
            this.Controls.Add(this.btnJobbFel);
            this.Controls.Add(this.btnBalFel);
            this.Name = "MainForm";
            this.Text = "Sarokba ugrás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBalFel;
        private System.Windows.Forms.Button btnJobbFel;
        private System.Windows.Forms.Button btnBalLe;
        private System.Windows.Forms.Button btnJobbLe;
    }
}

