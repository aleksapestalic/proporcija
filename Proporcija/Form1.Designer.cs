namespace Proporcija
{
    partial class Form1
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
            this.tbLG = new System.Windows.Forms.TextBox();
            this.tbDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDoIt = new System.Windows.Forms.Button();
            this.lRes = new System.Windows.Forms.Label();
            this.rbDir = new System.Windows.Forms.RadioButton();
            this.rbObr = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zsCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLG
            // 
            this.tbLG.Location = new System.Drawing.Point(23, 39);
            this.tbLG.Name = "tbLG";
            this.tbLG.Size = new System.Drawing.Size(47, 20);
            this.tbLG.TabIndex = 0;
            // 
            // tbDG
            // 
            this.tbDG.Location = new System.Drawing.Point(167, 39);
            this.tbDG.Name = "tbDG";
            this.tbDG.Size = new System.Drawing.Size(47, 20);
            this.tbDG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = ". . . . . . . . . .";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = ". . . . . . . . . .";
            // 
            // tbLD
            // 
            this.tbLD.Location = new System.Drawing.Point(23, 75);
            this.tbLD.Name = "tbLD";
            this.tbLD.Size = new System.Drawing.Size(47, 20);
            this.tbLD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDG);
            this.groupBox1.Controls.Add(this.tbLD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Params";
            // 
            // bDoIt
            // 
            this.bDoIt.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bDoIt.Location = new System.Drawing.Point(12, 201);
            this.bDoIt.Name = "bDoIt";
            this.bDoIt.Size = new System.Drawing.Size(232, 23);
            this.bDoIt.TabIndex = 9;
            this.bDoIt.Text = "Calculate X";
            this.bDoIt.UseVisualStyleBackColor = true;
            this.bDoIt.Click += new System.EventHandler(this.bDoIt_Click);
            // 
            // lRes
            // 
            this.lRes.AutoSize = true;
            this.lRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRes.Location = new System.Drawing.Point(100, 246);
            this.lRes.Name = "lRes";
            this.lRes.Size = new System.Drawing.Size(51, 20);
            this.lRes.TabIndex = 8;
            this.lRes.Text = "X = ?";
            // 
            // rbDir
            // 
            this.rbDir.AutoSize = true;
            this.rbDir.Checked = true;
            this.rbDir.Location = new System.Drawing.Point(12, 39);
            this.rbDir.Name = "rbDir";
            this.rbDir.Size = new System.Drawing.Size(114, 17);
            this.rbDir.TabIndex = 10;
            this.rbDir.TabStop = true;
            this.rbDir.Text = "Direktna proporcija";
            this.rbDir.UseVisualStyleBackColor = true;
            // 
            // rbObr
            // 
            this.rbObr.AutoSize = true;
            this.rbObr.Location = new System.Drawing.Point(132, 39);
            this.rbObr.Name = "rbObr";
            this.rbObr.Size = new System.Drawing.Size(112, 17);
            this.rbObr.TabIndex = 11;
            this.rbObr.Text = "Obrnuta proporcija";
            this.rbObr.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zsCalcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(257, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zsCalcToolStripMenuItem
            // 
            this.zsCalcToolStripMenuItem.Name = "zsCalcToolStripMenuItem";
            this.zsCalcToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.zsCalcToolStripMenuItem.Text = "zs calc";
            this.zsCalcToolStripMenuItem.Click += new System.EventHandler(this.zsCalcToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bDoIt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 287);
            this.Controls.Add(this.rbObr);
            this.Controls.Add(this.rbDir);
            this.Controls.Add(this.lRes);
            this.Controls.Add(this.bDoIt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Proporcija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLG;
        private System.Windows.Forms.TextBox tbDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDoIt;
        private System.Windows.Forms.Label lRes;
        private System.Windows.Forms.RadioButton rbDir;
        private System.Windows.Forms.RadioButton rbObr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zsCalcToolStripMenuItem;
    }
}

