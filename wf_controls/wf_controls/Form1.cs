namespace wf_controls
{
   
    public partial class Form1 : Form
    {
        public int sum1, sum2, sum3;
        public Form1()
        {
            InitializeComponent();
            Button1.Enabled= false;
        }

        private void CheckButtonEnabled()
        {
            if (sum1 > 0 && sum2 > 0 && sum3 > 0)
            {
                Button1.Enabled = true;
            }
            else
            {
                Button1.Enabled = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sum1 = 11;
            CheckButtonEnabled();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sum1 = 12;
            CheckButtonEnabled();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sum1 = 3;
            CheckButtonEnabled();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            sum1 = 8;
            CheckButtonEnabled();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            sum2 = 28;
            CheckButtonEnabled();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            sum3 = 10;
            CheckButtonEnabled();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            sum2 = 32;
            CheckButtonEnabled();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            sum2 = 44;
            CheckButtonEnabled();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            sum2 = 24;
            CheckButtonEnabled();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            sum2 = 30;
            CheckButtonEnabled();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            sum3 = 15;
            CheckButtonEnabled();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            sum3 = 22;
            CheckButtonEnabled();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            sum3 = 40;
            CheckButtonEnabled();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            sum3 = 24;
            CheckButtonEnabled();
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (sum1 > 0 && sum2 > 0 && sum3 > 0)
            {
                int summ = sum1 + sum2 + sum3;
                MessageBox.Show($"Sum = {summ}");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sum1 = 15;
            CheckButtonEnabled();
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}