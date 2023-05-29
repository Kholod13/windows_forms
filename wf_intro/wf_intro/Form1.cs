namespace wf_intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            int rand = random.Next(101);
            int max = 100;
            int min = 0;
            bool ind = true;
            do
            {

                var mainRes = MessageBox.Show($"{rand}, Це ваше число?", "Підтвердження", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (mainRes == DialogResult.Yes)
                {
                    var end = MessageBox.Show($"Кінець, зіграти ще раз?", "Підтвердження", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    
                    if(end == DialogResult.Yes)
                    {

                    }
                    else if (end == DialogResult.No)
                    {
                        ind = false;
                    }
                }
                else if (mainRes == DialogResult.No)
                {
                    var straight = MessageBox.Show("Ваше число більше?", "Підтвердження",
                        MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (straight == DialogResult.Yes)
                    {
                        min = rand;
                        rand = random.Next(min, 101);

                    }
                    else if (straight == DialogResult.No)
                    {
                        max = rand;
                        rand = random.Next(max + 1);

                    }
                }

            } while (ind == true);
        }
    }
}