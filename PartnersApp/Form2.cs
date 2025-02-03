using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PartnersApp
{
    public partial class Form2 : Form
    {
        // Добавляем переменную connectionString внутри класса, но вне методов
        private string connectionString = @"Server=DESKTOP-70JGA2S;Database=company_database;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddPartner_Click_1(object sender, EventArgs e)
        {
            int numOfSoldProducts = int.Parse(txtSold.Text); // Получаем количество проданных товаров

            // Вычисляем скидку
            int discount = CalculateDiscount(numOfSoldProducts);

            Partner partner = new Partner
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                CEO = txtCEO.Text,
                PhoneNumber = txtPhone.Text,
                Rating = int.Parse(txtRating.Text),
                Discount = discount, // Подставляем рассчитанную скидку
                Category = txtCategory.Text,
                NumOfSoldProducts = numOfSoldProducts
            };

            DatabaseHelper.AddPartner(partner);
            MessageBox.Show($"Партнёр добавлен! Скидка: {discount}%");
            this.Close();
        }

        // Метод для расчета скидки
        private int CalculateDiscount(int numOfSoldProducts)
        {
            if (numOfSoldProducts < 10000) return 0;
            if (numOfSoldProducts < 50000) return 5;
            if (numOfSoldProducts < 300000) return 10;
            return 15;
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM partners"; // Запрос к таблице
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Заполняем таблицу данными
                dataGridView1.DataSource = dt; // Устанавливаем источник данных для DataGridView
            }
        }
    }
}
