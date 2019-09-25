﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proporcija
{
    public partial class FormZS : Form
    {
        public FormZS()
        {
            InitializeComponent();
        }

        private void FormZS_Load(object sender, EventArgs e)
        {
            if (cbTotalMeasure.Checked)
            {
                lSumOfZs.Show();
                tbSumOfZs.Show();
            }
            else
            {
                lSumOfZs.Hide();
                tbSumOfZs.Hide();
            }

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd. MM. yyyy. | HH:mm:ss";
            dateTimePicker1.Value = DateTime.Now;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd. MM. yyyy. | HH:mm:ss";
            dateTimePicker2.Value = DateTime.Now;
        }

        private void bDoIt_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;
                //MessageBox.Show(diff.TotalMinutes.ToString());
                double timeElapsed = diff.TotalMinutes; //time elapsed between measurements

                double zsBilo = double.Parse(tbZsBilo.Text);
                double zsSada = double.Parse(tbZsSada.Text);

                /*
                 * bilo-sada .... timeEl
                 * 1............. X
                 * */

                /*
                 * bms:1 = timeEl:X
                 * timeEl=bms*X
                 * 6=2*x
                 * X = timeEl/bms
                 * */

                double minutaZaJednog = timeElapsed / (zsBilo - zsSada);
                double satiZaJednog = minutaZaJednog / 60;
                double danaZaJednog = satiZaJednog / 24;

                tbZaJedanZS.Text = (minutaZaJednog * 60).ToString("0.00") + "s";

                double sumOfZs = double.Parse(tbSumOfZs.Text);
                double timeRemaining = minutaZaJednog * sumOfZs;
                tbTimeRemaining.Text = timeRemaining.ToString("0.00") + "min";

                DateTime ETA = DateTime.Now;
                ETA = ETA.AddMinutes(timeRemaining);
                tbETA.Text = ETA.ToString("dd. MM. | HH:mm:ss");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Check data entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }         

        }

        private void cbTotalMeasure_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTotalMeasure.Checked)
            {
                lSumOfZs.Show();
                tbSumOfZs.Show();
            }
            else
            {
                lSumOfZs.Hide();
                tbSumOfZs.Hide();
            }
        }
    }
}