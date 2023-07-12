using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Parcial2.Repositorioproducto;
using static Parcial2.Repositorioproveedores;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void CargarProvedor_Click(object sender, EventArgs e)
        {
            private void btnAgregarProducto_Click(object sender, EventArgs e)
            {
                var dataGridView1_CellContentClick = nFom1(repositorioProductos, repositorioCategorias);
                dataGridView1_CellContentClick.ShowDialog();
           
            }
        }

        private void dtcProvedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ActualizarGrillas()
        {
            dtcProvedor.DataSource = null;
            dtcProvedor.DataSource = Repositorioproveedor.Listar();
            dtvPorducto.DataSource = null;
            dtvPorducto.DataSource = Repositorioproducto.Listar();
        }
}
