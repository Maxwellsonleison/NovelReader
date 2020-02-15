using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReaderWin
{
    public partial class ReMusicPlayer : UserControl
    {
        public string play_mic="正在播放:";
        private Rectangle drawrec;
        int scrollFPS = 10;
        int currentTranPos=0;
        public string _PlayerDirectory;
        public ReMusicPlayer()
        {
            InitializeComponent();
            timer1.Interval = 2000/scrollFPS;
            drawrec = new Rectangle(new Point(5,5),new Size(352,40));
            timer1.Enabled = true;
            //timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            SizeF str_size = g.MeasureString(play_mic,new Font("幼圆",10,FontStyle.Regular));
            //g.DrawString(play_mic, new Font("幼圆", 15, FontStyle.Regular), new SolidBrush(Color.Blue), drawrec);
            g.TranslateTransform(currentTranPos,0);
            //only draw insight
            if (g.Clip.IsVisible(str_size.Width, 5))
            {
                g.DrawString(play_mic, new Font("幼圆", 10, FontStyle.Regular), new SolidBrush(Color.Blue), drawrec);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                int i = 5;
                currentTranPos += i;
                if(currentTranPos>=drawrec.Width/2)
                {
                    currentTranPos = -drawrec.Width/2;
                    Invalidate();
                }
                Invalidate();
        }

        private void axWXM_Played(object sender,AxWMPLib.AxWindowsMediaPlayer e)
        {

        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                timer1.Start();
                play_mic = "正在播放:"+axWindowsMediaPlayer1.currentMedia.name;
            }
        }

        private void ReMusicPlayer_EnabledChanged(object sender, EventArgs e)
        {
            if(Enabled)
            {
                WMPLib.IWMPPlaylist _List = axWindowsMediaPlayer1.playlistCollection.newPlaylist("CurrentList");

                foreach(var f in Directory.GetFiles(_PlayerDirectory,"*.mp3"))
                {
                    var _media = axWindowsMediaPlayer1.newMedia(f);
                    if (_media == null) break;
                    _List.appendItem(_media);
                }
                if (_List == null) return;
                axWindowsMediaPlayer1.currentPlaylist = _List;
                //play
                axWindowsMediaPlayer1.Ctlenabled = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }
    }
}
