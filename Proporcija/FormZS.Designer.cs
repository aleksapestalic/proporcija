namespace Proporcija
{
    partial class FormZS
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
            this.tbZsBilo = new System.Windows.Forms.TextBox();
            this.tbZsSada = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bDoIt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbETA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTimeRemaining = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbZaJedanZS = new System.Windows.Forms.TextBox();
            this.lPoJednomSekundi = new System.Windows.Forms.Label();
            this.cbTotalMeasure = new System.Windows.Forms.CheckBox();
            this.tbRemainingHours = new System.Windows.Forms.TextBox();
            this.cbCountWhereCompletedZero = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbZsBilo
            // 
            this.tbZsBilo.Location = new System.Drawing.Point(102, 31);
            this.tbZsBilo.Name = "tbZsBilo";
            this.tbZsBilo.Size = new System.Drawing.Size(100, 20);
            this.tbZsBilo.TabIndex = 0;
            // 
            // tbZsSada
            // 
            this.tbZsSada.Location = new System.Drawing.Point(102, 57);
            this.tbZsSada.Name = "tbZsSada";
            this.tbZsSada.Size = new System.Drawing.Size(100, 20);
            this.tbZsSada.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2019, 9, 24, 20, 14, 48, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(208, 60);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2019, 9, 24, 20, 14, 42, 0);
            // 
            // bDoIt
            // 
            this.bDoIt.Location = new System.Drawing.Point(12, 152);
            this.bDoIt.Name = "bDoIt";
            this.bDoIt.Size = new System.Drawing.Size(387, 23);
            this.bDoIt.TabIndex = 6;
            this.bDoIt.Text = "Calculate";
            this.bDoIt.UseVisualStyleBackColor = true;
            this.bDoIt.Click += new System.EventHandler(this.bDoIt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Measurement 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Measurement 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbZsBilo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbZsSada);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 104);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulazni podaci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbRemainingHours);
            this.groupBox2.Controls.Add(this.tbETA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTimeRemaining);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbZaJedanZS);
            this.groupBox2.Controls.Add(this.lPoJednomSekundi);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izlazni podaci";
            // 
            // tbETA
            // 
            this.tbETA.ForeColor = System.Drawing.Color.DarkRed;
            this.tbETA.Location = new System.Drawing.Point(110, 85);
            this.tbETA.Name = "tbETA";
            this.tbETA.Size = new System.Drawing.Size(100, 20);
            this.tbETA.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(69, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ETA:";
            // 
            // tbTimeRemaining
            // 
            this.tbTimeRemaining.Location = new System.Drawing.Point(110, 59);
            this.tbTimeRemaining.Name = "tbTimeRemaining";
            this.tbTimeRemaining.Size = new System.Drawing.Size(100, 20);
            this.tbTimeRemaining.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(44, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remaining:";
            // 
            // tbZaJedanZS
            // 
            this.tbZaJedanZS.Location = new System.Drawing.Point(110, 33);
            this.tbZaJedanZS.Name = "tbZaJedanZS";
            this.tbZaJedanZS.Size = new System.Drawing.Size(100, 20);
            this.tbZaJedanZS.TabIndex = 9;
            // 
            // lPoJednomSekundi
            // 
            this.lPoJednomSekundi.AutoSize = true;
            this.lPoJednomSekundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPoJednomSekundi.Location = new System.Drawing.Point(22, 36);
            this.lPoJednomSekundi.Name = "lPoJednomSekundi";
            this.lPoJednomSekundi.Size = new System.Drawing.Size(82, 13);
            this.lPoJednomSekundi.TabIndex = 9;
            this.lPoJednomSekundi.Text = "Time for one zs:";
            // 
            // cbTotalMeasure
            // 
            this.cbTotalMeasure.AutoSize = true;
            this.cbTotalMeasure.Checked = true;
            this.cbTotalMeasure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTotalMeasure.Location = new System.Drawing.Point(12, 122);
            this.cbTotalMeasure.Name = "cbTotalMeasure";
            this.cbTotalMeasure.Size = new System.Drawing.Size(94, 17);
            this.cbTotalMeasure.TabIndex = 11;
            this.cbTotalMeasure.Text = "Calculate ETA";
            this.cbTotalMeasure.UseVisualStyleBackColor = true;
            this.cbTotalMeasure.CheckedChanged += new System.EventHandler(this.cbTotalMeasure_CheckedChanged);
            // 
            // tbRemainingHours
            // 
            this.tbRemainingHours.Location = new System.Drawing.Point(241, 59);
            this.tbRemainingHours.Name = "tbRemainingHours";
            this.tbRemainingHours.Size = new System.Drawing.Size(51, 20);
            this.tbRemainingHours.TabIndex = 14;
            // 
            // cbCountWhereCompletedZero
            // 
            this.cbCountWhereCompletedZero.AutoSize = true;
            this.cbCountWhereCompletedZero.Checked = true;
            this.cbCountWhereCompletedZero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCountWhereCompletedZero.Location = new System.Drawing.Point(114, 122);
            this.cbCountWhereCompletedZero.Name = "cbCountWhereCompletedZero";
            this.cbCountWhereCompletedZero.Size = new System.Drawing.Size(194, 17);
            this.cbCountWhereCompletedZero.TabIndex = 13;
            this.cbCountWhereCompletedZero.Text = "Measurement 2 equals remaining zs";
            this.cbCountWhereCompletedZero.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(216, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = " = ";
            // 
            // FormZS
            // 
            this.AcceptButton = this.bDoIt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 320);
            this.Controls.Add(this.cbCountWhereCompletedZero);
            this.Controls.Add(this.cbTotalMeasure);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bDoIt);
            this.Name = "FormZS";
            this.Text = "ZS Calc";
            this.Load += new System.EventHandler(this.FormZS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbZsBilo;
        private System.Windows.Forms.TextBox tbZsSada;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button bDoIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbZaJedanZS;
        private System.Windows.Forms.Label lPoJednomSekundi;
        private System.Windows.Forms.CheckBox cbTotalMeasure;
        private System.Windows.Forms.TextBox tbETA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTimeRemaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRemainingHours;
        private System.Windows.Forms.CheckBox cbCountWhereCompletedZero;
        private System.Windows.Forms.Label label5;
    }
}