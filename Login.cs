using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonV1
{
    internal class Login
    {
        private string Path(string filename)
        {
            return AppDomain.CurrentDomain.BaseDirectory + filename + ".data";
        }

        Cryptography Encryption = new Cryptography();

        public bool personel_login(string rawpass)
        {
            string[] lines = File.ReadAllLines(Path("users"));
            foreach (var item in lines)
            {
                if (item.Split('?')[1] == Encryption.md5Encrypt(rawpass))
                {
                    settings_Session set = new settings_Session();
                    set.current_username = item.Split('?')[0];
                    set.isLogged = true;
                    set.isAdmin = false;
                    set.Save();
                    PersonalInterface pI = new PersonalInterface();
                    pI.Show();
                    return true;
                }
            }
            return false;
        }

        public bool admin_login(string user, string rawpass)
        {
            string[] lines = File.ReadAllLines(Path("users"));
            foreach (var item in lines)
            {
                if (item.Split('?')[1] == Encryption.md5Encrypt(rawpass) && item.Split('?')[0] == user)
                {
                    settings_Session set = new settings_Session();
                    set.current_username = item.Split('?')[0];
                    set.isLogged = true;
                    set.current_session = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                    set.isAdmin = true;
                    set.Save();
                    AdminInterface aI = new AdminInterface();
                    aI.Show();
                    return true;
                }
            }
            return false;
        }

        public bool session_isLogged()
        {
            var ses = new settings_Session();
            return ses.isLogged;
        }

        public bool session_isAdmin()
        {
            var ses = new settings_Session();
            return ses.isAdmin;
        }
    }
}