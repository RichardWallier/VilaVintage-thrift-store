namespace DatabaseManipulationFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removePageIconButton = new FontAwesome.Sharp.IconButton();
            this.attPageIconButton = new FontAwesome.Sharp.IconButton();
            this.addPageIconButton = new FontAwesome.Sharp.IconButton();
            this.sellPageIconButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeIconButton = new FontAwesome.Sharp.IconButton();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.tagLabel = new System.Windows.Forms.Label();
            this.tagIcon = new FontAwesome.Sharp.IconPictureBox();
            this.descriptionIcon = new FontAwesome.Sharp.IconPictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.brandIcon = new FontAwesome.Sharp.IconPictureBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.priceIcon = new FontAwesome.Sharp.IconPictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.detailsIcon = new FontAwesome.Sharp.IconPictureBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.dateINIcon = new FontAwesome.Sharp.IconPictureBox();
            this.dateINLabel = new System.Windows.Forms.Label();
            this.dateINTextBox = new System.Windows.Forms.TextBox();
            this.sellProductButton = new FontAwesome.Sharp.IconButton();
            this.dateOUTIcon = new FontAwesome.Sharp.IconPictureBox();
            this.dateOUTLabel = new System.Windows.Forms.Label();
            this.dateOUTTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateINIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOUTIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.removePageIconButton);
            this.panel1.Controls.Add(this.attPageIconButton);
            this.panel1.Controls.Add(this.addPageIconButton);
            this.panel1.Controls.Add(this.sellPageIconButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 550);
            this.panel1.TabIndex = 0;
            // 
            // removePageIconButton
            // 
            this.removePageIconButton.FlatAppearance.BorderSize = 0;
            this.removePageIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePageIconButton.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removePageIconButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.removePageIconButton.IconColor = System.Drawing.Color.Black;
            this.removePageIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removePageIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removePageIconButton.Location = new System.Drawing.Point(0, 377);
            this.removePageIconButton.Name = "removePageIconButton";
            this.removePageIconButton.Size = new System.Drawing.Size(270, 60);
            this.removePageIconButton.TabIndex = 4;
            this.removePageIconButton.Text = "Remover";
            this.removePageIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removePageIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removePageIconButton.UseVisualStyleBackColor = true;
            this.removePageIconButton.Click += new System.EventHandler(this.removePageIconButton_Click);
            // 
            // attPageIconButton
            // 
            this.attPageIconButton.FlatAppearance.BorderSize = 0;
            this.attPageIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attPageIconButton.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.attPageIconButton.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.attPageIconButton.IconColor = System.Drawing.Color.Black;
            this.attPageIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.attPageIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attPageIconButton.Location = new System.Drawing.Point(0, 318);
            this.attPageIconButton.Name = "attPageIconButton";
            this.attPageIconButton.Size = new System.Drawing.Size(270, 60);
            this.attPageIconButton.TabIndex = 3;
            this.attPageIconButton.Text = "Atualizar";
            this.attPageIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attPageIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.attPageIconButton.UseVisualStyleBackColor = true;
            this.attPageIconButton.Click += new System.EventHandler(this.attPageIconButton_Click);
            // 
            // addPageIconButton
            // 
            this.addPageIconButton.FlatAppearance.BorderSize = 0;
            this.addPageIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPageIconButton.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPageIconButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.addPageIconButton.IconColor = System.Drawing.Color.Black;
            this.addPageIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addPageIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPageIconButton.Location = new System.Drawing.Point(0, 259);
            this.addPageIconButton.Name = "addPageIconButton";
            this.addPageIconButton.Size = new System.Drawing.Size(270, 60);
            this.addPageIconButton.TabIndex = 2;
            this.addPageIconButton.Text = "Adicionar";
            this.addPageIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPageIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPageIconButton.UseVisualStyleBackColor = true;
            this.addPageIconButton.Click += new System.EventHandler(this.addPageIconButton_Click);
            // 
            // sellPageIconButton
            // 
            this.sellPageIconButton.FlatAppearance.BorderSize = 0;
            this.sellPageIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellPageIconButton.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellPageIconButton.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.sellPageIconButton.IconColor = System.Drawing.Color.Black;
            this.sellPageIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sellPageIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellPageIconButton.Location = new System.Drawing.Point(0, 201);
            this.sellPageIconButton.Name = "sellPageIconButton";
            this.sellPageIconButton.Size = new System.Drawing.Size(270, 60);
            this.sellPageIconButton.TabIndex = 1;
            this.sellPageIconButton.Text = "Vender";
            this.sellPageIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellPageIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sellPageIconButton.UseVisualStyleBackColor = true;
            this.sellPageIconButton.Click += new System.EventHandler(this.sellPageIconButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DatabaseManipulationFinal.Properties.Resources.cuted;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.homeIconButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 52);
            this.panel2.TabIndex = 1;
            // 
            // homeIconButton
            // 
            this.homeIconButton.FlatAppearance.BorderSize = 0;
            this.homeIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeIconButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeIconButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeIconButton.IconColor = System.Drawing.Color.Black;
            this.homeIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeIconButton.IconSize = 16;
            this.homeIconButton.Location = new System.Drawing.Point(6, 12);
            this.homeIconButton.Name = "homeIconButton";
            this.homeIconButton.Size = new System.Drawing.Size(127, 29);
            this.homeIconButton.TabIndex = 0;
            this.homeIconButton.Text = "Página principal";
            this.homeIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeIconButton.UseVisualStyleBackColor = true;
            this.homeIconButton.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // tagTextBox
            // 
            this.tagTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.tagTextBox.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tagTextBox.Location = new System.Drawing.Point(645, 67);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(455, 33);
            this.tagTextBox.TabIndex = 2;
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tagLabel.Location = new System.Drawing.Point(411, 67);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(226, 32);
            this.tagLabel.TabIndex = 3;
            this.tagLabel.Text = "Etiqueta- - - - - - -";
            // 
            // tagIcon
            // 
            this.tagIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(108)))));
            this.tagIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tagIcon.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.tagIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.tagIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tagIcon.IconSize = 35;
            this.tagIcon.Location = new System.Drawing.Point(379, 73);
            this.tagIcon.Name = "tagIcon";
            this.tagIcon.Size = new System.Drawing.Size(35, 52);
            this.tagIcon.TabIndex = 4;
            this.tagIcon.TabStop = false;
            // 
            // descriptionIcon
            // 
            this.descriptionIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(108)))));
            this.descriptionIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.descriptionIcon.IconChar = FontAwesome.Sharp.IconChar.CommentMedical;
            this.descriptionIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.descriptionIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descriptionIcon.IconSize = 35;
            this.descriptionIcon.Location = new System.Drawing.Point(379, 123);
            this.descriptionIcon.Name = "descriptionIcon";
            this.descriptionIcon.Size = new System.Drawing.Size(35, 52);
            this.descriptionIcon.TabIndex = 5;
            this.descriptionIcon.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(411, 117);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(232, 32);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Descrição - - - - - -";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.descriptionTextBox.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(645, 118);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(455, 33);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // brandIcon
            // 
            this.brandIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(108)))));
            this.brandIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brandIcon.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.brandIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.brandIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brandIcon.IconSize = 35;
            this.brandIcon.Location = new System.Drawing.Point(379, 171);
            this.brandIcon.Name = "brandIcon";
            this.brandIcon.Size = new System.Drawing.Size(35, 52);
            this.brandIcon.TabIndex = 8;
            this.brandIcon.TabStop = false;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brandLabel.Location = new System.Drawing.Point(411, 167);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(228, 32);
            this.brandLabel.TabIndex = 9;
            this.brandLabel.Text = "Marca - - - - - - - -";
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.brandTextBox.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brandTextBox.Location = new System.Drawing.Point(645, 167);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(455, 33);
            this.brandTextBox.TabIndex = 10;
            // 
            // priceIcon
            // 
            this.priceIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(108)))));
            this.priceIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceIcon.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.priceIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.priceIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.priceIcon.IconSize = 35;
            this.priceIcon.Location = new System.Drawing.Point(379, 223);
            this.priceIcon.Name = "priceIcon";
            this.priceIcon.Size = new System.Drawing.Size(35, 52);
            this.priceIcon.TabIndex = 11;
            this.priceIcon.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(411, 217);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(222, 32);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Preço - - - - - - - -";
            // 
            // detailsIcon
            // 
            this.detailsIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(108)))));
            this.detailsIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.detailsIcon.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.detailsIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.detailsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detailsIcon.IconSize = 35;
            this.detailsIcon.Location = new System.Drawing.Point(379, 273);
            this.detailsIcon.Name = "detailsIcon";
            this.detailsIcon.Size = new System.Drawing.Size(35, 52);
            this.detailsIcon.TabIndex = 13;
            this.detailsIcon.TabStop = false;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.detailsLabel.Location = new System.Drawing.Point(411, 267);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(221, 32);
            this.detailsLabel.TabIndex = 14;
            this.detailsLabel.Text = "Detalhes - - - - - -";
            this.detailsLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.priceTextBox.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceTextBox.Location = new System.Drawing.Point(645, 217);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(455, 33);
            this.priceTextBox.TabIndex = 15;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.detailsTextBox.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.detailsTextBox.Location = new System.Drawing.Point(645, 268);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(455, 33);
            this.detailsTextBox.TabIndex = 16;
            // 
            // dateINIcon
            // 
            this.dateINIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(108)))));
            this.dateINIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateINIcon.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.dateINIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.dateINIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dateINIcon.IconSize = 35;
            this.dateINIcon.Location = new System.Drawing.Point(379, 323);
            this.dateINIcon.Name = "dateINIcon";
            this.dateINIcon.Size = new System.Drawing.Size(35, 52);
            this.dateINIcon.TabIndex = 17;
            this.dateINIcon.TabStop = false;
            // 
            // dateINLabel
            // 
            this.dateINLabel.AutoSize = true;
            this.dateINLabel.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateINLabel.Location = new System.Drawing.Point(411, 317);
            this.dateINLabel.Name = "dateINLabel";
            this.dateINLabel.Size = new System.Drawing.Size(234, 32);
            this.dateINLabel.TabIndex = 18;
            this.dateINLabel.Text = "Data de entrada - -";
            // 
            // dateINTextBox
            // 
            this.dateINTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.dateINTextBox.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateINTextBox.Location = new System.Drawing.Point(645, 318);
            this.dateINTextBox.Name = "dateINTextBox";
            this.dateINTextBox.Size = new System.Drawing.Size(455, 33);
            this.dateINTextBox.TabIndex = 19;
            // 
            // sellProductButton
            // 
            this.sellProductButton.Font = new System.Drawing.Font("Malgun Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellProductButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.sellProductButton.IconColor = System.Drawing.Color.Black;
            this.sellProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sellProductButton.IconSize = 90;
            this.sellProductButton.Location = new System.Drawing.Point(603, 457);
            this.sellProductButton.Name = "sellProductButton";
            this.sellProductButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.sellProductButton.Size = new System.Drawing.Size(219, 81);
            this.sellProductButton.TabIndex = 20;
            this.sellProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sellProductButton.UseVisualStyleBackColor = true;
            // 
            // dateOUTIcon
            // 
            this.dateOUTIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(108)))));
            this.dateOUTIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOUTIcon.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.dateOUTIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.dateOUTIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dateOUTIcon.IconSize = 35;
            this.dateOUTIcon.Location = new System.Drawing.Point(379, 371);
            this.dateOUTIcon.Name = "dateOUTIcon";
            this.dateOUTIcon.Size = new System.Drawing.Size(35, 52);
            this.dateOUTIcon.TabIndex = 21;
            this.dateOUTIcon.TabStop = false;
            // 
            // dateOUTLabel
            // 
            this.dateOUTLabel.AutoSize = true;
            this.dateOUTLabel.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateOUTLabel.Location = new System.Drawing.Point(413, 367);
            this.dateOUTLabel.Name = "dateOUTLabel";
            this.dateOUTLabel.Size = new System.Drawing.Size(224, 32);
            this.dateOUTLabel.TabIndex = 22;
            this.dateOUTLabel.Text = "Data de saída - - -";
            this.dateOUTLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateOUTTextBox
            // 
            this.dateOUTTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.dateOUTTextBox.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateOUTTextBox.Location = new System.Drawing.Point(645, 370);
            this.dateOUTTextBox.Name = "dateOUTTextBox";
            this.dateOUTTextBox.Size = new System.Drawing.Size(455, 33);
            this.dateOUTTextBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(1170, 550);
            this.Controls.Add(this.dateOUTTextBox);
            this.Controls.Add(this.dateOUTLabel);
            this.Controls.Add(this.dateOUTIcon);
            this.Controls.Add(this.sellProductButton);
            this.Controls.Add(this.dateINTextBox);
            this.Controls.Add(this.dateINLabel);
            this.Controls.Add(this.dateINIcon);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.detailsIcon);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceIcon);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.brandIcon);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionIcon);
            this.Controls.Add(this.tagIcon);
            this.Controls.Add(this.tagLabel);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "DatabaseManipulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tagIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateINIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOUTIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton removePageIconButton;
        private FontAwesome.Sharp.IconButton attPageIconButton;
        private FontAwesome.Sharp.IconButton addPageIconButton;
        private FontAwesome.Sharp.IconButton sellPageIconButton;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton homeIconButton;
        private TextBox tagTextBox;
        private Label tagLabel;
        private FontAwesome.Sharp.IconPictureBox tagIcon;
        private FontAwesome.Sharp.IconPictureBox descriptionIcon;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private FontAwesome.Sharp.IconPictureBox brandIcon;
        private Label brandLabel;
        private TextBox brandTextBox;
        private FontAwesome.Sharp.IconPictureBox priceIcon;
        private Label priceLabel;
        private FontAwesome.Sharp.IconPictureBox detailsIcon;
        private Label detailsLabel;
        private TextBox priceTextBox;
        private TextBox detailsTextBox;
        private FontAwesome.Sharp.IconPictureBox dateINIcon;
        private Label dateINLabel;
        private TextBox dateINTextBox;
        private FontAwesome.Sharp.IconButton sellProductButton;
        private FontAwesome.Sharp.IconPictureBox dateOUTIcon;
        private Label dateOUTLabel;
        private TextBox dateOUTTextBox;
    }
}