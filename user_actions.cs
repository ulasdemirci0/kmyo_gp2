using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RestaurantOtomasyonV1
{
    class user_actions
    {
        char[] newline_char = new[] { '\r', '\n' };



        public Dictionary<int, string> get_all_usernames()
        {
            var lines = new Dictionary<int, string>();
            try
            {
                int count = 0;
                string fileAll = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "users.data");
                string[] file = fileAll.Split(newline_char, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in file)
                {
                    lines.Add(count, item.Split('?')[0]);
                    count++;
                }

                return lines;
            }
            catch (Exception) { throw; }
        }
        public bool is_admin(string username)
        {
            try
            {
                string fileAllTexts = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "users.data");
                string[] lines = fileAllTexts.Split(newline_char, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in lines)
                {
                    if (item.Contains(username))
                    {
                        if (item.Split('?')[2] == "admin")
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool is_user_exist(string username)
        {
            var all_users = get_all_usernames();
            foreach (var item in all_users)
            {
                if (item.Value == username)
                {
                    return true;
                }
            }
            return false;
        }
        public Dictionary<string, string> get_userdata_from_username(string username)
        {
            if (is_user_exist(username))
            {
                try
                {
                    var dict = new Dictionary<string, string>();
                    string fileAll = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "users.data");
                    string[] lines = fileAll.Split(newline_char, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in lines)
                    {
                        if (item.Contains(username))
                        {
                            dict.Add("username", item.Split('?')[0]);
                            dict.Add("password", item.Split('?')[1]);
                            dict.Add("is_admin", item.Split('?')[2]);
                            return dict;
                        }

                    }

                }
                catch (Exception)
                { throw; }
            }

            return null;
        }
        public void update_password(string user, string rawPass)
        {
            Cryptography cryptography = new Cryptography();
            var dict = get_userdata_from_username(user);

            try
            {
                string allFile = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "users.data");

                string[] lines = allFile.Split(newline_char, StringSplitOptions.RemoveEmptyEntries);
                int key = 0;
                StringBuilder strbuilder = new StringBuilder();
                foreach (var item in lines)
                {
                    if (item.Contains(dict["username"]) && item.Contains(dict["password"]))
                    {
                        lines[key] = lines[key].Replace(dict["password"], cryptography.md5Encrypt(rawPass));
                    }
                    key++;
                }
                foreach (var item in lines)
                {
                    strbuilder.AppendLine(item);
                }


                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "users.data");
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "users.data", strbuilder.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void create_user(string user, string rawPass, bool is_Admin)
        {
            if (!is_user_exist(user))
            {
                Cryptography crypt = new Cryptography();
                using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "users.data"))
                {
                    if (is_Admin)
                        sw.WriteLine(user + "?" + crypt.md5Encrypt(rawPass) + "?admin");
                    else
                        sw.WriteLine(user + "?" + crypt.md5Encrypt(rawPass));
                }
            }
        }
        public void delete_user(string user)
        {
            try
            {
                StringBuilder str = new StringBuilder();
                string file_data = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "users.data");
                string[] data_lines = file_data.Split(newline_char, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < data_lines.Length; i++)
                {
                    if (data_lines[i].Split('?')[0].Contains(user))
                    {
                        data_lines[i] = null;
                    }
                }
                foreach (var item in data_lines)
                {
                    str.Append(item);
                }
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "users.data");
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "users.data",str.ToString());

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
