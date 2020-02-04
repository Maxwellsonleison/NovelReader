using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ReaderWin
{
    public partial class Form1 : Form
    {
        public string ContentF;
        public string TitleF;
        //set scroll speed
        public int ScrollSpeed = 60;
        //save last scroll local
        float ScrollCurrentPosition=0f;
        NovelsParser.OneChapter[] oneChapters;
        public Form1()
        {
            InitializeComponent();
            //using doublebuffer to refuse flash
            DoubleBuffered = true;
            
        }

        private void GetNovel(int index)
        {
            if (oneChapters == null || oneChapters.Length == 0) return;
            var t = oneChapters;
            TitleF = t[index].Title;
            ContentF = t[index].Content;
        }

        #region FormMethod
        protected override void OnPaint(PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(TitleF)) return;
            base.OnPaint(e);
            e.Graphics.PageUnit = GraphicsUnit.Pixel;
            e.Graphics.TranslateTransform(0, 0);
            e.Graphics.TranslateTransform(0, ScrollCurrentPosition);
            DrawTitle(TitleF, new Font("微软雅黑", 20, FontStyle.Bold), e.Graphics, new SolidBrush(Color.Black));
            DrawContent(ContentF, new Font("幼圆", 10, FontStyle.Regular), e.Graphics, new SolidBrush(Color.Black));
            
        }
        #region DrawMethod
        private void DrawTitle(string str, Font f, Graphics e, Brush b)
        {
            int leftsite = this.Width / 5;
            e.DrawString(str, f, b, new Point(leftsite, 0));

        }
        private void DrawContent(string str, Font f, Graphics e, Brush b)
        {
            int startside = this.Width / 5;
            int starthigh = 50;
            StringFormat stf = new StringFormat();
            Size sf = new Size(this.Width - 2 * this.Width / 5, this.Height);
            stf.Alignment = StringAlignment.Near;
            stf.LineAlignment = StringAlignment.Near;
            var s = TextRenderer.MeasureText(e, str, f, sf, TextFormatFlags.NoPadding);
            s.Width = this.Width - startside * 2;
            
            s.Height += 1000;
            e.SmoothingMode = SmoothingMode.AntiAlias;
            e.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.DrawString(str, f, b, new Rectangle(new Point(startside, starthigh), s));
            if (s.Height > sf.Height) { vScrollBar1.Maximum = s.Height/10 - sf.Height/10; vScrollBar1.Minimum = 0; }
        }
        #endregion
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void ScrollToLocal(float position,bool canScr)
        {

            if (position>=vScrollBar1.Maximum) return;
            if(canScr)
            {
                ScrollCurrentPosition = -position*10;
                this.Invalidate();
            }
        }

        Point TreeviewScrolPos;
        private void button1_Click(object sender, EventArgs e)
        {
            TreeviewScrolPos = new Point(0,0);
            if (treeView1.Visible)
            {
                TreeviewScrolPos = treeView1.AutoScrollOffset;
                treeView1.Visible = false;
            }
            else
            {
                treeView1.Visible = true;
                treeView1.AutoScrollOffset = TreeviewScrolPos;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (oneChapters==null||oneChapters.Length==0) return;
            foreach(var item in oneChapters)
            {
                treeView1.Nodes.Add(item.Title.TrimStart());
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            GetNovel(treeView1.SelectedNode.Index);
            vScrollBar1.Value = 0;
            Invalidate();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(()=>
            {
                FileDialog fdiag = new OpenFileDialog();
                fdiag.Filter = "文本文件|*.txt";
                fdiag.Title = "打开文件";
                if(fdiag.ShowDialog()==DialogResult.OK)
                {
                    oneChapters = NovelsParser.LocalNovelsParser.NovelsFile(fdiag.FileName).ToArray();
                    treeView1.Nodes.Clear();
                    foreach (var item in oneChapters)
                    {
                        treeView1.Nodes.Add(item.Title.TrimStart());
                    }
                    GetNovel(0);
                    Invalidate();
                }
                fdiag.Dispose();
                GC.Collect(0);
            }));
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mous_Y == 0) return;
            int value1 = e.Y - Location.Y;
            int value2 = value1 - mous_Y;
            value2 = value2/ScrollSpeed;
            int scrol_Y = vScrollBar1.Value + value2;
            if(scrol_Y>=0&&scrol_Y<vScrollBar1.Maximum)
            {
                vScrollBar1.Value = scrol_Y;
            }


        }

        int mous_Y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                mous_Y = e.Y - Location.Y;
            }
        }

        #endregion
        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            var s = sender as VScrollBar;
            float scrollY = s.Value;
            ScrollToLocal(scrollY, true);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mous_Y = 0;
        }
    }
}
