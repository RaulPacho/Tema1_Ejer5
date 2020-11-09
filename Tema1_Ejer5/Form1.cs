using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1_Ejer5
{
    public partial class Form1 : Form
    {
        string aux = "";
        bool escrito = false;
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = button1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = aux;
            textBox1.ForeColor = Color.Black;
            escrito = true;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {

                textBox1.Text = "Escribe aqui tu texto...";
                escrito = false;
                textBox1.ForeColor = Color.DimGray;
            }
            else
            {
                aux = textBox1.Text;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton*/
            DialogResult a;
            if (escrito)
            {
                a = MessageBox.Show("¿Quieres establecer \"" + textBox1.Text + "\" como titulo?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (a == DialogResult.Yes)
                {
                    this.Text = textBox1.Text;
                }
            }
            else
            {
                a = MessageBox.Show("No has escrito na", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }
    }
}
