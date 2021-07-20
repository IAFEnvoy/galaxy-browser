using browser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebKit;

namespace galaxy_browser.QR
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }
        Image im;
        Form1 fo = new Form1();//实例化addTag以方便调用
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择文件";
            ofd.Filter = "图片文件|*.jpg;*.png;*.bmp";
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)
            {
                textBox1.Text = ofd.FileName;
                im = Image.FromFile(ofd.FileName);
                pictureBox1.Image = im;
            }
            Bitmap bm = (Bitmap)im;
            textBox2.Text = QRcode.DecodeQrCode(bm);
            if (Webtitle.IsUrl(textBox2.Text) == true)
            {
                if (MessageBox.Show("识别到了一个网址\n是否打开此网页？", "QR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    WebKitBrowser wkn = new WebKitBrowser();
                    wkn.Navigate(textBox2.Text);
                    fo.addTag(wkn, true);
                    Hide();
                }
            }
        }
        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
        private void newQR()
        {
            if (IsNumeric(textBox4.Text) && IsNumeric(textBox5.Text) && textBox3.Text != string.Empty && textBox4.Text!=string.Empty && textBox5.Text != string.Empty)
                pictureBox2.Image = QRcode.BulidQRcode(textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            newQR();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            newQR();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            newQR();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            sfg.Title = "保存二维码";
            sfg.Filter = "图片文件|*.jpg;*.png;*.bmp";
            sfg.ShowDialog();
            if (sfg.FileName != string.Empty)
            {
                    string pictureName = sfg.FileName;
                    //照片另存
                    using (MemoryStream mem = new MemoryStream())
                    {
                        //这句很重要，不然不能正确保存图片或出错（关键就这一句）
                        Bitmap bmp = new Bitmap(pictureBox2.Image);
                        //保存到磁盘文件
                        bmp.Save(@pictureName, pictureBox2.Image.RawFormat);
                        bmp.Dispose();
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择文件";
            ofd.Filter = "图片文件|*.jpg;*.png;*.bmp";
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)
            {
                textBox6.Text = ofd.FileName;
                im = Image.FromFile(ofd.FileName);
                pictureBox3.Image = im;
            }
            Bitmap bm = (Bitmap)im;
            string s = QRcode.DecodeQrCode(bm);
            if (s == string.Empty || s==null)
            {
                MessageBox.Show("修复失败！","QR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBox4.Image = QRcode.BulidQRcode(s, 300, 10);
                MessageBox.Show("修复成功！", "QR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            sfg.Title = "保存二维码";
            sfg.Filter = "图片文件|*.jpg;*.png;*.bmp";
            sfg.ShowDialog();
            if (sfg.FileName != string.Empty)
            {
                    string pictureName = sfg.FileName;
                    //照片另存
                    using (MemoryStream mem = new MemoryStream())
                    {
                        //这句很重要，不然不能正确保存图片或出错（关键就这一句）
                        Bitmap bmp = new Bitmap(pictureBox4.Image);
                        //保存到磁盘文件
                        bmp.Save(@pictureName, pictureBox4.Image.RawFormat);
                        bmp.Dispose();
                    }
            }
        }
    }
}
