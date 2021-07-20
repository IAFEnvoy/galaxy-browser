using System;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Policy;
using System.Windows.Forms;
using System.Drawing;
using galaxy_browser;

namespace browser
{
    class Webtitle
    {
        public static String getTitle(String url)
        {
            //请求资源  
            System.Net.WebRequest wb = System.Net.WebRequest.Create(url.Trim());
            //响应请求  
            WebResponse webRes = null;
            //将返回的数据放入流中  
            Stream webStream = null;
            try
            {
                webRes = wb.GetResponse();
                webStream = webRes.GetResponseStream();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            //从流中读出数据  (这里如果乱码改变编码即可)
            StreamReader sr = new StreamReader(webStream, System.Text.Encoding.UTF8);
            //创建可变字符对象，用于保存网页数据   
            StringBuilder sb = new StringBuilder();
            //读出数据存入可变字符中  
            String str = "";
            while ((str = sr.ReadLine()) != null)
            {
                sb.Append(str);
            }
            //建立获取网页标题正则表达式  
            String regex = @"<title>.+</title>";
            //返回网页标题  
            String title = Regex.Match(sb.ToString(), regex).ToString();
            title = Regex.Replace(title, @"[\""]+", "");
            title = title.Replace("<title>", "");
            title = title.Replace("</title>", "");
            return title;
        }
        public static String GetTitlebyuri(Uri url)
        {
            //请求资源  
            System.Net.WebRequest wb = System.Net.WebRequest.Create(url);
            //响应请求  
            WebResponse webRes = null;
            //将返回的数据放入流中  
            Stream webStream = null;
            try
            {
                webRes = wb.GetResponse();
                webStream = webRes.GetResponseStream();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            //从流中读出数据  (这里如果乱码改变编码即可)
            StreamReader sr = new StreamReader(webStream, System.Text.Encoding.UTF8);
            //创建可变字符对象，用于保存网页数据   
            StringBuilder sb = new StringBuilder();
            //读出数据存入可变字符中  
            String str = "";
            while ((str = sr.ReadLine()) != null)
            {
                sb.Append(str);
            }
            //建立获取网页标题正则表达式  
            String regex = @"<title>.+</title>";
            //返回网页标题  
            String title = Regex.Match(sb.ToString(), regex).ToString();
            title = Regex.Replace(title, @"[\""]+", "");
            title = title.Replace("<title>", "");
            title = title.Replace("</title>", "");
            return title;
        }
        /*
        private void Geticon(string address)
        {
            string url = string.Empty; //网址图标地址

            int lastPointIndex = address.LastIndexOf(".");
            string prefix = address.Substring(0, lastPointIndex); //获取前缀
            if (!prefix.StartsWith("https://") && !prefix.StartsWith("http://"))
            {
                prefix = new StringBuilder("https://").Append(prefix).ToString();
            }

            string suffix = address.Substring(lastPointIndex); //获取后缀
            if (suffix.Contains("/"))
            {
                int slashIndex = suffix.IndexOf("/");
                suffix = suffix.Substring(0, slashIndex);
            }

            url = new StringBuilder(prefix).Append(suffix).Append("/favicon.ico").ToString();

            WebRequest request = WebRequest.Create(new Uri(url));
            request.Timeout = 20 * 1000;
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            using (Stream s = response.GetResponseStream())
            {
                byte[] buff = new byte[1024];
                int length = 0;
                using (MemoryStream ms = new MemoryStream())
                {
                    while ((length = s.Read(buff, 0, buff.Length)) > 0)
                    {
                        ms.Write(buff, 0, length);
                    }

                    byte[] arr = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(arr, 0, (int)ms.Length);
                    info.functionIcon = Convert.ToBase64String(arr).Trim();
                }
            }
            response.Close();
        }
        */
        /// <summary>
        /// 获取网页图标
        /// </summary>
        /// <param name="url">目标网址</param>
        /// <param name="temppath">图标缓存目录</param>
        /// <param name="defaulticon">出错时返回的图标</param>
        /// <returns>Image</returns>
        public static Image Getwebicon(string url,string temppath,Image defaulticon)
        {
            string[] s = url.Split('/');
            if(File.Exists(temppath + @"Icon\" + s[2] + ".ico") == true)
            {
                Image im = Image.FromFile(temppath + @"Icon\" + s[2] + ".ico");
                return im;
            }
            try {
                WebClient web = new WebClient();
                web.DownloadFile(s[0] + @"//" + s[2] + "/favicon.ico", temppath + @"Icon\" + s[2] + ".ico");
                Image im= Image.FromFile(temppath + @"Icon\" + s[2] + ".ico");
                return im;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return defaulticon;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为url
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsUrl(string str)
        {
            try
            {
                string Url = @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
                return Regex.IsMatch(str, Url);
            }
            catch
            {
                return false;
            }
        }
    }
}
