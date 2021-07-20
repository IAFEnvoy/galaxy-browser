using browser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WebKit;

namespace galaxy_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Size tag;
        Color Grey = Color.FromArgb(222, 225, 230);
        Color back = Color.Red;

        StreamWriter his;
        string start="https://www.baidu.com";
        struct Browser
        {
            public WebKit.WebKitBrowser web;
            public Panel tag;
        }
        Browser[] bro = new Browser[100];
        int cnt=0, select=0;
        WebKitBrowser web = new WebKitBrowser();

        //添加页
        public void addTag(WebKitBrowser we,bool yes)
        {
            cnt++;
            if (yes == true) bro[cnt].web = we;
            else {
                bro[cnt].web = new WebKitBrowser();
                bro[cnt].web.Navigate(start);
            }
            bro[cnt].tag = new Panel();
            bro[cnt].web.Dock = DockStyle.Fill;
            bro[cnt].web.NewWindowCreated += Web_NewWindowCreated;
            bro[cnt].web.DocumentTitleChanged += Web_DocumentTitleChanged;
            bro[cnt].web.DocumentCompleted += Web_DocumentCompleted;
            bro[cnt].web.KeyDown += Form1_KeyDown;

            TagContext(bro[cnt].tag);
            bro[cnt].tag.Size = tag;
            bro[cnt].tag.Location = new Point((cnt - 1) * 170, 0);

            web = bro[cnt].web;
            showplace.Controls.Clear();
            showplace.Controls.Add(web);
            web.Focus();

            select = cnt;
            pnlAddTag.Location = new Point(cnt * 170, pnlAddTag.Location.Y);
            draw();
        }
        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            while (web.Url == null) Application.DoEvents();
            if (Files.Downloadfile(web.Url.AbsoluteUri) == true)
            {
                web.GoBack();
            }
        }
        private void Web_DocumentTitleChanged(object sender, EventArgs e)
        {
            WebKit.WebKitBrowser wb = ((WebKit.WebKitBrowser)sender);
            texturl.Text = wb.Url.ToString().ToLower();
            for (int i = 1; i <= cnt; i++)
                if (bro[i].tag.BackColor == Color.White)
                {
                    web = bro[i].web;
                    showplace.Controls.Clear();
                    showplace.Controls.Add(web);
                    texturl.Text = web.Url.ToString().ToLower();
                    changetitle(bro[i]);

                    select = i;
                }
            

        }

        private void Web_NewWindowCreated(object sender, NewWindowCreatedEventArgs e)
        {
            addTag(e.WebKitBrowser, true);
            web.Focus();
            while (web.Url == null) Application.DoEvents();
            
        }

        private void TagContext(Panel p)
        {
            //图标
            PictureBox pnlImage = new PictureBox();
            pnlImage.BackgroundImage = imageList1.Images[16];
            pnlImage.Location = new Point(5, 7);
            pnlImage.Size = new Size(12, 12);
            pnlImage.BackgroundImageLayout = ImageLayout.Stretch;
            pnlImage.Click += p_Click;
            p.Controls.Add(pnlImage);

            //关闭标签页
            Panel pnlClose = new Panel();
            pnlClose.BackgroundImage = imageList1.Images[6];
            pnlClose.Location = new Point(180, 43);
            pnlClose.Anchor = AnchorStyles.Right;
            pnlClose.Size = new Size(15, 15);
            pnlClose.Cursor = Cursors.Hand;
            pnlClose.BackgroundImageLayout = ImageLayout.Zoom;
            pnlClose.Click += pnlClose_Click;
            p.Controls.Add(pnlClose);

            //标题
            Label lblTitle = new Label();
            lblTitle.AutoSize = true;
            Font font = new System.Drawing.Font("微软雅黑", 9);
            lblTitle.Font = font;
            lblTitle.Location = new Point(17, 5);
            lblTitle.Size = new Size(130, 24);
            lblTitle.Click += p_Click;
            p.Controls.Add(lblTitle);

            p.BackColor = Color.White;
            p.Click += p_Click;
        }
        private void draw()
        {
            while (bro[select].tag.Size != tag)
            {
                select++;
                if (select > cnt) select = 1;
            }
            for (int i = 1; i <= cnt; i++) bro[i].tag.BackColor = Grey;
            panel2.Controls.Clear();
            for(int i = 1; i <= cnt; i++)
            {
                if (i == select) bro[i].tag.BackColor = Color.White;
                panel2.Controls.Add(bro[i].tag);
            }
            web = bro[select].web;
            showplace.Controls.Clear();
            showplace.Controls.Add(web);
            while (web.Url == null) Application.DoEvents();
            texturl.Text = web.Url.AbsoluteUri;
        }
        private void pnlClose_Click(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                System.Environment.Exit(0);
            }
            Panel pnl = (Panel)sender;
            Panel l = (Panel)pnl.Parent;
            l.BackColor = back;
            for (int i = 1; i <= cnt; i++)
                if (bro[i].tag.BackColor == back)
                {
                    bro[i].web = new WebKitBrowser();
                    bro[i].tag = new Panel();
                    if (i == cnt) select = i - 1;
                    for (int j = i + 1; j <= cnt; j++)
                    {
                        bro[j - 1].tag = bro[j].tag;
                        bro[j - 1].web = bro[j].web;
                        bro[j].web = new WebKitBrowser();
                        bro[j].tag = new Panel();
                        bro[j - 1].tag.Location = new Point(bro[j - 1].tag.Location.X - 150, bro[j - 1].tag.Location.Y);
                    }
                    break;
                }
            cnt--;
            pnlAddTag.Location = new Point(cnt * 170, pnlAddTag.Location.Y);
            draw();
            web.Focus();
        }
        private void changetitle(Browser br)
        {
            try
            {
                WebKitBrowser wb = br.web;
                foreach (Control co in br.tag.Controls)
                {
                    if (co is Label la)
                    {
                        la.Text = wb.DocumentTitle.Length > 9 ? wb.DocumentTitle.Substring(0, 9) + "..." : wb.DocumentTitle;
                        this.Text = wb.DocumentTitle + "-银河浏览器";
                    }
                    ///*
                    if (co is PictureBox pic)
                    {
                        while (web.Url == null) Application.DoEvents();
                        var s = Webtitle.Getwebicon(web.Url.AbsoluteUri, Global_variable.temppath, imageList1.Images[16]);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = s;
                    }
                    //*/
                }
                ///历史记录///
                string date = DateTime.Now.ToShortDateString();
                date = date.Replace("/", "-");
                his = File.AppendText(Application.StartupPath + @"\History\" + date + ".his");
                his.WriteLine(DateTime.Now.ToLongTimeString().ToString() +" "+wb.Url.AbsoluteUri + " " + wb.DocumentTitle);
                his.Close();
                ///历史记录///
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void p_Click(object sender, EventArgs e)
        {
            if(sender is Panel pnl)
            {
                for (int i = 1; i <= cnt; i++) bro[i].tag.BackColor = Grey;
                pnl.BackColor = Color.White;
                for (int i = 1; i <= cnt; i++)
                    if (bro[i].tag.BackColor == Color.White)
                    {
                        web = bro[i].web;
                        showplace.Controls.Clear();
                        showplace.Controls.Add(web);
                        if (web.Url != null) texturl.Text = web.Url.ToString().ToLower();
                        changetitle(bro[i]);

                        select = i;
                    }
                web.Focus();
            }
            if(sender is Label la)
            {
                Panel l = (Panel)la.Parent;
                for (int i = 1; i <= cnt; i++) bro[i].tag.BackColor = Grey;
                l.BackColor = Color.White;
                for (int i = 1; i <= cnt; i++)
                    if (bro[i].tag.BackColor == Color.White)
                    {
                        web = bro[i].web;
                        showplace.Controls.Clear();
                        showplace.Controls.Add(web);
                        texturl.Text = web.Url.ToString().ToLower();
                        changetitle(bro[i]);

                        select = i;
                    }
            }
        }

        private void addpage_Click(object sender, EventArgs e)
        {
            addTag(new WebKitBrowser(),false);
            web.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menu.BackgroundImage = imageList1.Images[8];
            backward.BackgroundImage = imageList1.Images[9];
            forward.BackgroundImage = imageList1.Images[10];
            miniwindow.BackgroundImage = imageList1.Images[4];
            maxwindow.BackgroundImage = imageList1.Images[2];
            exit.BackgroundImage = imageList1.Images[0];
            pnlAddTag.BackgroundImage = imageList1.Images[11];
            reload.BackgroundImage = imageList1.Images[17];

            tag = new Size(165, pnlAddTag.Size.Height);
            addTag(new WebKitBrowser(), false);

            this.BackColor = Grey;
            menulist.BackColor = Grey;
            menulist.Visible = false;

            
        }
        #region 窗体操作
        private void maxwindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void miniwindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void backward_Click(object sender, EventArgs e)
        {
            if (web.CanGoBack)
            {
                web.GoBack();
            }
        }
        private void forward_Click(object sender, EventArgs e)
        {
            if (web.CanGoForward)
            {
                web.GoForward();
            }
        }
        private void maxwindow_MouseEnter(object sender, EventArgs e)
        {
            maxwindow.BackgroundImage = imageList1.Images[3];
        }
        private void maxwindow_MouseLeave(object sender, EventArgs e)
        {
            maxwindow.BackgroundImage = imageList1.Images[2];
        }
        private void miniwindow_MouseEnter(object sender, EventArgs e)
        {
            miniwindow.BackgroundImage = imageList1.Images[5];
        }
        private void miniwindow_MouseLeave(object sender, EventArgs e)
        {
            miniwindow.BackgroundImage = imageList1.Images[4];
        }
        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackgroundImage = imageList1.Images[1];
        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (menulist.Visible == true) menulist.Visible = false;
            else menulist.Visible = true;
        }
        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = imageList1.Images[0];
        }
        #endregion

        #region 拖动窗口
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region 按钮变化
        private void reload_MouseEnter(object sender, EventArgs e)
        {
            reload.BackgroundImage = imageList1.Images[18];
        }
        private void reload_MouseLeave(object sender, EventArgs e)
        {
            reload.BackgroundImage = imageList1.Images[17];
        }
        private void forward_MouseEnter(object sender, EventArgs e)
        {
            forward.BackgroundImage = imageList1.Images[13];
        }

        private void backward_MouseEnter(object sender, EventArgs e)
        {
            backward.BackgroundImage = imageList1.Images[12];
        }

        private void menu_MouseEnter(object sender, EventArgs e)
        {
            menu.BackgroundImage = imageList1.Images[14];
        }

        private void forward_MouseLeave(object sender, EventArgs e)
        {
            forward.BackgroundImage = imageList1.Images[10];
        }

        private void backward_MouseLeave(object sender, EventArgs e)
        {
            backward.BackgroundImage = imageList1.Images[9];
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.BackgroundImage = imageList1.Images[8];
        }

        private void pnlAddTag_MouseEnter(object sender, EventArgs e)
        {
            pnlAddTag.BackgroundImage = imageList1.Images[15];
        }

        private void pnlAddTag_MouseLeave(object sender, EventArgs e)
        {
            pnlAddTag.BackgroundImage = imageList1.Images[11];
        }
        #endregion

        private void texturl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 1; i <= cnt; i++)
                    if (bro[i].tag.BackColor == Color.White)
                    {
                        bro[i].web.Navigate(texturl.Text);
                        web = bro[i].web;
                        showplace.Controls.Clear();
                        showplace.Controls.Add(web);
                        changetitle(bro[i]);

                        select = i;
                    }
                web.Focus();
            }
            Form1_KeyDown(sender, e);
        }

        private void reload_Click(object sender, EventArgs e)
        {
            foreach(Control con in showplace.Controls)
            {
                if(con is WebKitBrowser web)
                {
                    web.Reload();
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
        }

        #region 按键控制
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                addpage_Click(sender, e);
            }
            //if (e.Control && e.KeyCode == Keys.W)
            //{
            //    pnlClose_Click(sender, e);
            //}
            if (e.Alt && e.KeyCode == Keys.X)
            {
                notifyIcon1.Visible = true;
                Hide();
            }
        }
        #endregion

        private void toolbox_Click(object sender, EventArgs e)
        {
            menu_Click(sender, e);
            Form f = new toolbox();
            f.Show();
            while (f.Visible == true) Application.DoEvents();
            f.Dispose();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            menu_Click(sender, e);
            Form f = new setting();
            f.Show();
            while (f.Visible == true) Application.DoEvents();
            f.Dispose();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            showplace.Location = new Point(0, 66);
            showplace.Size = new Size(this.Width, this.Height - 66);

            button.Location = new Point(this.Width - button.Width, button.Location.Y);

            panel2.Size = new Size(this.Width, panel2.Height);

            texturl.Size = new Size(button.Location.X - texturl.Location.X, texturl.Height);

            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(this.Width, 50);
        }
    }
}
