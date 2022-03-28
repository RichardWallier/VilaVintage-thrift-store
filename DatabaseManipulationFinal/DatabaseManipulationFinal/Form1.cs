using WinFormsApp1.ProgramData;
using System.Data.SQLite;

namespace DatabaseManipulationFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tagIcon.Visible = false;
            tagLabel.Visible = false;
            tagTextBox.Visible = false;

            tagIcon.Location = new Point(379, 73);
            tagLabel.Location = new Point(411, 67);
            tagTextBox.Location = new Point(645, 67);

            descriptionIcon.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;

            brandIcon.Visible = false;
            brandLabel.Visible = false;
            brandTextBox.Visible = false;

            priceIcon.Visible = false;
            priceLabel.Visible = false;
            priceTextBox.Visible = false;

            detailsIcon.Visible = false;
            detailsLabel.Visible = false;
            detailsTextBox.Visible = false;

            dateINIcon.Visible = false;
            dateINLabel.Visible = false;
            dateINTextBox.Visible = false;

            dateOUTIcon.Visible = false;
            dateOUTLabel.Visible = false;
            dateOUTTextBox.Visible = false;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

            sellProductButton.Visible = false;
            addProductButton.Visible = false;
            attProductButton.Visible = false;
            removeProductButton.Visible = false;
            refreshSeeIconButton.Visible = false;

            checkLabel.Visible = false;
            soonLabel.Visible = false;

            BackColor = Color.FromArgb(160, 187, 172);
            bigPictureBox.Visible = true;

            sellPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            addPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            seeAllPageIconButton.BackColor = Color.FromArgb(160, 187, 172);

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        private void iconButton5_Click(object sender, EventArgs e)
        {
            checkLabel.Text = "";
            tagIcon.Visible = false;
            tagLabel.Visible = false;
            tagTextBox.Visible = false;

            tagIcon.Location = new Point(379, 73);
            tagLabel.Location = new Point(411, 67);
            tagTextBox.Location = new Point(645, 67);

            descriptionIcon.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;

            brandIcon.Visible = false;
            brandLabel.Visible = false;
            brandTextBox.Visible = false;

            priceIcon.Visible = false;
            priceLabel.Visible = false;
            priceTextBox.Visible = false;

            detailsIcon.Visible = false;
            detailsLabel.Visible = false;
            detailsTextBox.Visible = false;

            dateINIcon.Visible = false;
            dateINLabel.Visible = false;
            dateINTextBox.Visible = false;

            dateOUTIcon.Visible = false;
            dateOUTLabel.Visible = false;
            dateOUTTextBox.Visible = false;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

            sellProductButton.Visible = false;
            addProductButton.Visible = false;
            attProductButton.Visible = false;
            removeProductButton.Visible = false;
            refreshSeeIconButton.Visible = false;

            soonLabel.Visible = false;
            checkLabel.Visible = false;

            BackColor = Color.FromArgb(160, 187, 172);
            bigPictureBox.Visible = true;

            sellPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            addPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            seeAllPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
        }

        private void sellPageIconButton_Click(object sender, EventArgs e)
        {
            checkLabel.Text = "";
            tagIcon.Visible = true;
            tagLabel.Visible = true;
            tagTextBox.Visible = true;

            tagIcon.Location = new Point(379, 73);
            tagLabel.Location = new Point(411, 67);
            tagTextBox.Location = new Point(645, 67);

            descriptionIcon.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;

            brandIcon.Visible = false;
            brandLabel.Visible = false;
            brandTextBox.Visible = false;

            priceIcon.Visible = true;
            priceLabel.Visible = true;
            priceTextBox.Visible = true;

            priceIcon.Location = new Point(379, 124);
            priceLabel.Location = new Point(411, 118);
            priceTextBox.Location = new Point(645, 118);

            detailsIcon.Visible = false;
            detailsLabel.Visible = false;
            detailsTextBox.Visible = false;

            dateINIcon.Visible = false;
            dateINLabel.Visible = false;
            dateINTextBox.Visible = false;

            dateOUTIcon.Visible = true;
            dateOUTLabel.Visible = true;
            dateOUTTextBox.Visible = true;

            dateOUTIcon.Location = new Point(379, 175);
            dateOUTLabel.Location = new Point(411, 169);
            dateOUTTextBox.Location = new Point(645, 169);

            soonLabel.Visible = false;
            checkLabel.Visible = true;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

            sellProductButton.Visible = true;
            addProductButton.Visible = false;
            attProductButton.Visible = false;
            removeProductButton.Visible = false;
            refreshSeeIconButton.Visible = false;

            BackColor = Color.FromArgb(101, 117, 108);
            bigPictureBox.Visible = false;

            sellPageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            addPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            seeAllPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
        }

        private void addPageIconButton_Click(object sender, EventArgs e)
        {
            checkLabel.Text = "";
            tagIcon.Visible = true;
            tagLabel.Visible = true;
            tagTextBox.Visible = true;

            tagIcon.Location = new Point(379, 73);
            tagLabel.Location = new Point(411, 67);
            tagTextBox.Location = new Point(645, 67);

            descriptionIcon.Visible = true;
            descriptionLabel.Visible = true;
            descriptionTextBox.Visible = true;

            brandIcon.Visible = true;
            brandLabel.Visible = true;
            brandTextBox.Visible = true;

            priceIcon.Visible = true;
            priceLabel.Visible = true;
            priceTextBox.Visible = true;

            priceIcon.Location = new Point(379, 223);
            priceLabel.Location = new Point(411, 217);
            priceTextBox.Location = new Point(645, 217);

            detailsIcon.Visible = true;
            detailsLabel.Visible = true;
            detailsTextBox.Visible = true;

            dateINIcon.Visible = true;
            dateINLabel.Visible = true;
            dateINTextBox.Visible = true;

            dateOUTIcon.Visible = false;
            dateOUTLabel.Visible = false;
            dateOUTTextBox.Visible = false;

            dateOUTIcon.Location = new Point(379, 371);
            dateOUTLabel.Location = new Point(411, 370);
            dateOUTTextBox.Location = new Point(645, 370);

            soonLabel.Visible = false;
            checkLabel.Visible = true;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

            sellProductButton.Visible = false;
            addProductButton.Visible = true;
            attProductButton.Visible = false;
            removeProductButton.Visible = false;
            refreshSeeIconButton.Visible = false;

            BackColor = Color.FromArgb(101, 117, 108);
            bigPictureBox.Visible = false;

            addPageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            sellPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            seeAllPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
        }

        private void attPageIconButton_Click(object sender, EventArgs e)
        {
            checkLabel.Text = "";
            tagIcon.Visible = false;
            tagLabel.Visible = false;
            tagTextBox.Visible = false;

            tagIcon.Location = new Point(379, 73);
            tagLabel.Location = new Point(411, 67);
            tagTextBox.Location = new Point(645, 67);

            descriptionIcon.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;

            brandIcon.Visible = false;
            brandLabel.Visible = false;
            brandTextBox.Visible = false;

            priceIcon.Visible = false;
            priceLabel.Visible = false;
            priceTextBox.Visible = false;

            priceIcon.Location = new Point(379, 223);
            priceLabel.Location = new Point(411, 217);
            priceTextBox.Location = new Point(645, 217);

            detailsIcon.Visible = false;
            detailsLabel.Visible = false;
            detailsTextBox.Visible = false;

            dateINIcon.Visible = false;
            dateINLabel.Visible = false;
            dateINTextBox.Visible = false;

            dateOUTIcon.Visible = false;
            dateOUTLabel.Visible = false;
            dateOUTTextBox.Visible = false;

            dateOUTIcon.Location = new Point(379, 371);
            dateOUTLabel.Location = new Point(411, 370);
            dateOUTTextBox.Location = new Point(645, 370);

            soonLabel.Visible = true;
            checkLabel.Visible = false;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

            sellProductButton.Visible = false;
            addProductButton.Visible = false;
            attProductButton.Visible = false;
            removeProductButton.Visible = false;
            refreshSeeIconButton.Visible = false;

            soonLabel.Text = "EM BREVE!";

            BackColor = Color.FromArgb(101, 117, 108);
            bigPictureBox.Visible = false;

            attPageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            sellPageIconButton.BackColor    = Color.FromArgb(160, 187, 172);
            addPageIconButton.BackColor     = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor  = Color.FromArgb(160, 187, 172);
            seeAllPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
        }

        private void removePageIconButton_Click(object sender, EventArgs e)
        {
            checkLabel.Text = "";
            tagIcon.Visible = true;
            tagLabel.Visible = true;
            tagTextBox.Visible = true;

            tagIcon.Location = new Point(379, 419);
            tagLabel.Location = new Point(411, 415);
            tagTextBox.Location = new Point(645, 421);

            descriptionIcon.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;

            brandIcon.Visible = false;
            brandLabel.Visible = false;
            brandTextBox.Visible = false;

            priceIcon.Visible = false;
            priceLabel.Visible = false;
            priceTextBox.Visible = false;

            priceIcon.Location = new Point(379, 223);
            priceLabel.Location = new Point(411, 217);
            priceTextBox.Location = new Point(645, 217);

            detailsIcon.Visible = false;
            detailsLabel.Visible = false;
            detailsTextBox.Visible = false;

            dateINIcon.Visible = false;
            dateINLabel.Visible = false;
            dateINTextBox.Visible = false;

            dateOUTIcon.Visible = false;
            dateOUTLabel.Visible = false;
            dateOUTTextBox.Visible = false;

            dateOUTIcon.Location = new Point(379, 371);
            dateOUTLabel.Location = new Point(411, 370);
            dateOUTTextBox.Location = new Point(645, 370);

            soonLabel.Visible = false;
            checkLabel.Visible = true;

            dataGridView1.Visible = false;
            dataGridView2.Visible = true;

            sellProductButton.Visible = false;
            addProductButton.Visible = false;
            attProductButton.Visible = false;
            removeProductButton.Visible = true;
            refreshSeeIconButton.Visible = true;

            BackColor = Color.FromArgb(101, 117, 108);
            bigPictureBox.Visible = false;

            removePageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            sellPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            addPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            seeAllPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void seeAllIconButton_Click(object sender, EventArgs e)
        {
            checkLabel.Text = "";
            tagIcon.Visible = false;
            tagLabel.Visible = false;
            tagTextBox.Visible = false;

            descriptionIcon.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;

            brandIcon.Visible = false;
            brandLabel.Visible = false;
            brandTextBox.Visible = false;

            priceIcon.Visible = false;
            priceLabel.Visible = false;
            priceTextBox.Visible = false;

            priceIcon.Location = new Point(379, 223);
            priceLabel.Location = new Point(411, 217);
            priceTextBox.Location = new Point(645, 217);

            detailsIcon.Visible = false;
            detailsLabel.Visible = false;
            detailsTextBox.Visible = false;

            dateINIcon.Visible = false;
            dateINLabel.Visible = false;
            dateINTextBox.Visible = false;

            dateOUTIcon.Visible = false;
            dateOUTLabel.Visible = false;
            dateOUTTextBox.Visible = false;

            dateOUTIcon.Location = new Point(379, 371);
            dateOUTLabel.Location = new Point(411, 370);
            dateOUTTextBox.Location = new Point(645, 370);

            checkLabel.Visible = false;
            soonLabel.Visible = false;

            dataGridView1.Visible = true;
            dataGridView2.Visible = false;

            sellProductButton.Visible = false;
            addProductButton.Visible = false;
            attProductButton.Visible = false;
            removeProductButton.Visible = false;
            refreshSeeIconButton.Visible = true;

            BackColor = Color.FromArgb(101, 117, 108);
            bigPictureBox.Visible = false;

            seeAllPageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            sellPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            addPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor = Color.FromArgb(160, 187, 172);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            DatabaseControl data = new DatabaseControl();
            dataGridView1.DataSource = data.GetAllProducts();

            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = data.GetAllProducts();
        }

        private void sellProductButton_Click_1(object sender, EventArgs e)
        {
            DatabaseControl data = new DatabaseControl();
            if (tagTextBox.Text.Trim() == "" || priceTextBox.Text.Trim() == "" || dateOUTTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            string tag = tagTextBox.Text;
            string price = priceTextBox.Text;
            string dateOUT = dateOUTTextBox.Text;
            data.SellProduct(tag, price, dateOUT);

            tagTextBox.Text = "";
            priceTextBox.Text = "";
            dateOUTTextBox.Text = "";
            checkLabel.Text = $"Etiqueta {tag} vendida por {price}!";
        }

        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            checkLabel.Text = "";
            DatabaseControl data = new DatabaseControl();
            if (tagTextBox.Text.Trim() == "" || descriptionTextBox.Text.Trim() == "" ||
                brandTextBox.Text.Trim() == "" || priceTextBox.Text.Trim() == "" ||
                detailsTextBox.Text.Trim() == "" || dateINTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return ;
            }
            string tag = tagTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();
            string brand = brandTextBox.Text.Trim();
            string price = priceTextBox.Text.Trim();
            string details = detailsTextBox.Text.Trim();
            string dateIN = dateINTextBox.Text.Trim();

            data.AddProduct(tag, description, brand, price, details, dateIN);

            tagTextBox.Text = "";
            descriptionTextBox.Text = "";
            brandTextBox.Text = "";
            priceTextBox.Text = "";
            detailsTextBox.Text = "";
            dateINTextBox.Text = "";
            checkLabel.Text = $"Etiqueta {tag} adicionada!";
        }

        private void attProductButton_Click_1(object sender, EventArgs e)
        {
            /*
            DatabaseControl data = new DatabaseControl();
            string tag = tagTextBox.Text;
            string description = descriptionTextBox.Text;
            string brand = brandTextBox.Text;
            string price = priceTextBox.Text;
            string details = detailsTextBox.Text;
            string dateIN = dateINTextBox.Text;
            string dateOUT = dateINTextBox.Text;
            data.AttProduct(tag, description, brand, price, details, dateIN, dateOUT);


            tagTextBox.Text = "";
            descriptionTextBox.Text = "";
            brandTextBox.Text = "";
            priceTextBox.Text = "";
            detailsTextBox.Text = "";
            dateINTextBox.Text = "";
            checkLabel.Text = $"Etiqueta {tag} atualizada!";
            */
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            DatabaseControl data = new DatabaseControl();
            if (tagTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            string tag = tagTextBox.Text;
            data.RemoveProduct(tag);

            tagTextBox.Text = "";
            checkLabel.Text = $"Etiqueta {tag} removida!";
        }
    }
}