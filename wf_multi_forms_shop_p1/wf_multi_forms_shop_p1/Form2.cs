using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_multi_forms_shop_p1
{
    public partial class Form2 : Form
    {
        List<Product> products = new List<Product>();
        public Form2()
        {
            InitializeComponent();
            string jsonResult = File.ReadAllText("data.json");
            var peopleResult = JsonSerializer.Deserialize<List<Product>>(jsonResult);
            products = peopleResult?.ToList() ?? new List<Product>();
            listBox1.DataSource = products;
        }

        private void UpdateProductList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = products;
        }

        private void Serialize()
        {
            string json = JsonSerializer.Serialize(products);
            File.WriteAllText("data.json", json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            products.Remove(listBox1.SelectedItem as Product);
            UpdateProductList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                var product = form.Product;
                products.Add(product);
                UpdateProductList();
            }
            Serialize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(listBox1.SelectedItem as Product);
            form.ShowDialog();
            UpdateProductList();
            Serialize();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(listBox1.SelectedItem as Product, true);
            form.Show();
        }
    }
}
