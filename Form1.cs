using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void P_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void A_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultIMC, peso, altura;
            peso = double.Parse(P.Text);
            
            altura = double.Parse(A.Text);

            altura = (altura * altura);

            resultIMC = peso / altura;


            if (resultIMC <= 18.49)
            {
                MessageBox.Show("Magreza");
            }

            else if (resultIMC >= 18.50 && resultIMC <= 24.99)
            {
                MessageBox.Show("Peso Normal");
            }

            else if (resultIMC >= 25 && resultIMC <= 29.99)
            {
                MessageBox.Show("Acima do Peso");
            }
            else if (resultIMC >= 30 && resultIMC <= 34.99)
            {
                MessageBox.Show("Obesidade I");
            }

            else if (resultIMC >= 35 && resultIMC <= 39.99)
            {
                MessageBox.Show("Obesidade II");
            }

            else if (resultIMC >= 40)
            {
                MessageBox.Show("Obesidade III");
            }

            else { 
                MessageBox.Show("Consulte Um Medico Urgente !");
            }      
        }
    }                  
}           
