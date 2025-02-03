using System;
using System.Windows.Forms;

namespace PartnersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPartners();
        }

        private void LoadPartners()
        {
            flowLayoutPanelPartners.Controls.Clear();
            foreach (var partner in DatabaseHelper.GetPartners())
            {
                Panel panel = CreatePanel();
                panel.Controls.Add(CreateTitleLabel(partner.Category, partner.Name));
                panel.Controls.Add(CreateDirectorLabel(partner.CEO));
                panel.Controls.Add(CreatePhoneNumberLabel(partner.PhoneNumber));
                panel.Controls.Add(CreateRatingLabel(partner.Rating));
                panel.Controls.Add(CreateDiscountLabel(partner.Discount));
                flowLayoutPanelPartners.Controls.Add(panel);
            }
        }

        private Panel CreatePanel()
        {
            return new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new System.Drawing.Size(475, 110),
                Margin = new Padding(15),
                BackColor = System.Drawing.Color.FromArgb(100, 100, 100)
            };
        }

        private Label CreateTitleLabel(string type, string partnerName)
        {
            return new Label
            {
                Text = $"{type} | {partnerName}",
                Font = new System.Drawing.Font("Arial", 14),
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true
            };
        }

        private Label CreateDirectorLabel(string directorName)
        {
            return new Label
            {
                Text = directorName,
                Font = new System.Drawing.Font("Arial", 13),
                Location = new System.Drawing.Point(10, 35),
                AutoSize = true
            };
        }

        private Label CreatePhoneNumberLabel(string phoneNumber)
        {
            return new Label
            {
                Text = phoneNumber,
                Font = new System.Drawing.Font("Arial", 13),
                Location = new System.Drawing.Point(10, 55),
                AutoSize = true
            };
        }

        private Label CreateRatingLabel(float rating)
        {
            return new Label
            {
                Text = $"Рейтинг: {rating}",
                Font = new System.Drawing.Font("Arial", 13),
                Location = new System.Drawing.Point(10, 75),
                AutoSize = true
            };
        }

        private Label CreateDiscountLabel(int discount)
        {
            return new Label
            {
                Text = discount + "%",
                Font = new System.Drawing.Font("Arial", 16),
                Location = new System.Drawing.Point(400, 10),
                AutoSize = true
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
