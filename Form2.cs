using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol
{
    public partial class Form2 : Form
    {
        private readonly DataBaseHelper dbHelper = new DataBaseHelper();

        public Form2()
        {
            InitializeComponent();
            lstPersonel.SelectedIndexChanged += lstPersonel_SelectedIndexChanged;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string subeadi = txtSubeİsmi.Text;

            if (string.IsNullOrWhiteSpace(subeadi))
            {
                MessageBox.Show("Lütfen bir şube adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    string query = "SELECT ad, soyad, yetki FROM kullanici_bilgiler WHERE sube = @sube";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@sube", subeadi);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lstPersonel.Items.Clear();
                            lstYetki.Items.Clear();

                            while (reader.Read())
                            {
                                string ad = reader["ad"].ToString();
                                string soyad = reader["soyad"].ToString();
                                string yetki = reader["yetki"].ToString();

                                lstPersonel.Items.Add($"{ad} {soyad}");
                                lstYetki.Items.Add(yetki);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstPersonel.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < lstYetki.Items.Count)
            {
                lstYetki.SelectedIndex = selectedIndex;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstPersonel.SelectedIndex;

            if (selectedIndex < 0 || selectedIndex >= lstPersonel.Items.Count)
            {
                MessageBox.Show("Lütfen silmek için bir personel seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedName = lstPersonel.Items[selectedIndex].ToString();
            string selectedYetki = lstYetki.Items[selectedIndex].ToString();

            string[] nameParts = selectedName.Split(' ');
            if (nameParts.Length < 2)
            {
                MessageBox.Show("Geçersiz veri formatı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ad = nameParts[0];
            string soyad = nameParts[1];

            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    string deleteQuery = "DELETE FROM kullanici_bilgiler WHERE ad = @ad AND soyad = @soyad AND yetki = @yetki";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ad", ad);
                        command.Parameters.AddWithValue("@soyad", soyad);
                        command.Parameters.AddWithValue("@yetki", selectedYetki);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            lstPersonel.Items.RemoveAt(selectedIndex);
                            lstYetki.Items.RemoveAt(selectedIndex);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt silinirken bir hata oluştu veya kayıt bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu !: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string yetki = cmbYetki.SelectedItem?.ToString();
            string sube = txtSube.Text.Trim();
            string sifre = txtSifreİki.Text.Trim();
            string kullaniciadi = txtAdKullanici.Text.Trim();

            if (string.IsNullOrWhiteSpace(ad) ||
                string.IsNullOrWhiteSpace(soyad) ||
                string.IsNullOrWhiteSpace(yetki) ||
                string.IsNullOrWhiteSpace(sube) ||
                string.IsNullOrWhiteSpace(sifre) ||
                string.IsNullOrWhiteSpace(kullaniciadi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    string insertQuery = "INSERT INTO kullanici_bilgiler (ad, soyad, yetki, sube, sifre, kullanici_ad) VALUES (@ad, @soyad, @yetki, @sube, @sifre, @kullaniciAd)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ad", ad);
                        command.Parameters.AddWithValue("@soyad", soyad);
                        command.Parameters.AddWithValue("@yetki", yetki);
                        command.Parameters.AddWithValue("@sube", sube);
                        command.Parameters.AddWithValue("@sifre", sifre);
                        command.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtAd.Clear();
                            txtSoyad.Clear();
                            txtSube.Clear();
                            txtSifreİki.Clear();
                            txtAdKullanici.Clear();
                            cmbYetki.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı eklenirken bir hata oluştu ! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu! : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    string query = "SELECT sube, COUNT(*) AS personelSayisi FROM kullanici_bilgiler GROUP BY sube HAVING COUNT(*) > 0";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        lstPersonelSayisi.Items.Clear();

                        while (reader.Read())
                        {
                            string sube = reader["sube"].ToString();
                            int personelSayisi = Convert.ToInt32(reader["personelSayisi"]);
                            lstPersonelSayisi.Items.Add($"{sube} ({personelSayisi})");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYukleİki_Click(object sender, EventArgs e)
        {
            string sube = txtİsimSube.Text.Trim();

            if (!decimal.TryParse(txtGönYakit.Text.Trim(), out decimal gonderilenMiktar) || gonderilenMiktar <= 0)
            {
                MessageBox.Show("Geçerli bir yakıt miktarı giriniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstAnaDepo.Items.Clear();
            lstYakitMiktar.Items.Clear();

            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    decimal anaDepoMiktar = 0;
                    string getAnaDepoQuery = "SELECT miktar FROM ana_depo WHERE id = 1";
                    using (SqlCommand getCommand = new SqlCommand(getAnaDepoQuery, connection))
                    {
                        object result = getCommand.ExecuteScalar();
                        anaDepoMiktar = result != null ? Convert.ToDecimal(result) : 0;
                    }

                    if (anaDepoMiktar < gonderilenMiktar)
                    {
                        MessageBox.Show("Ana depoda yeterli yakıt yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string updateAnaDepoQuery = "UPDATE ana_depo SET miktar = miktar - @gonderilenMiktar WHERE id = 1";
                    using (SqlCommand updateCommand = new SqlCommand(updateAnaDepoQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@gonderilenMiktar", gonderilenMiktar);
                        updateCommand.ExecuteNonQuery();
                    }

                    string updateSubeQuery = @"IF EXISTS (SELECT 1 FROM subeler WHERE sube = @sube)
                                     UPDATE subeler SET miktar = miktar + @gonderilenMiktar WHERE sube = @sube
                                     ELSE
                                     INSERT INTO subeler (sube, miktar) VALUES (@sube, @gonderilenMiktar)";
                    using (SqlCommand updateSubeCommand = new SqlCommand(updateSubeQuery, connection))
                    {
                        updateSubeCommand.Parameters.AddWithValue("@sube", sube);
                        updateSubeCommand.Parameters.AddWithValue("@gonderilenMiktar", gonderilenMiktar);
                        updateSubeCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand getAnaDepoCommand = new SqlCommand(getAnaDepoQuery, connection))
                    {
                        object anaDepoMiktarGuncel = getAnaDepoCommand.ExecuteScalar();
                        lstAnaDepo.Items.Add($"Ana Depo: {anaDepoMiktarGuncel ?? 0} ton");
                    }

                    string getSubeMiktarQuery = "SELECT miktar FROM subeler WHERE sube = @sube";
                    using (SqlCommand getSubeMiktarCommand = new SqlCommand(getSubeMiktarQuery, connection))
                    {
                        getSubeMiktarCommand.Parameters.AddWithValue("@sube", sube);
                        object subeMiktar = getSubeMiktarCommand.ExecuteScalar();
                        lstYakitMiktar.Items.Add($"{sube}: {subeMiktar ?? 0} ton");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Veritabanı hatası: {sqlEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
