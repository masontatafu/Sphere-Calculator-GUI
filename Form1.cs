// Name: Mason Tatafu
// Lab: Lab 3
// Course: CIS199-50-4242
// Grading ID: S2407

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = radius_box.Text; // here I am assigning variable userinput to the users input
            double radius = Double.Parse(userinput); // I am now changing userinput to type double
            double diameter; // initializing data types to variables
            double surface_area;
            double volume;

            diameter = Math.Round(2 * radius, 2); // diameter calculation
            surface_area = Math.Round(4 * Math.PI * Math.Pow(radius, 2), 2); // SA calculation
            volume = Math.Round((4 * Math.PI * Math.Pow(radius, 3)) / 3, 2); // volume calculation

            diameterbox.Text = diameter.ToString(); // assigning diameter value to diameter box
            surface_area_box.Text = surface_area.ToString(); //assigning sa value to sa box
            volume_box.Text = volume.ToString(); // assigning vol value to vol box


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
