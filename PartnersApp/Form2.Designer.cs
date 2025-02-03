namespace PartnersApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtCEO = new TextBox();
            txtPhone = new TextBox();
            txtRating = new TextBox();
            txtCategory = new TextBox();
            txtSold = new TextBox();
            btnAddPartner = new Button();
            dataGridView1 = new DataGridView();
            partnerBindingSource1 = new BindingSource(components);
            partnerBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Рейтинг = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partnerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partnerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // txtCEO
            // 
            txtCEO.Location = new Point(12, 61);
            txtCEO.Name = "txtCEO";
            txtCEO.Size = new Size(125, 27);
            txtCEO.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 110);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(12, 157);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(125, 27);
            txtRating.TabIndex = 3;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(12, 210);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 5;
            // 
            // txtSold
            // 
            txtSold.Location = new Point(12, 257);
            txtSold.Name = "txtSold";
            txtSold.Size = new Size(125, 27);
            txtSold.TabIndex = 6;
            // 
            // btnAddPartner
            // 
            btnAddPartner.Location = new Point(12, 400);
            btnAddPartner.Name = "btnAddPartner";
            btnAddPartner.Size = new Size(94, 29);
            btnAddPartner.TabIndex = 7;
            btnAddPartner.Text = "button1";
            btnAddPartner.UseVisualStyleBackColor = true;
            btnAddPartner.Click += btnAddPartner_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(626, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(572, 378);
            dataGridView1.TabIndex = 8;
            // 
            // partnerBindingSource1
            // 
            partnerBindingSource1.DataSource = typeof(Partner);
            // 
            // partnerBindingSource
            // 
            partnerBindingSource.DataSource = typeof(Partner);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 9;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 68);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 10;
            label2.Text = "СЕО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 117);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 11;
            label3.Text = "Телефон";
            // 
            // Рейтинг
            // 
            Рейтинг.AutoSize = true;
            Рейтинг.Location = new Point(169, 164);
            Рейтинг.Name = "Рейтинг";
            Рейтинг.Size = new Size(64, 20);
            Рейтинг.TabIndex = 12;
            Рейтинг.Text = "Рейтинг";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 213);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 13;
            label4.Text = "Категория";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 264);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 14;
            label5.Text = "Продано";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 593);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Рейтинг);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddPartner);
            Controls.Add(txtSold);
            Controls.Add(txtCategory);
            Controls.Add(txtRating);
            Controls.Add(txtPhone);
            Controls.Add(txtCEO);
            Controls.Add(txtName);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)partnerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)partnerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtCEO;
        private TextBox txtPhone;
        private TextBox txtRating;
        private TextBox txtCategory;
        private TextBox txtSold;
        private Button btnAddPartner;
        private DataGridView dataGridView1;
        private BindingSource partnerBindingSource;
        private BindingSource partnerBindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Рейтинг;
        private Label label4;
        private Label label5;
    }
}