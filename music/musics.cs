using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace NeteaseMuisc
{
    public partial class musics : Form
    {
        private TaskbarManager windowsTaskbar = TaskbarManager.Instance;
        string[] url1 = new string[100];
        int num;
        bool ok = false;
        public musics()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ok = true;
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Indeterminate, this.Handle);
            num = 0;
            list_message.Items.Clear();
            var api = new NeteaseMusicAPI();//这里用到下面的两个Class
            var apires = api.Search(music_name_s.Text);//传入内容
            if (apires.Result.Songs == null) MessageBox.Show("没有找到你要的歌曲", "音乐下载器", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else foreach (var song in apires.Result.Songs)//循环读取歌曲信息
                {
                    if (api.GetSongsUrl(new long[] { song.Id }).Data[0].Url == null) continue;
                    url1[num] = api.GetSongsUrl(new long[] { song.Id }).Data[0].Url;
                    num = num + 1;
                    list_message.Items.Add(string.Format("{0} - {1}", song.Name, song.Ar[0].Name));//添加到list中
                }
            ok = false;
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, this.Handle);
            windowsTaskbar.SetProgressValue(0, 100, this.Handle);
        }
        private void download_Click(object sender, EventArgs e)
        {
            if (list_message.SelectedIndex >= 0)
            {
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.RestoreDirectory = false;
                sfg.Title = "下载到...";
                sfg.Filter = "(*.mp3)|*.mp3";
                sfg.FileName = list_message.SelectedItem.ToString() + ".mp3";
                sfg.ShowDialog();
                Form d = new download(sfg.FileName, url1[list_message.SelectedIndex]);
                d.Show();
                while (d.Visible == true) Application.DoEvents();
                d.Dispose();
            }
            else MessageBox.Show("你没有选歌，我怎么下载！！！", "音乐下载器", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (list_message.SelectedIndex >= 0)
            {
                music_play.URL = string.Format("{0}", url1[list_message.SelectedIndex]);//调用MediaPlayer播放获取到的链接
                music_play.Ctlcontrols.play();
            }
            else MessageBox.Show("你没有选歌，我怎么播放！！！", "音乐下载器", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, this.Handle);
            windowsTaskbar.SetProgressValue(0, 100, this.Handle);
        }
        private void list_message_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (music_play.playState == WMPLib.WMPPlayState.wmppsPlaying && ok == false)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, this.Handle);
                windowsTaskbar.SetProgressValue((int)music_play.Ctlcontrols.currentPosition, (int)music_play.currentMedia.duration, this.Handle);
            }
            if (music_play.playState == WMPLib.WMPPlayState.wmppsPaused && ok == false)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Paused, this.Handle);
                windowsTaskbar.SetProgressValue((int)music_play.Ctlcontrols.currentPosition, (int)music_play.currentMedia.duration, this.Handle);
            }
            if (music_play.playState == WMPLib.WMPPlayState.wmppsStopped && ok == false)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, this.Handle);
                windowsTaskbar.SetProgressValue((int)music_play.Ctlcontrols.currentPosition, (int)music_play.currentMedia.duration, this.Handle);
            }
        }
    }
}
