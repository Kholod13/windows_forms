using static wf_list_controls.Form1;

namespace wf_list_controls
{
    public partial class Form1 : Form
    {
        List<Car> cars = null;
        public Form1()
        {
            InitializeComponent();
            cars = new List<Car>()
            {
                new Car("Wolkswagen Touareg", "Silver", 2012, "UU 54394", "83JFB57RKE8F4HE2"),
                new Car("Reno Megan", "White", 2019, "DJ 34920",    "3458UF983FFH4UF4"),
                new Car("Toyota Corrola", "Orange", 2014, "OJ 18403", "209FJI4982F45923D"),
                new Car("VW Golf", "Blue", 2017, "UZ 69632", "2I0DMBAKFG58944R"),
                new Car("Kia Rio", "White", 2009, "UU 54394", "83JFB57RKE8F4HE2"),
                new Car("Daewoo Lanos", "Silver", 2006, "DJ 34920",    "3458UF983FFH4UF4"),
            };

            listBoxCars.DataSource = cars.ToList();
            comboBoxModelToFind.DataSource = cars.ToList();
            comboBoxModelToFind.DisplayMember = "ModelAndNumber";
        }

        public class Car
        {
            public string Color { get; set; }
            public string Model { get; set; }
            public string ModelAndNumber { get => $"{Model} {Number}"; }
            public int Year { get; set; }
            public string Number { get; set; }
            public string VINCode { get; set; }
            public Car(string model, string color, int year, string number, string vinCode)
            {
                Color = color;
                Model = model;
                Year = year;
                Number = number;
                VINCode = vinCode;
            }
            public override string ToString()
            {
                return $"{Model} {Color} - {Year} " +
                    $"Number: {Number}. VIN: {VINCode}.";
            }
        }

        private void UpdateCarsComboList()
        {
            listBoxCars.DataSource = null;
            listBoxCars.DataSource = cars.ToList();
        }
        private void UpdateCarsComboBox()
        {
            comboBoxModelToFind.DataSource = null;
            comboBoxModelToFind.DataSource = cars.ToList();
        }

        private void ClearFields()
        {
            textBoxYear.Clear();
            textBoxNumber.Clear();
            textBoxVIN.Clear();
            comboBoxModel.ResetText();
            comboBoxColor.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxModelToFind.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxModel.SelectedIndex != -1 &&
                comboBoxColor.SelectedIndex != -1 &&
                textBoxYear.Text != string.Empty &&
                textBoxNumber.Text != string.Empty &&
                textBoxVIN.Text != string.Empty)
            {
                cars.Add(new Car(comboBoxModel.Text, comboBoxColor.Text, int.Parse(textBoxYear.Text), textBoxNumber.Text, textBoxVIN.Text));
                UpdateCarsComboList();
                UpdateCarsComboBox();
                ClearFields();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("First, fill in all the details!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select user to remove!"); return;
            }

            cars.RemoveAt(listBoxCars.SelectedIndex);

            UpdateCarsComboList();
            UpdateCarsComboBox();
        }
    }
}