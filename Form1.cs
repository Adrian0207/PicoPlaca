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

        private void btnPredicion_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([A-Z]){3,4}([0-9]){3}$";//Regular expressions for AAAA001, AAA001

            if (!Regex.IsMatch(txtPlaca.Text, pattern))
            {
                errorIcon.SetError(txtPlaca, "El ingreso de la placa es incorrecta");
                txtPlaca.Clear();
            }
            else
            {
                errorIcon.Clear();
            }
        }
    }
    }


}
