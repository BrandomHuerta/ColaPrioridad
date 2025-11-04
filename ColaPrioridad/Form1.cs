using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaPrioridad
{
    public partial class Form1 : Form
    {
        private ColaPrioridad cola = new ColaPrioridad();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor) && int.TryParse(txtPrioridad.Text, out int prioridad))
            {
                cola.Encolar(new ElementoPrioridad(valor, prioridad));
                txtEstado.Text = cola.Mostrar();
                txtValor.Clear();
                txtPrioridad.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            try
            {
                var eliminado = cola.Desencolar();
                MessageBox.Show($"Elemento eliminado: {eliminado}");
                txtEstado.Text = cola.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}