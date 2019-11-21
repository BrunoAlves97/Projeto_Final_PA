using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_PA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar ", "Retornar a HOME", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
            if(escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Digite o codigo de barras")
            {
                textBox1.Text = " ";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "Digite o codigo de barras")
            {
                textBox1.Text = " ";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarras, nome, descricao, preco, estoque, unidade, tipo;
                codBarras = textBox1.Text;
                nome = textBox2.Text;
                descricao = textBox3.Text;
                preco = textBox7.Text;
                estoque = textBox6.Text;
                unidade = textBox5.Text;
                tipo = textBox4.Text;

                if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Digite o código de barras" )/* se campo for nulo, branco retorna verdadeiro*/
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error); 
            }
        }
    }
}
