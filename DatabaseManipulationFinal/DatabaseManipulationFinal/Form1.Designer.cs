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
            this.labelTag = new System.Windows.Forms.Label();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateINTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOUTTextBox = new System.Windows.Forms.TextBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.sellProduct = new System.Windows.Forms.Button();
            this.removeProduct = new System.Windows.Forms.Button();
            this.createDbButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(157, 32);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(25, 15);
            this.labelTag.TabIndex = 0;
            this.labelTag.Text = "Tag";
            this.labelTag.Click += new System.EventHandler(this.label1_Click);
            // 
            // tagTextBox
            // 
            this.tagTextBox.Location = new System.Drawing.Point(193, 29);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(360, 23);
            this.tagTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(116, 64);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 15);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(193, 61);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(360, 23);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "brand";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(193, 95);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(360, 23);
            this.brandTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(193, 126);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(360, 23);
            this.priceTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "details";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(193, 159);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(360, 23);
            this.detailsTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "dateIN";
            // 
            // dateINTextBox
            // 
            this.dateINTextBox.Location = new System.Drawing.Point(193, 194);
            this.dateINTextBox.Name = "dateINTextBox";
            this.dateINTextBox.Size = new System.Drawing.Size(360, 23);
            this.dateINTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "dateOUT";
            // 
            // dateOUTTextBox
            // 
            this.dateOUTTextBox.Location = new System.Drawing.Point(193, 229);
            this.dateOUTTextBox.Name = "dateOUTTextBox";
            this.dateOUTTextBox.Size = new System.Drawing.Size(360, 23);
            this.dateOUTTextBox.TabIndex = 13;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(129, 351);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(119, 49);
            this.addProduct.TabIndex = 14;
            this.addProduct.Text = "addProduct";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // sellProduct
            // 
            this.sellProduct.Location = new System.Drawing.Point(265, 351);
            this.sellProduct.Name = "sellProduct";
            this.sellProduct.Size = new System.Drawing.Size(119, 49);
            this.sellProduct.TabIndex = 15;
            this.sellProduct.Text = "sellProduct";
            this.sellProduct.UseVisualStyleBackColor = true;
            this.sellProduct.Click += new System.EventHandler(this.sellProduct_Click);
            // 
            // removeProduct
            // 
            this.removeProduct.Location = new System.Drawing.Point(408, 351);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(119, 49);
            this.removeProduct.TabIndex = 16;
            this.removeProduct.Text = "removeProduct";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // createDbButton
            // 
            this.createDbButton.Location = new System.Drawing.Point(721, 415);
            this.createDbButton.Name = "createDbButton";
            this.createDbButton.Size = new System.Drawing.Size(67, 23);
            this.createDbButton.TabIndex = 17;
            this.createDbButton.Text = "create db";
            this.createDbButton.UseVisualStyleBackColor = true;
            this.createDbButton.Click += new System.EventHandler(this.createDbButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createDbButton);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.sellProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.dateOUTTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateINTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.labelTag);
            this.Name = "Form1";
            this.Text = "DatabaseManipulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTag;
        private TextBox tagTextBox;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private Label label1;
        private TextBox brandTextBox;
        private Label label2;
        private TextBox priceTextBox;
        private Label label3;
        private TextBox detailsTextBox;
        private Label label4;
        private TextBox dateINTextBox;
        private Label label5;
        private TextBox dateOUTTextBox;
        private Button addProduct;
        private Button sellProduct;
        private Button removeProduct;
        private Button createDbButton;
        private Label label6;
    }
}