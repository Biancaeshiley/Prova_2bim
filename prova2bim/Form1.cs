using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova2bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tx_salariot_Click(object sender, EventArgs e)
        {

            double resultado = 0;
            double salariot = Convert.ToDouble(tx_salariot);
            double salario = Convert.ToDouble(tx_salario);
            int med = Convert.ToInt16(ToString());
            int TI;
            int ADM; 

            if (salario > 5600)
            {
                resultado = salariot * (-17);
                Console.WriteLine($"Salário é = {resultado}");
            }

            else 
            {
                salario = salariot * 15 + 200;
                Console.WriteLine($"Salário é = {salario}");
            }

           
            if (salario == med)
            {
                resultado = salario * 20;
                Console.WriteLine($"Salário é = {resultado}");
            }

        }

        private void com_funcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
