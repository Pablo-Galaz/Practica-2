using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        //Variables Globales
        string nombre,telefono,edad,procesador,ram,so,dd,da;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            procesador = comboBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             nombre = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ram = "2 GB";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ram = "4 GB";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ram = "8 GB";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                ram = "16 GB";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            so = checkedListBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = comboBox2.Text;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dd = checkedListBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            edad = textBox2.Text;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            procesador = comboBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            telefono = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FELICIDADES, COMPRA LLEVADA CON EXITO\n\n" +
                "El Nombre del Cliente es: " + nombre
                + "\nEl telefono del cliente es: " + telefono
                + "\nLa edad del cliente es: " + edad + " Años"
                + "\nSu procesador es : " + procesador
                + "\nSu memoria RAM es de : " + ram
                + "\nEl Sistema Operativo es: " + so
                + "\nEl disco duro es: " + dd
                + "\nSu archivo adicional es : " + da
                + "\n\n\n----------GRACIAS POR SU COMPRA----------");
        }
        
    }
}