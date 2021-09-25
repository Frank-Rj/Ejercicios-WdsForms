using Notas_WindowsForms.Entidades;
using Notas_WindowsForms.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas_WindowsForms
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notas nota = new Notas();
            NClsNotas clsnotas = new NClsNotas();

            nota.Lab1 = double.Parse(txtlab1.Text);
            nota.Parcial1 = double.Parse(txtparcial1.Text);

            nota.Lab2 = double.Parse(txtlab2.Text);
            nota.Parcial2 = double.Parse(txtparcial2.Text);

            nota.Lab3 = double.Parse(txtlab3.Text);
            nota.Parcial3 = double.Parse(txtparcial3.Text);

            txtPeriodo1.Text = clsnotas.Periodo1(nota);
            txtPeriodo2.Text = clsnotas.Periodo2(nota);
            txtPeriodo3.Text = clsnotas.Periodo3(nota);
            txtPromedio.Text = clsnotas.Promedio(nota);

            MessageBox.Show("Nota Periodo I: " + clsnotas.Periodo1(nota)+
                "\nNota Periodo II: " + clsnotas.Periodo2(nota) +
                "\nNota Periodo III: " + clsnotas.Periodo3(nota) +
                "\nPromedio del Ciclo: " + clsnotas.Promedio(nota));
        }
    }
}
