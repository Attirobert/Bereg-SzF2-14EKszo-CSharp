
namespace Halmazok
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
            this.lbxA = new System.Windows.Forms.ListBox();
            this.lbxB = new System.Windows.Forms.ListBox();
            this.lbxAuB = new System.Windows.Forms.ListBox();
            this.lbxAmB = new System.Windows.Forms.ListBox();
            this.lbxA_B = new System.Windows.Forms.ListBox();
            this.lbxB_A = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.btnGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxA
            // 
            this.lbxA.FormattingEnabled = true;
            this.lbxA.Location = new System.Drawing.Point(22, 36);
            this.lbxA.Name = "lbxA";
            this.lbxA.Size = new System.Drawing.Size(92, 316);
            this.lbxA.TabIndex = 0;
            // 
            // lbxB
            // 
            this.lbxB.FormattingEnabled = true;
            this.lbxB.Location = new System.Drawing.Point(153, 36);
            this.lbxB.Name = "lbxB";
            this.lbxB.Size = new System.Drawing.Size(92, 316);
            this.lbxB.TabIndex = 0;
            // 
            // lbxAuB
            // 
            this.lbxAuB.FormattingEnabled = true;
            this.lbxAuB.Location = new System.Drawing.Point(284, 36);
            this.lbxAuB.Name = "lbxAuB";
            this.lbxAuB.Size = new System.Drawing.Size(92, 316);
            this.lbxAuB.TabIndex = 0;
            // 
            // lbxAmB
            // 
            this.lbxAmB.FormattingEnabled = true;
            this.lbxAmB.Location = new System.Drawing.Point(415, 36);
            this.lbxAmB.Name = "lbxAmB";
            this.lbxAmB.Size = new System.Drawing.Size(92, 316);
            this.lbxAmB.TabIndex = 0;
            // 
            // lbxA_B
            // 
            this.lbxA_B.FormattingEnabled = true;
            this.lbxA_B.Location = new System.Drawing.Point(546, 36);
            this.lbxA_B.Name = "lbxA_B";
            this.lbxA_B.Size = new System.Drawing.Size(92, 316);
            this.lbxA_B.TabIndex = 0;
            // 
            // lbxB_A
            // 
            this.lbxB_A.FormattingEnabled = true;
            this.lbxB_A.Location = new System.Drawing.Point(677, 36);
            this.lbxB_A.Name = "lbxB_A";
            this.lbxB_A.Size = new System.Drawing.Size(92, 316);
            this.lbxB_A.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "A unio B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "A metszet B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "A - B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "B - A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Generálandó elemek száma:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "\"A\" halmaz: ";
            // 
            // nudA
            // 
            this.nudA.Location = new System.Drawing.Point(98, 400);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(80, 20);
            this.nudA.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "\"B\" halmaz: ";
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(267, 400);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(80, 20);
            this.nudB.TabIndex = 4;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(389, 399);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Generálj!";
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxB_A);
            this.Controls.Add(this.lbxAuB);
            this.Controls.Add(this.lbxA_B);
            this.Controls.Add(this.lbxAmB);
            this.Controls.Add(this.lbxB);
            this.Controls.Add(this.lbxA);
            this.Name = "MainForm";
            this.Text = "Halmazok";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxA;
        private System.Windows.Forms.ListBox lbxB;
        private System.Windows.Forms.ListBox lbxAuB;
        private System.Windows.Forms.ListBox lbxAmB;
        private System.Windows.Forms.ListBox lbxA_B;
        private System.Windows.Forms.ListBox lbxB_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Button btnGen;
    }
}

