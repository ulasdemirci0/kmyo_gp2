using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RestaurantOtomasyonV1
{
    class Customer_Actions
    {


        private string path(string dataFileName)
        {
            return AppDomain.CurrentDomain.BaseDirectory + dataFileName.ToLower() + ".data";
        }
        #region CUSTOMERS.DATA
        public string customers_load_sold_urun_names_and_counts(int masa_id)
        {
            string[] lines = File.ReadAllLines(path("customers"));
            foreach (var line in lines)
            {
                if (line.StartsWith(masa_id + "}"))
                {
                    if (line.Contains('{'))
                    {
                        return line;
                    }
                }
            }
            return null;
        }
        public void customer_sell_item(int masa_id, string item, int item_count)
        {
            string[] lines = File.ReadAllLines(path("customers"));
            int index = 0;
            string newLine = null;
            foreach (var line in lines)
            {
                if (line.Split('}')[0] == masa_id.ToString())
                {
                    newLine = line.Split('}')[0] + '}' + line.Split('}')[1] + "{" + item + "%" + item_count;
                    break;
                }

                index++;
            }
            if (newLine != null)
            {
                lines.SetValue(newLine, index);
                File.Delete(path("customers"));
                File.WriteAllLines(path("customers"), lines);
            }
        }
        public void customer_refund_item(int masa_id, string item, int item_count)
        {
            string[] lines = File.ReadAllLines(path("customers"));
            bool is_changed = false;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Split('}')[0] == masa_id.ToString() && lines[i].Contains(item + "%" + item_count))
                {
                    var regex = new Regex(Regex.Escape('{' + item + '%' + item_count));
                    lines[i] = regex.Replace(lines[i], "", 1);
                    is_changed = true;
                }
            }
            if (is_changed)
            {

                File.Delete(path("customers"));
                File.WriteAllLines(path("customers"), lines);
            }

        }
        public string customer_desk_statuses(int masa_id)
        {
            string[] lines = File.ReadAllLines(path("customers"));
            foreach (var item in lines)
            {
                if (item.StartsWith(masa_id.ToString() + '}'))
                {
                    if (item.Split('}')[1] == "%reserved%")
                    {
                        return "reserved";
                    }
                    else if (item.Split('}')[1].Contains('%'))
                    {
                        return "closed";
                    }
                    else
                    {
                        return "open";
                    }
                }
            }
            return null;
        }
        public void customer_desk_reserve(int masa_id, string action)
        {
            string[] lines = File.ReadAllLines(path("customers"));
            switch (action)
            {
                case "unset":
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Split('}')[0] == masa_id.ToString() && lines[i].Split('}')[1].Contains("%reserved%"))
                        {
                            lines[i] = masa_id + "}";
                            File.Delete(path("customers"));
                            File.WriteAllLines(path("customers"), lines);
                        }
                    }
                    break;
                case "set":
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if(lines[i].Split('}')[0] == masa_id.ToString())
                        {
                            lines[i] = masa_id + "}%reserved%";
                            File.Delete(path("customers"));
                            File.WriteAllLines(path("customers"), lines);
                        }
                    }
                    break;
            }
        }
        #endregion
        #region URUN.DATA
        public double urun_find_price(string urun)
        {
            string[] lines = File.ReadAllLines(path("urun"));
            foreach (var item in lines)
            {
                if (item.Contains(urun))
                {
                    return Convert.ToDouble(item.Split('{')[2]);
                }
            }

            return -1;
        }
        public bool urun_is_any_urun_has_this_category(string category)
        {
            string[] lines = File.ReadAllLines(path("urun"));
            foreach (var item in lines)
            {
                if (item.Split('{')[1] == category)
                {
                    return true;
                }
            }
            return false;
        }
        public List<string> urun_load_uruns_from_category(string category_name)
        {
            string[] lines = File.ReadAllLines(path("urun"));
            List<string> returnval = new List<string>();
            foreach (var item in lines)
            {
                if (item.Split('{')[1] == category_name)
                    returnval.Add(item);
            }
            return returnval;
        }
        public void urun_create(string urun_name, string urun_category, string urun_fiyat)
        {
            using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "urun.data"))
            {
                sw.WriteLine(urun_name + '{' + urun_category + '{' + urun_fiyat);
            }
        }
        public List<string> urun_get_all_names()
        {
            string[] lines = File.ReadAllLines(path("urun"));
            List<string> list = new List<string>();
            foreach (var item in lines)
            {
                list.Add(item.Split('{')[0]);
            }
            return list;
        }
        public void urun_update(string selected, string new_name, string new_category, string new_price)
        {
            string[] lines = File.ReadAllLines(path("urun"));
            int index = 0;
            foreach (var item in lines)
            {
                if (item.Split('{')[0] == selected)
                {
                    lines[index] = new_name + '{' + new_category + '{' + new_price;

                }
                index++;
            }
            File.WriteAllLines(path("urun"), lines);
        }
        public string urun_get(string selected)
        {
            string returnval;
            string[] lines = File.ReadAllLines(path("urun"));
            foreach (var item in lines)
            {
                if (item.Split('{')[0] == selected)
                {
                    returnval = item;
                    return returnval;
                }
            }
            return null;
        }
        public string urun_find_category_from_urun(string urun)
        {
            string[] lines = File.ReadAllLines(path("urun"));
            foreach (var item in lines)
            {
                if (item.Split('{')[0] == urun)
                {
                    return item.Split('{')[1];
                }
            }
            return null;
        }
        public void urun_remove(string urun)
        {
            string[] lines = File.ReadAllLines(path("urun"));
            int index = 0;
            foreach (var item in lines)
            {

                if (item.Split('{')[0] == urun)
                {

                    lines[index] = null;

                }
                index++;
            }

            File.Delete(path("urun"));
            using (StreamWriter sw = File.AppendText(path("urun")))
            {
                foreach (var item in lines)
                {
                    if (item != null)
                    {
                        sw.WriteLine(item);

                    }
                }
            }
        }
        #endregion
        #region  CATEGORY.DATA
        public void category_create(string cat_name)
        {
            using (StreamWriter sw = File.AppendText(path("category")))
            {
                sw.WriteLine(cat_name);
            }
        }
        public void category_rename(string old_name, string new_name)
        {
            string[] lines = File.ReadAllLines(path("category"));
            int index = 0;
            foreach (var item in lines)
            {
                if (item == old_name)
                {
                    lines[index] = new_name;
                }
                index++;
            }
            File.WriteAllLines(path("category"), lines);
        }
        public string[] category_getall()
        {
            return File.ReadAllLines(path("category"));
        }
        public void category_remove(string cat_name)
        {
            string[] lines = File.ReadAllLines(path("category"));
            int index = 0;
            foreach (var item in lines)
            {
                if (item == cat_name)
                    lines[index] = null;
                index++;
            }
            File.Delete(path("category"));
            using (StreamWriter sw = File.AppendText(path("category")))
            {
                foreach (var item in lines)
                {
                    if (item != null)
                        sw.WriteLine(item);
                }
            }

        }

        #endregion
    }
}
