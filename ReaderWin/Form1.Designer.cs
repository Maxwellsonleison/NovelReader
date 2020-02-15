namespace ReaderWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnPool = new System.Windows.Forms.FlowLayoutPanel();
            this.Mic_Btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Menu_Btn = new System.Windows.Forms.Button();
            this.reMusicPlayer1 = new ReaderWin.ReMusicPlayer();
            this.stateRing1 = new ReaderWin.StateRing();
            this.BtnPool.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(781, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 464);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "目录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 43);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(225, 329);
            this.treeView1.TabIndex = 2;
            this.treeView1.Visible = false;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_Click);
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "打开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.CausesValidation = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(1, 55);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "书签";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnPool
            // 
            this.BtnPool.Controls.Add(this.button1);
            this.BtnPool.Controls.Add(this.button2);
            this.BtnPool.Controls.Add(this.button3);
            this.BtnPool.Controls.Add(this.Mic_Btn);
            this.BtnPool.Controls.Add(this.button4);
            this.BtnPool.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BtnPool.Location = new System.Drawing.Point(12, 43);
            this.BtnPool.Margin = new System.Windows.Forms.Padding(1);
            this.BtnPool.Name = "BtnPool";
            this.BtnPool.Size = new System.Drawing.Size(150, 143);
            this.BtnPool.TabIndex = 8;
            // 
            // Mic_Btn
            // 
            this.Mic_Btn.CausesValidation = false;
            this.Mic_Btn.FlatAppearance.BorderSize = 0;
            this.Mic_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mic_Btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Mic_Btn.Location = new System.Drawing.Point(1, 82);
            this.Mic_Btn.Margin = new System.Windows.Forms.Padding(1);
            this.Mic_Btn.Name = "Mic_Btn";
            this.Mic_Btn.Size = new System.Drawing.Size(145, 25);
            this.Mic_Btn.TabIndex = 9;
            this.Mic_Btn.Text = "音乐播放器";
            this.Mic_Btn.UseVisualStyleBackColor = true;
            this.Mic_Btn.Click += new System.EventHandler(this.Mic_Btn_Click);
            // 
            // button4
            // 
            this.button4.CausesValidation = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(1, 109);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "关于";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Menu_Btn
            // 
            this.Menu_Btn.CausesValidation = false;
            this.Menu_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_Btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Menu_Btn.Location = new System.Drawing.Point(12, 10);
            this.Menu_Btn.Margin = new System.Windows.Forms.Padding(1);
            this.Menu_Btn.Name = "Menu_Btn";
            this.Menu_Btn.Size = new System.Drawing.Size(25, 25);
            this.Menu_Btn.TabIndex = 9;
            this.Menu_Btn.Text = "+";
            this.Menu_Btn.UseVisualStyleBackColor = true;
            this.Menu_Btn.Click += new System.EventHandler(this.Menu_Btn_Click);
            // 
            // reMusicPlayer1
            // 
            this.reMusicPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reMusicPlayer1.Location = new System.Drawing.Point(0, 377);
            this.reMusicPlayer1.Name = "reMusicPlayer1";
            this.reMusicPlayer1.Size = new System.Drawing.Size(187, 86);
            this.reMusicPlayer1.TabIndex = 10;
            // 
            // stateRing1
            // 
            this.stateRing1.BackRingColor = System.Drawing.Color.Black;
            this.stateRing1.ForeStateColor = System.Drawing.Color.Red;
            this.stateRing1.Location = new System.Drawing.Point(385, 169);
            this.stateRing1.Name = "stateRing1";
            this.stateRing1.Size = new System.Drawing.Size(263, 240);
            this.stateRing1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 464);
            this.Controls.Add(this.stateRing1);
            this.Controls.Add(this.reMusicPlayer1);
            this.Controls.Add(this.Menu_Btn);
            this.Controls.Add(this.BtnPool);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.vScrollBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reader";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.BtnPool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel BtnPool;
        private System.Windows.Forms.Button Menu_Btn;
        private System.Windows.Forms.Button button4;
        private ReMusicPlayer reMusicPlayer1;
        private System.Windows.Forms.Button Mic_Btn;
        private StateRing stateRing1;
    }
}

