using WinFormsApp1.ProgramData;

namespace DatabaseManipulationFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void sellPageIconButton_Click(object sender, EventArgs e)
        {
            tagIcon.Visible = true;
            tagLabel.Visible = true;
            tagTextBox.Visible = true;

            descriptionIcon.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;

            brandIcon.Visible = false;
            brandLabel.Visible = false;
            brandTextBox.Visible = false;

            priceIcon.Visible = true;
            priceLabel.Visible = true;
            priceTextBox.Visible = true;

            detailsIcon.Visible = false;
            detailsLabel.Visible = false;
            detailsTextBox.Visible = false;

            dateINIcon.Visible = false;
            dateINLabel.Visible = false;
            dateINTextBox.Visible = false;

            dateOUTIcon.Visible = true;
            dateOUTLabel.Visible = true;
            dateOUTTextBox.Visible = true;

            sellPageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            addPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor = Color.FromArgb(160, 187, 172);
        }

        private void addPageIconButton_Click(object sender, EventArgs e)
        {
            tagIcon.Visible = true;
            tagLabel.Visible = true;
            tagTextBox.Visible = true;

            descriptionIcon.Visible = true;
            descriptionLabel.Visible = true;
            descriptionTextBox.Visible = true;

            brandIcon.Visible = true;
            brandLabel.Visible = true;
            brandTextBox.Visible = true;

            priceIcon.Visible = true;
            priceLabel.Visible = true;
            priceTextBox.Visible = true;

            detailsIcon.Visible = true;
            detailsLabel.Visible = true;
            detailsTextBox.Visible = true;

            dateINIcon.Visible = true;
            dateINLabel.Visible = true;
            dateINTextBox.Visible = true;

            dateOUTIcon.Visible = false;
            dateOUTLabel.Visible = false;
            dateOUTTextBox.Visible = false;


            addPageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            sellPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor = Color.FromArgb(160, 187, 172);
        }

        private void attPageIconButton_Click(object sender, EventArgs e)
        {
            tagIcon.Visible = true;
            tagLabel.Visible = true;
            tagTextBox.Visible = true;

            descriptionIcon.Visible = true;
            descriptionLabel.Visible = true;
            descriptionTextBox.Visible = true;

            brandIcon.Visible = true;
            brandLabel.Visible = true;
            brandTextBox.Visible = true;

            priceIcon.Visible = true;
            priceLabel.Visible = true;
            priceTextBox.Visible = true;

            detailsIcon.Visible = true;
            detailsLabel.Visible = true;
            detailsTextBox.Visible = true;

            dateINIcon.Visible = true;
            dateINLabel.Visible = true;
            dateINTextBox.Visible = true;

            dateOUTIcon.Visible = true;
            dateOUTLabel.Visible = true;
            dateOUTTextBox.Visible = true;


            attPageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            sellPageIconButton.BackColor    = Color.FromArgb(160, 187, 172);
            addPageIconButton.BackColor     = Color.FromArgb(160, 187, 172);
            removePageIconButton.BackColor  = Color.FromArgb(160, 187, 172);


        }

        private void removePageIconButton_Click(object sender, EventArgs e)
        {
            tagIcon.Visible = true;
            tagLabel.Visible = true;
            tagTextBox.Visible = true;

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
            removePageIconButton.BackColor = Color.FromArgb(101, 117, 108);

            sellPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            addPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
            attPageIconButton.BackColor = Color.FromArgb(160, 187, 172);
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
    }
}