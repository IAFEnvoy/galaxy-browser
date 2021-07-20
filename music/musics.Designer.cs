namespace NeteaseMuisc
{
    partial class musics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musics));
            this.search = new System.Windows.Forms.Button();
            this.music_name_s = new System.Windows.Forms.TextBox();
            this.music_play = new AxWMPLib.AxWindowsMediaPlayer();
            this.web = new System.Windows.Forms.WebBrowser();
            this.download = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_message = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.music_play)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(256, 3);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(68, 23);
            this.search.TabIndex = 0;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // music_name_s
            // 
            this.music_name_s.Location = new System.Drawing.Point(56, 3);
            this.music_name_s.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.music_name_s.Name = "music_name_s";
            this.music_name_s.Size = new System.Drawing.Size(196, 21);
            this.music_name_s.TabIndex = 1;
            // 
            // music_play
            // 
            this.music_play.Enabled = true;
            this.music_play.Location = new System.Drawing.Point(9, 332);
            this.music_play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.music_play.Name = "music_play";
            this.music_play.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("music_play.OcxState")));
            this.music_play.Size = new System.Drawing.Size(474, 104);
            this.music_play.TabIndex = 3;
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(279, 355);
            this.web.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.web.MinimumSize = new System.Drawing.Size(15, 16);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(125, 62);
            this.web.TabIndex = 6;
            this.web.Visible = false;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(407, 3);
            this.download.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 7;
            this.download.Text = "下载";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "播放";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "歌曲名：";
            // 
            // list_message
            // 
            this.list_message.FormattingEnabled = true;
            this.list_message.ItemHeight = 12;
            this.list_message.Location = new System.Drawing.Point(10, 30);
            this.list_message.Name = "list_message";
            this.list_message.Size = new System.Drawing.Size(473, 304);
            this.list_message.TabIndex = 12;
            this.list_message.SelectedIndexChanged += new System.EventHandler(this.list_message_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // musics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 446);
            this.Controls.Add(this.list_message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.download);
            this.Controls.Add(this.web);
            this.Controls.Add(this.music_play);
            this.Controls.Add(this.music_name_s);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "musics";
            this.Text = "音乐下载器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.music_play)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox music_name_s;
        private AxWMPLib.AxWindowsMediaPlayer music_play;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_message;
        private System.Windows.Forms.Timer timer1;
    }
}