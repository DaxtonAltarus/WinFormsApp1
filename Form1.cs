using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog1.FileName;
                foto1.Image = Image.FromFile(imagen);
            }
            else {
                MessageBox.Show("No se selecciono ninguna fotografia");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = dataGridView1.Rows.Add();
            dataGridView1.Rows[m].Cells[0].Value = nombre.Text;
            dataGridView1.Rows[m].Cells[1].Value = comboBox1.SelectedItem;
            dataGridView1.Rows[m].Cells[2].Value = dateTimePicker1.Value;
            nombre.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void foto1_Click(object sender, EventArgs e)
        {

        }
    }
}
