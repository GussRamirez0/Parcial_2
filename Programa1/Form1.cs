using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            
            if (!double.TryParse(txtmonto.Text, out double montoInicial) ||
                !double.TryParse(txtint.Text, out double tasaInteres) ||
                !int.TryParse(txtperi.Text, out int periodo))
            {
                return;
            }

            
            double capitalFinal = montoInicial * Math.Pow((1 + tasaInteres / 100), periodo);
            double interesesAcumulados = capitalFinal - montoInicial;

            
            txtcap.Text = capitalFinal.ToString("0.00");
            txtacu.Text = interesesAcumulados.ToString("0.00");
        }
    }
}
