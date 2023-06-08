namespace wf_multi_forms_shop_p1
{
    public partial class Form1 : Form
    {
        public Product Product { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Text = "New product";
            button1.Enabled = false;
        }

        public Form1(Product newProduct, bool read = false)
        {
            InitializeComponent();
            this.Product = newProduct;
            textBoxName.Text = newProduct.Name;
            comboBoxCountry.Text = newProduct.Country;
            numericUpDownPrice.Value = newProduct.Price;
            numericUpDownDiscount.Value = newProduct.DiscountPercent;
            numericUpDownQuantity.Value = newProduct.Quantity;
            button1.Enabled = false;
            if (read)
            {
                textBoxName.Enabled = false;
                comboBoxCountry.Enabled = false;
                numericUpDownDiscount.Enabled = false;
                numericUpDownPrice.Enabled = false;
                numericUpDownQuantity.Enabled = false;
                button1.Enabled = true;
            }
            this.Text = "Product " + Product.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Product == null)
                Product = new Product();
            Product.Name = textBoxName.Text;
            Product.Price = numericUpDownPrice.Value;
            Product.Quantity = (int)numericUpDownQuantity.Value;
            Product.Country = comboBoxCountry.Text;
            Product.DiscountPercent = (int)numericUpDownDiscount.Value;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void CheckedButton1()
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || comboBoxCountry.SelectedItem == null)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckedButton1();
        }
    }
}