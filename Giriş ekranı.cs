using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol
{
    public partial class frmGiris : Form
    {
        private DataBaseHelper dbHelper;

        public frmGiris()
        {
            InitializeComponent();
            dbHelper = new DataBaseHelper();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            using (SqlConnection connection = dbHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT yetki FROM kullanici_bilgiler WHERE kullanici_ad = @kullaniciadi AND sifre = @sifre";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string yetki = result.ToString();

                        switch (yetki)
                        {
                            case "Yönetici":
                                frmYöneticiEkrani form2 = new frmYöneticiEkrani();
                                form2.Show();
                                this.Hide();
                                break;
                            case "Şube Müdürü":
                                Form3 form3 = new Form3();
                                form3.Show();
                                this.Hide();
                                break;
                            case "Pompacı":
                                Form4 form4 = new Form4();
                                form4.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Tanımlanmamış bir yetki ile giriş yapmaya çalışıyorsunuz");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu ' : " + ex.Message);
                }
            }
        }


    }
}
