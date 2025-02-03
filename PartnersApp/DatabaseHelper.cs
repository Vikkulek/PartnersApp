using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PartnersApp
{
    public static class DatabaseHelper
    {
        private static string connectionString = @"Server=DESKTOP-70JGA2S;Database=company_database;Trusted_Connection=True;TrustServerCertificate=True;";

        public static List<Partner> GetPartners()
        {
            List<Partner> partners = new List<Partner>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM partners";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        partners.Add(new Partner
                        {
                            Id = reader.GetGuid(0),
                            Name = reader.GetString(1),
                            CEO = reader.GetString(2),
                            PhoneNumber = reader.GetString(3),
                            Rating = reader.GetInt32(4),
                            Discount = reader.GetInt32(5),
                            Category = reader.GetString(6),
                            NumOfSoldProducts = reader.GetInt32(7)
                        });
                    }
                }
            }
            return partners;
        }

        public static void AddPartner(Partner partner)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO partners (id_partner, name_partner, CEO_partner, phone_number, rating, discount, category, num_of_sold_products) VALUES (@id, @name, @ceo, @phone, @rating, @discount, @category, @sold)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", partner.Id);
                    cmd.Parameters.AddWithValue("@name", partner.Name);
                    cmd.Parameters.AddWithValue("@ceo", partner.CEO);
                    cmd.Parameters.AddWithValue("@phone", partner.PhoneNumber);
                    cmd.Parameters.AddWithValue("@rating", partner.Rating);
                    cmd.Parameters.AddWithValue("@discount", partner.Discount);
                    cmd.Parameters.AddWithValue("@category", partner.Category);
                    cmd.Parameters.AddWithValue("@sold", partner.NumOfSoldProducts);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
