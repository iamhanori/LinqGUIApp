using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqGUIApp
{
    public partial class Form1 : Form
    {
        static private List<Product> products = new List<Product>()
        {
            new Product() { Name = "오븐", Price = 80000 },
            new Product() { Name = "웹캠", Price = 30000 },
            new Product() { Name = "스마트워치", Price = 250000 },
            new Product() { Name = "가방", Price = 80000 },
            new Product() { Name = "빔 프로젝터", Price = 170000 },
            new Product() { Name = "맥북", Price = 1500000 },
            new Product() { Name = "영양제", Price = 28900 },
            new Product() { Name = "칸쵸", Price = 1200 }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
