using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PicoPlaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display a message in a dialog window depending on the bool parameter
        /// </summary>
        /// <param name="aplicaPico"></param>
        private void Mensaje(bool aplicaPico)
        {
            if(aplicaPico)
                MessageBox.Show("Puede circular", "Pico y Placa", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            else
                MessageBox.Show("NO Puede circular", "Pico y Placa", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
        }

        private void btnPredicion_Click(object sender, EventArgs e)
        {
            string ultimoDigito = txtPlaca.Text.Substring(txtPlaca.Text.Length - 1);
            int hora = Convert.ToInt32(
                dtpHora.Value.Hour.ToString() + dtpHora.Value.Minute.ToString());
            bool aplicaPico = true;

            #region Prediction
            switch (ultimoDigito)
            {
                case "1":
                case "2":
                    if (cbxDia.SelectedItem.ToString().Equals("Lunes"))
                        if (dtpHora.Value.Hour >= 7 &&
                            (dtpHora.Value.Hour <= 9 && dtpHora.Value.Minute <= 30) ||
                            dtpHora.Value.Hour >= 16 &&
                            (dtpHora.Value.Hour <= 19 && dtpHora.Value.Minute <= 30))
                                aplicaPico = false;
                    break;

                case "3":
                case "4":
                    if (cbxDia.SelectedItem.ToString().Equals("Martes"))
                        if (dtpHora.Value.Hour >= 7 &&
                            (dtpHora.Value.Hour <= 9 && dtpHora.Value.Minute <= 30) ||
                            dtpHora.Value.Hour >= 16 &&
                            (dtpHora.Value.Hour <= 19 && dtpHora.Value.Minute <= 30))
                            aplicaPico = false;
                    break;

                case "5":
                case "6":
                    if (cbxDia.SelectedItem.ToString().Equals("Miércoles"))
                        if (dtpHora.Value.Hour >= 7 &&
                            (dtpHora.Value.Hour <= 9 && dtpHora.Value.Minute <= 30) ||
                            dtpHora.Value.Hour >= 16 &&
                            (dtpHora.Value.Hour <= 19 && dtpHora.Value.Minute <= 30))
                            aplicaPico = false;
                    break;

                case "7":
                case "8":
                    if (cbxDia.SelectedItem.ToString().Equals("Jueves"))
                        if (dtpHora.Value.Hour >= 7 &&
                            (dtpHora.Value.Hour <= 9 && dtpHora.Value.Minute <= 30) ||
                            dtpHora.Value.Hour >= 16 &&
                            (dtpHora.Value.Hour <= 19 && dtpHora.Value.Minute <= 30))
                            aplicaPico = false;
                    break;

                case "9":
                case "0":
                    if (cbxDia.SelectedItem.ToString().Equals("Viernes"))
                        if (dtpHora.Value.Hour >= 7 &&
                            (dtpHora.Value.Hour <= 9 && dtpHora.Value.Minute <= 30) ||
                            dtpHora.Value.Hour >= 16 &&
                            (dtpHora.Value.Hour <= 19 && dtpHora.Value.Minute <= 30))
                            aplicaPico = false;
                    break;

                default:
                    break;
            }
            #endregion

            Mensaje(aplicaPico);

        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([A-Z]){3,4}([0-9]){3}$";//Regular expressions for AAAA001, AAA001

            if (!Regex.IsMatch(txtPlaca.Text, pattern))
            {
                errorIcon.SetError(txtPlaca, 
                    "El ingreso de la placa es incorrecta, Formato AAAA001 o AAA001");
                txtPlaca.Clear();
            }
            else
            {
                errorIcon.Clear();
            }
        }
    }
}



