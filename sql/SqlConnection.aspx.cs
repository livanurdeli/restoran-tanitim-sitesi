using System;
using System.Configuration;
using System.Data.SqlClient;

namespace YourNamespace
{
    public partial class ContactForm : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Formdaki verileri al
            string name = txtName.Text;
            string email = txtEmail.Text;
            string number = txtNumber.Text;

            // Veritabanı bağlantısı
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Contacts (Name, Email, Number) VALUES (@Name, @Email, @Number)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Number", number);
                        cmd.ExecuteNonQuery();
                    }

                    // Başarılı mesajı
                    Response.Write("<script>alert('Form başarıyla gönderildi!');</script>");
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    Response.Write("<script>alert('Bir hata oluştu: " + ex.Message + "');</script>");
                }
            }
        }
    }
}
