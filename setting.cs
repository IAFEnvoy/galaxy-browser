using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galaxy_browser
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }
        private void setting_Load(object sender, EventArgs e)
        {
            long web = Dictionary_size.GetDirectoryLength(Global_variable.temppath);
            long his= Dictionary_size.GetDirectoryLength(Global_variable.historypath);
            label2.Text = Dictionary_size.To_small(his);
            label3.Text = Dictionary_size.To_small(web);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "读取中。。。")
            {
                MessageBox.Show("不要着急，我还没有读取完呢！");
                return;
            }
            DirectoryInfo TheFolder = new DirectoryInfo(Global_variable.historypath);
            foreach (FileInfo fi in TheFolder.GetFiles())//遍历文件夹下所有文件
            {
                if (File_state.IsFileInUse(fi.FullName) == false)
                    File.Delete(fi.FullName);
            }
            setting_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "读取中。。。")
            {
                MessageBox.Show("不要着急，我还没有读取完呢！");
                return;
            }
            DirectoryInfo TheFolder = new DirectoryInfo(Global_variable.temppath+@"Icon\");
            foreach (FileInfo fi in TheFolder.GetFiles())//遍历文件夹下所有文件
            {
                if (File_state.IsFileInUse(fi.FullName) == false)
                    File.Delete(fi.FullName);
            }
            TheFolder = new DirectoryInfo(Global_variable.temppath + @"Music\");
            foreach (FileInfo fi in TheFolder.GetFiles())//遍历文件夹下所有文件
            {
                if (File_state.IsFileInUse(fi.FullName) == false)
                    File.Delete(fi.FullName);
            }
            setting_Load(sender, e);
        }
    }
}
