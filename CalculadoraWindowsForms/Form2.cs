using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Form2 : Form
    {
        DateTime fechaUno;
        DateTime fechaDos;
        TimeSpan resultado;

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";

            fechaUno = dateTimePicker1.Value;
            fechaDos = dateTimePicker2.Value;

            int resultadoDias = 0;

            resultado = fechaUno - fechaDos;
            resultadoDias = resultado.Days;
            labelResultado.Text = resultadoDias.ToString() + " días de diferencia.";
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
