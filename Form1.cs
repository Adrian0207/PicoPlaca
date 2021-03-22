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
        /// Determine wheter the rush hour applied
        /// </summary>
        /// <returns></returns>
        private bool AplicaHora()
        {
            byte minManana = 7, minTarde = 16, maxManana = 9, maxTarde = 19, minutos = 30;
            if (
                dtpHora.Value.Hour >= minManana &&
                (dtpHora.Value.Hour <= maxManana && dtpHora.Value.Minute <= minutos) ||
                dtpHora.Value.Hour >= minTarde &&
                (dtpHora.Value.Hour <= maxTarde && dtpHora.Value.Minute <= minutos)
                )
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Display a message in a dialog window depending on the bool parameter
        /// </summary>
        /// <param name="aplicaPico"></param>
        /// <param name="mensaje"></param>
        private void Mensaje(bool aplicaPico, string mensaje)
        {
            if(aplicaPico)
                MessageBox.Show(mensaje, "Pico&Placa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                MessageBox.Show(mensaje, "Pico&Placa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPredicion_Click(object sender, EventArgs e)
        {
            string ultimoDigito = txtPlaca.Text.Substring(txtPlaca.Text.Length - 1);
            string mensaje = "Puede circular hoy todo el día";
            bool aplicaPico = true;

            #region Prediction
            switch (ultimoDigito)
            {
                case "1":
                case "2":
                    if (cbxDia.SelectedItem.ToString().Equals("Lunes"))
                        if (AplicaHora())
                        {
                            mensaje = "No puede circular a esta hora";
                            aplicaPico = false;
                        }
                        else
                        {
                            mensaje = "Puede circular a esta hora";
                        } 
                    break;

                case "3":
                case "4":
                    if (cbxDia.SelectedItem.ToString().Equals("Martes"))
                        if (AplicaHora())
                        {
                            mensaje = "No puede circular a esta hora";
                            aplicaPico = false;
                        }
                        else
                        {
                            mensaje = "Puede circular a esta hora";
                        }
                    break;

                case "5":
                case "6":
                    if (cbxDia.SelectedItem.ToString().Equals("Miércoles"))
                        if (AplicaHora())
                        {
                            mensaje = "No puede circular a esta hora";
                            aplicaPico = false;
                        }
                        else
                        {
                            mensaje = "Puede circular a esta hora";
                        }
                    break;

                case "7":
                case "8":
                    if (cbxDia.SelectedItem.ToString().Equals("Jueves"))
                        if (AplicaHora())
                        {
                            mensaje = "No puede circular a esta hora";
                            aplicaPico = false;
                        }
                        else
                        {
                            mensaje = "Puede circular a esta hora";
                        }
                    break;

                case "9":
                case "0":
                    if (cbxDia.SelectedItem.ToString().Equals("Viernes"))
                        if (AplicaHora())
                        {
                            mensaje = "No puede circular a esta hora";
                            aplicaPico = false;
                        }
                        else
                        {
                            mensaje = "Puede circular a esta hora";
                        }
                    break;
                default:
                    break;
            }
            #endregion

            Mensaje(aplicaPico, mensaje);

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



