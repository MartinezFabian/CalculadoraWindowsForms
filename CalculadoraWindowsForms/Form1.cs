namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        string operandoUno;
        string operandoDos;
        char operador;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonUno_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "1";
            }
            else
            {
                lblPantalla.Text += "1"; 
            }
        }

        private void buttonDos_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "2";
            }
            else
            {
                lblPantalla.Text += "2";
            }
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "3";
            }
            else
            {
                lblPantalla.Text += "3";
            }
        }

        private void buttonCuatro_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "4";
            }
            else
            {
                lblPantalla.Text += "4";
            }
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "5";
            }
            else
            {
                lblPantalla.Text += "5";
            }
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "6";
            }
            else
            {
                lblPantalla.Text += "6";
            }
        }

        private void buttonSiete_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "7";
            }
            else
            {
                lblPantalla.Text += "7";
            }
        }

        private void buttonOcho_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "8";
            }
            else
            {
                lblPantalla.Text += "8";
            }
        }

        private void buttonNueve_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "9";
            }
            else
            {
                lblPantalla.Text += "9";
            }
        }

        private void buttonCero_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = "0";
            }
            else
            {
                lblPantalla.Text += "0";
            }
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += ",";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operandoUno = lblPantalla.Text.ToString();
            lblPantalla.Text = "";
            operador = '/';

            buttonResta.Enabled = false;
            buttonSuma.Enabled = false;
            buttonDiv.Enabled = false;
            buttonMult.Enabled = false;

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operandoUno = lblPantalla.Text.ToString();
            lblPantalla.Text = "";
            operador = 'x';

            buttonResta.Enabled = false;
            buttonSuma.Enabled = false;
            buttonDiv.Enabled = false;
            buttonMult.Enabled = false;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operandoUno = lblPantalla.Text.ToString();
            lblPantalla.Text = "";
            operador = '-';

            buttonResta.Enabled = false;
            buttonSuma.Enabled = false;
            buttonDiv.Enabled = false;
            buttonMult.Enabled = false;
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operandoUno = lblPantalla.Text.ToString();
            lblPantalla.Text = "";
            operador = '+';

            buttonResta.Enabled = false;
            buttonSuma.Enabled = false;
            buttonDiv.Enabled = false;
            buttonMult.Enabled = false;
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            operandoDos = lblPantalla.Text.ToString();
            lblPantalla.Text = "";

            float operandoUnoInt = float.Parse(operandoUno);
            float operandoDosInt = float.Parse(operandoDos);

            switch (operador)
            {
                case '+':
                    lblPantalla.Text = (operandoUnoInt + operandoDosInt).ToString();
                    break;
                case '-':
                    lblPantalla.Text = (operandoUnoInt - operandoDosInt).ToString();
                    break;
                case '/':
                    lblPantalla.Text = (operandoUnoInt / operandoDosInt).ToString();
                    break;
                case 'x':
                    lblPantalla.Text = (operandoUnoInt * operandoDosInt).ToString();
                    break;
            }

            buttonResta.Enabled = true;
            buttonSuma.Enabled = true;
            buttonDiv.Enabled = true;
            buttonMult.Enabled = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "0";

            buttonResta.Enabled = true;
            buttonSuma.Enabled = true;
            buttonDiv.Enabled = true;
            buttonMult.Enabled = true;
        }

        private void buttonCalcularConFechas_Click(object sender, EventArgs e)
        {
            Form2 calcularFechas = new Form2();
            calcularFechas.ShowDialog();
        }

    }
}