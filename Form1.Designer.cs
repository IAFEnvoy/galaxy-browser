using WebKit;

namespace galaxy_browser
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showplace = new System.Windows.Forms.Panel();
            this.texturl = new System.Windows.Forms.TextBox();
            this.forward = new System.Windows.Forms.Panel();
            this.backward = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Panel();
            this.maxwindow = new System.Windows.Forms.Panel();
            this.miniwindow = new System.Windows.Forms.Panel();
            this.pnlAddTag = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button = new System.Windows.Forms.Panel();
            this.hehe = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menulist = new System.Windows.Forms.Panel();
            this.history = new System.Windows.Forms.Label();
            this.toolbox = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button.SuspendLayout();
            this.menulist.SuspendLayout();
            this.SuspendLayout();
            // 
            // showplace
            // 
            this.showplace.Location = new System.Drawing.Point(8, 82);
            this.showplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showplace.Name = "showplace";
            this.showplace.Size = new System.Drawing.Size(781, 382);
            this.showplace.TabIndex = 0;
            // 
            // texturl
            // 
            this.texturl.Location = new System.Drawing.Point(159, 25);
            this.texturl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texturl.Name = "texturl";
            this.texturl.Size = new System.Drawing.Size(613, 25);
            this.texturl.TabIndex = 1;
            this.texturl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texturl_KeyDown);
            // 
            // forward
            // 
            this.forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forward.BackgroundImage")));
            this.forward.Location = new System.Drawing.Point(83, 19);
            this.forward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(32, 30);
            this.forward.TabIndex = 2;
            this.toolTip1.SetToolTip(this.forward, "前进");
            this.forward.Click += new System.EventHandler(this.forward_Click);
            this.forward.MouseEnter += new System.EventHandler(this.forward_MouseEnter);
            this.forward.MouseLeave += new System.EventHandler(this.forward_MouseLeave);
            // 
            // backward
            // 
            this.backward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backward.BackgroundImage")));
            this.backward.Location = new System.Drawing.Point(45, 19);
            this.backward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(32, 30);
            this.backward.TabIndex = 3;
            this.toolTip1.SetToolTip(this.backward, "后退");
            this.backward.Click += new System.EventHandler(this.backward_Click);
            this.backward.MouseEnter += new System.EventHandler(this.backward_MouseEnter);
            this.backward.MouseLeave += new System.EventHandler(this.backward_MouseLeave);
            // 
            // menu
            // 
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.Location = new System.Drawing.Point(8, 19);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(32, 30);
            this.menu.TabIndex = 3;
            this.toolTip1.SetToolTip(this.menu, "菜单");
            this.menu.Click += new System.EventHandler(this.menu_Click);
            this.menu.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.menu.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.Location = new System.Drawing.Point(77, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 30);
            this.exit.TabIndex = 3;
            this.toolTip1.SetToolTip(this.exit, "关闭");
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // maxwindow
            // 
            this.maxwindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maxwindow.BackgroundImage")));
            this.maxwindow.Location = new System.Drawing.Point(40, 2);
            this.maxwindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxwindow.Name = "maxwindow";
            this.maxwindow.Size = new System.Drawing.Size(32, 30);
            this.maxwindow.TabIndex = 3;
            this.toolTip1.SetToolTip(this.maxwindow, "最大化");
            this.maxwindow.Click += new System.EventHandler(this.maxwindow_Click);
            this.maxwindow.MouseEnter += new System.EventHandler(this.maxwindow_MouseEnter);
            this.maxwindow.MouseLeave += new System.EventHandler(this.maxwindow_MouseLeave);
            // 
            // miniwindow
            // 
            this.miniwindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("miniwindow.BackgroundImage")));
            this.miniwindow.Location = new System.Drawing.Point(3, 4);
            this.miniwindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miniwindow.Name = "miniwindow";
            this.miniwindow.Size = new System.Drawing.Size(32, 30);
            this.miniwindow.TabIndex = 3;
            this.toolTip1.SetToolTip(this.miniwindow, "最小化");
            this.miniwindow.Click += new System.EventHandler(this.miniwindow_Click);
            this.miniwindow.MouseEnter += new System.EventHandler(this.miniwindow_MouseEnter);
            this.miniwindow.MouseLeave += new System.EventHandler(this.miniwindow_MouseLeave);
            // 
            // pnlAddTag
            // 
            this.pnlAddTag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddTag.BackgroundImage")));
            this.pnlAddTag.Location = new System.Drawing.Point(8, 52);
            this.pnlAddTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddTag.Name = "pnlAddTag";
            this.pnlAddTag.Size = new System.Drawing.Size(32, 30);
            this.pnlAddTag.TabIndex = 5;
            this.toolTip1.SetToolTip(this.pnlAddTag, "打开新的标签页");
            this.pnlAddTag.Click += new System.EventHandler(this.addpage_Click);
            this.pnlAddTag.MouseEnter += new System.EventHandler(this.pnlAddTag_MouseEnter);
            this.pnlAddTag.MouseLeave += new System.EventHandler(this.pnlAddTag_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "close-blue.png");
            this.imageList1.Images.SetKeyName(2, "max.png");
            this.imageList1.Images.SetKeyName(3, "max-blue.png");
            this.imageList1.Images.SetKeyName(4, "min.png");
            this.imageList1.Images.SetKeyName(5, "mix-blue.png");
            this.imageList1.Images.SetKeyName(6, "close-tag.png");
            this.imageList1.Images.SetKeyName(7, "close-tag-select.png");
            this.imageList1.Images.SetKeyName(8, "menu.png");
            this.imageList1.Images.SetKeyName(9, "back.png");
            this.imageList1.Images.SetKeyName(10, "forward.png");
            this.imageList1.Images.SetKeyName(11, "add.png");
            this.imageList1.Images.SetKeyName(12, "back-blue.png");
            this.imageList1.Images.SetKeyName(13, "forward-blue.png");
            this.imageList1.Images.SetKeyName(14, "menu-blue.png");
            this.imageList1.Images.SetKeyName(15, "add-blue.png");
            this.imageList1.Images.SetKeyName(16, "tagImage.png");
            this.imageList1.Images.SetKeyName(17, "reload.png");
            this.imageList1.Images.SetKeyName(18, "reload-blue.png");
            // 
            // button
            // 
            this.button.Controls.Add(this.hehe);
            this.button.Controls.Add(this.miniwindow);
            this.button.Controls.Add(this.exit);
            this.button.Controls.Add(this.maxwindow);
            this.button.Location = new System.Drawing.Point(779, 19);
            this.button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(124, 44);
            this.button.TabIndex = 7;
            // 
            // hehe
            // 
            this.hehe.Location = new System.Drawing.Point(93, 32);
            this.hehe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hehe.Name = "hehe";
            this.hehe.Size = new System.Drawing.Size(15, 8);
            this.hehe.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 30);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 16);
            this.panel1.TabIndex = 9;
            this.panel1.DoubleClick += new System.EventHandler(this.maxwindow_Click);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // menulist
            // 
            this.menulist.BackColor = System.Drawing.SystemColors.Control;
            this.menulist.Controls.Add(this.history);
            this.menulist.Controls.Add(this.toolbox);
            this.menulist.Controls.Add(this.setting);
            this.menulist.Location = new System.Drawing.Point(8, 51);
            this.menulist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menulist.Name = "menulist";
            this.menulist.Size = new System.Drawing.Size(139, 115);
            this.menulist.TabIndex = 10;
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.history.Location = new System.Drawing.Point(4, 2);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(127, 36);
            this.history.TabIndex = 13;
            this.history.Text = "历史记录";
            // 
            // toolbox
            // 
            this.toolbox.AutoSize = true;
            this.toolbox.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolbox.Location = new System.Drawing.Point(3, 38);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(99, 36);
            this.toolbox.TabIndex = 12;
            this.toolbox.Text = "工具箱";
            this.toolbox.Click += new System.EventHandler(this.toolbox_Click);
            // 
            // setting
            // 
            this.setting.AutoSize = true;
            this.setting.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setting.Location = new System.Drawing.Point(4, 74);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(71, 36);
            this.setting.TabIndex = 11;
            this.setting.Text = "设置";
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(121, 19);
            this.reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(32, 30);
            this.reload.TabIndex = 3;
            this.toolTip1.SetToolTip(this.reload, "刷新当前网页");
            this.reload.Click += new System.EventHandler(this.reload_Click);
            this.reload.MouseEnter += new System.EventHandler(this.reload_MouseEnter);
            this.reload.MouseLeave += new System.EventHandler(this.reload_MouseLeave);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "银河浏览器";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 512);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.menulist);
            this.Controls.Add(this.button);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.pnlAddTag);
            this.Controls.Add(this.backward);
            this.Controls.Add(this.showplace);
            this.Controls.Add(this.texturl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.button.ResumeLayout(false);
            this.menulist.ResumeLayout(false);
            this.menulist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel showplace;
        private System.Windows.Forms.TextBox texturl;
        private System.Windows.Forms.Panel forward;
        private System.Windows.Forms.Panel backward;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel exit;
        private System.Windows.Forms.Panel maxwindow;
        private System.Windows.Forms.Panel miniwindow;
        private System.Windows.Forms.Panel pnlAddTag;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel button;
        private System.Windows.Forms.Panel hehe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menulist;
        private System.Windows.Forms.Panel reload;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Label toolbox;
        private System.Windows.Forms.Label setting;
    }
}

