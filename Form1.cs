using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_Aleatorio_JR
{


    public partial class Form1 : Form
    {
        int intentos = 0; //inicializar la Variable
        Random rand = new Random(); // Crea objeto que genere el numero aleatorio
        int aleatorio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intentos = 5;
            txtintentos.Text = intentos.ToString();
            aleatorio = rand.Next(1, 100); //aleatorio = numero entre 1 y 100
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txrnumero.Text, out int num))
            {
                if (num == aleatorio)
                {
                    MessageBox.Show($"Gano el juego. El numero es {aleatorio}");
                    DialogResult resultado = MessageBox.Show("¿Quiere volver a jugar?", "Resultado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        intentos = 5;
                        txtintentos.Text = intentos.ToString();
                        aleatorio = rand.Next(1, 100);
                    }
                }
                if (num > aleatorio)
                {
                    MessageBox.Show($"{num} es mayor al numero aleatorio");
                    intentos = intentos - 1;
                    txtintentos.Text = intentos.ToString();
                }
                if (num < aleatorio)
                {
                    MessageBox.Show($"{num} es menor al numero aleatorio");
                    intentos--;
                    txtintentos.Text = intentos.ToString();
                }
                if (intento)
                {

                }
            }
            else
            {
                MessageBox.Show("ingrese el numero valido");
            }
        }
    }
}
