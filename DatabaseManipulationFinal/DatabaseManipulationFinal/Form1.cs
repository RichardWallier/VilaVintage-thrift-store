using WinFormsApp1.ProgramData;

namespace DatabaseManipulationFinal
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

        private void addProduct_Click(object sender, EventArgs e)
        {
            string tag = tagTextBox.Text;
            string description = descriptionTextBox.Text;
            string brand = brandTextBox.Text;
            double price = Double.Parse(priceTextBox.Text);
            string details = detailsTextBox.Text;
            string dateIN = dateINTextBox.Text;
            DatabaseControl data = new DatabaseControl();
            data.AddProduct(tag, description, brand, price, details, dateIN);
        }

        private void sellProduct_Click(object sender, EventArgs e)
        {
            string tag = tagTextBox.Text;
            double price = Double.Parse(priceTextBox.Text);
            string dateOUT = dateOUTTextBox.Text;
            DatabaseControl data = new DatabaseControl();
            data.SellProduct(tag, price, dateOUT);
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            string tag = tagTextBox.Text;
            DatabaseControl data = new DatabaseControl();
            data.RemoveProduct(tag);
        }

        private void createDbButton_Click(object sender, EventArgs e)
        {
            DatabaseControl data = new DatabaseControl();
            data.CreateTable();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "/database.db";
            label6.Text = path;
        }
    }
}