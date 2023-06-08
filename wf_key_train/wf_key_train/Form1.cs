namespace wf_key_train
{
    public partial class Form1 : Form
    {
        private int time = 0;
        List<string> textes = new List<string>();
        private string text;
        public Form1()
        {
            InitializeComponent();
            string tmp = "The TextReader class is an abstract class. Therefore, you do not instantiate it in your code. The StreamReader class derives from TextReader and provides implementations of the members for reading from a stream. The following example shows how to read all the characters in a file by using ";
            var words = tmp.Split(new[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Where(word => !string.IsNullOrWhiteSpace(word));
            foreach (string word in words)
            {
                textes.Add(word);
            }
            numericUpDown1.Maximum = textes.Count;
        }

        private void ClearBeforeNewGame()
        {
            textBoxInput.Clear();
            textBoxOutput.Clear();
            progressBar1.Value = 0;
            timer1.Stop();
            time = 0;
        }

        private void textBoxInput_TextChangedWithRegister(object sender, EventArgs e)
        {
            int correctLetter = 0;
            bool isMistake = false;
            for (int i = 0; i < text.Length && i < textBoxInput.Text.Length; i++)
            {
                if (text[i] == textBoxInput.Text[i])
                    ++correctLetter;
                else
                    isMistake = true;
            }
            if (isMistake)
                textBoxInput.ForeColor = Color.Red;
            else textBoxInput.ForeColor = Color.Black;

            progressBar1.Value = (int)(correctLetter / (float)text.Length * 100.0);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                MessageBox.Show($"Your result {text.Length} symbols per {time} sec.");
                ClearBeforeNewGame();
            }
        }

        private void textBoxInput_TextChangedWithoutRegister(object sender, EventArgs e)
        {
            int correctLetter = 0;
            bool isMistake = false;
            for (int i = 0; i < text.Length && i < textBoxInput.Text.Length; i++)
            {
                if (char.ToLower(text[i]) == char.ToLower(textBoxInput.Text[i]))
                    ++correctLetter;
                else
                    isMistake = true;
            }
            if (isMistake)
                textBoxInput.ForeColor = Color.Red;
            else textBoxInput.ForeColor = Color.Black;

            progressBar1.Value = (int)(correctLetter / (float)text.Length * 100.0);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                MessageBox.Show($"Your result {text.Length} symbols per {time} sec.");
                ClearBeforeNewGame();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBeforeNewGame();
            if ((int)numericUpDown1.Value == 0)
                return;
            textes = textes.OrderBy(x => Guid.NewGuid()).ToList();
            decimal numberOfWords = numericUpDown1.Value;
            string text = string.Join(" ", textes.Take((int)numberOfWords));
            textBoxOutput.Text = text;
            this.text = text;
            if (radioButtonYes.Checked)
                textBoxInput.TextChanged += textBoxInput_TextChangedWithRegister;
            else if ((radioButtonNo.Checked))
                textBoxInput.TextChanged += textBoxInput_TextChangedWithoutRegister;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = $"Time: {time++}s";
        }
    }
}