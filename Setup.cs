using System;
using System.Text;
using System.IO;
using Microsoft.VisualBasic;
namespace RestaurantOtomasyonV1
{
    class Setup
    {
        Cryptography encryption = new Cryptography();
        public bool is_FirstTime()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "setup.lock"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void install()
        {
            // Create default urun file
            try
            {
                using (StreamWriter sw = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "urun.data"))
                {
                    sw.WriteLine("Ürün{Kategori{100");
                }
            }
            catch (Exception)
            {

                throw;
            }
            // Create default kategori file
            try
            {
                using (StreamWriter sw = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "category.data"))
                {
                    sw.WriteLine("Kategori");
                }
            }
            catch (Exception)
            {

                throw;
            }
            // Create default users settings
            try
            {
                using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "users.data"))
                {
                    sw.WriteLine("admin?" + encryption.md5Encrypt("adminpass") + "?admin");

                }
            }
            catch (Exception)
            {

                throw;
            }
            // Create default customer file
            try
            {

                using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "customers.data"))
                {
                    settings_Session set = new settings_Session();
                    var quest = Interaction.InputBox("Kaç adet masanız mevcut?\nDaha sonradan yönetici hesabıyla değiştirebilirsiniz.","Masa Kurulumu","10");
                    set.desk_count = Convert.ToInt32(quest);
                    set.Save();
                    // sw.WriteLine("1}testUrun1%adet{testUrun2%adet{testUrun3%adet}fiyat");
                    
                    for (int i = 1; i <= set.desk_count; i++)
                    {
                        sw.WriteLine(i + "}");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            // Create setup.lock when setup is finished
            try
            {
                using (FileStream fs = File.Create(AppDomain.CurrentDomain.BaseDirectory + "setup.lock"))
                {
                    byte[] writeData = new UTF8Encoding(true).GetBytes("Installed!");
                    fs.Write(writeData, 0, writeData.Length);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void resetSetupFile()
        {
            if (is_FirstTime())
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "setup.lock");
            }
        }

    }
}
