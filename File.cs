using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galaxy_browser
{
    class Files
    {
        public static string Is_file(string s)
        {
            s = s.Substring(s.Length - 7);
            StreamReader sr = new StreamReader(Application.StartupPath + @"\Download\Filetype.txt");
            string r = sr.ReadLine();
            while (r != null)
            {
                if (r.IndexOf(@"//") == -1)
                {
                    if (s != s.Replace(r, ""))
                    {
                        sr.Close();
                        sr.Dispose();
                        return r; 
                    }
                }
                r = sr.ReadLine();
            }
            sr.Close();
            sr.Dispose();
            return string.Empty;
        }
        public static bool Downloadfile(string url)
        {
            string s = Is_file(url);
            if (s !=string.Empty )
            {
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.Title = "下载文件";
                sfg.Filter = s + "|*" + s;
                sfg.ShowDialog();
                if (sfg.FileName!=string.Empty)
                {
                    Form down = new download(sfg.FileName, url);
                    down.Show();
                    while (down.Visible == true) Application.DoEvents();
                    down.Hide();
                    down.Dispose();
                }
                return true;
            }
            return false;
        }
    }
}
