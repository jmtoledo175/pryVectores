using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVectores
{
    public partial class fmrVectores : Form
    {
        public fmrVectores()
        {
            InitializeComponent();
        }

        Int32[] Numero = new Int32[50];
        Int32 indice = 0;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (indice < Numero.Length) {
                Numero[indice] = Convert.ToInt32(txtNumero.Text);
                indice++;
                MessageBox.Show("Datos cargados");
                txtNumero.Text = "";
            }
            else
            {
                MessageBox.Show("No se pueden cargar mas datos");
            }

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            Int32 Total = 0;
            for (int i = 0; i < indice; i++)
            {
                lstDatos.Items.Add(Numero[i]);
                Total += Numero[i];
            }
            txtResultado.Text = Total.ToString();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            int i = 0;
            Int32 Total = 0;
            while (i < indice)
            {
                lstDatos.Items.Add(Numero[i]);
                Total += Numero[i];
                i++;
            }
            txtResultado.Text = Total.ToString();
        }
    }
}
