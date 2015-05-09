
namespace Downloader
{
   partial class frm1
   {
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
         this.pb = new System.Windows.Forms.ProgressBar();
         this.bStart = new System.Windows.Forms.Button();
         this.bCancel = new System.Windows.Forms.Button();
         this.tSource = new System.Windows.Forms.TextBox();
         this.tTarget = new System.Windows.Forms.TextBox();
         this.l1 = new System.Windows.Forms.Label();
         this.l2 = new System.Windows.Forms.Label();
         this.fol = new System.Windows.Forms.FolderBrowserDialog();
         this.tim = new System.Windows.Forms.Timer(this.components);
         this.lab = new System.Windows.Forms.Label();
         this.bBrowse = new System.Windows.Forms.Button();
         this.bPaste = new System.Windows.Forms.Button();
         this.info = new System.Windows.Forms.Label();
         this.not = new System.Windows.Forms.NotifyIcon(this.components);
         this.close = new System.Windows.Forms.CheckBox();
         this.vit = new System.Windows.Forms.Label();
         this.tip = new System.Windows.Forms.ToolTip(this.components);
         this.SuspendLayout();
         // 
         // pb
         // 
         this.pb.ForeColor = System.Drawing.Color.MediumVioletRed;
         this.pb.Location = new System.Drawing.Point(12, 111);
         this.pb.Name = "pb";
         this.pb.Size = new System.Drawing.Size(412, 18);
         this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         this.pb.TabIndex = 9;
         // 
         // bStart
         // 
         this.bStart.Enabled = false;
         this.bStart.Location = new System.Drawing.Point(12, 152);
         this.bStart.Name = "bStart";
         this.bStart.Size = new System.Drawing.Size(100, 26);
         this.bStart.TabIndex = 4;
         this.bStart.Text = "Start";
         this.bStart.Click += new System.EventHandler(this.bStart_Click);
         // 
         // bCancel
         // 
         this.bCancel.Enabled = false;
         this.bCancel.Location = new System.Drawing.Point(324, 152);
         this.bCancel.Name = "bCancel";
         this.bCancel.Size = new System.Drawing.Size(100, 26);
         this.bCancel.TabIndex = 5;
         this.bCancel.Text = "Cancel";
         this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
         // 
         // tSource
         // 
         this.tSource.Location = new System.Drawing.Point(12, 25);
         this.tSource.Name = "tSource";
         this.tSource.Size = new System.Drawing.Size(412, 20);
         this.tSource.TabIndex = 0;
         this.tSource.TextChanged += new System.EventHandler(this.tSource_TextChanged);
         // 
         // tTarget
         // 
         this.tTarget.Location = new System.Drawing.Point(12, 72);
         this.tTarget.Name = "tTarget";
         this.tTarget.ReadOnly = true;
         this.tTarget.Size = new System.Drawing.Size(412, 20);
         this.tTarget.TabIndex = 2;
         this.tTarget.TextChanged += new System.EventHandler(this.tTarget_TextChanged);
         // 
         // l1
         // 
         this.l1.AutoSize = true;
         this.l1.Location = new System.Drawing.Point(12, 9);
         this.l1.Name = "l1";
         this.l1.Size = new System.Drawing.Size(71, 13);
         this.l1.TabIndex = 6;
         this.l1.Text = "From internet:";
         // 
         // l2
         // 
         this.l2.AutoSize = true;
         this.l2.Location = new System.Drawing.Point(12, 53);
         this.l2.Name = "l2";
         this.l2.Size = new System.Drawing.Size(77, 13);
         this.l2.TabIndex = 5;
         this.l2.Text = "To local folder:";
         // 
         // fol
         // 
         this.fol.Description = "Change download target:";
         // 
         // tim
         // 
         this.tim.Interval = 1000;
         this.tim.Tick += new System.EventHandler(this.tim_Tick);
         // 
         // lab
         // 
         this.lab.AutoSize = true;
         this.lab.Location = new System.Drawing.Point(150, 145);
         this.lab.Name = "lab";
         this.lab.Size = new System.Drawing.Size(68, 39);
         this.lab.TabIndex = 2;
         this.lab.Text = "Total KB:\r\nKB received:\r\nProgress:";
         this.lab.Visible = false;
         // 
         // bBrowse
         // 
         this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.bBrowse.Image = ((System.Drawing.Image)(resources.GetObject("bBrowse.Image")));
         this.bBrowse.Location = new System.Drawing.Point(401, 75);
         this.bBrowse.Name = "bBrowse";
         this.bBrowse.Size = new System.Drawing.Size(20, 14);
         this.bBrowse.TabIndex = 3;
         this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
         this.bBrowse.MouseHover += new System.EventHandler(this.bBrowse_MouseHover);
         // 
         // bPaste
         // 
         this.bPaste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.bPaste.Image = ((System.Drawing.Image)(resources.GetObject("bPaste.Image")));
         this.bPaste.Location = new System.Drawing.Point(401, 28);
         this.bPaste.Name = "bPaste";
         this.bPaste.Size = new System.Drawing.Size(20, 14);
         this.bPaste.TabIndex = 1;
         this.bPaste.Text = "...";
         this.bPaste.Click += new System.EventHandler(this.bPaste_Click);
         this.bPaste.MouseHover += new System.EventHandler(this.bPaste_MouseHover);
         // 
         // info
         // 
         this.info.AutoSize = true;
         this.info.Location = new System.Drawing.Point(225, 145);
         this.info.Name = "info";
         this.info.Size = new System.Drawing.Size(0, 13);
         this.info.TabIndex = 10;
         // 
         // not
         // 
         this.not.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
         this.not.MouseMove += new System.Windows.Forms.MouseEventHandler(this.not_MouseMove);
         this.not.MouseUp += new System.Windows.Forms.MouseEventHandler(this.not_MouseUp);
         // 
         // close
         // 
         this.close.AutoSize = true;
         this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.close.ForeColor = System.Drawing.Color.Brown;
         this.close.Location = new System.Drawing.Point(12, 196);
         this.close.Name = "close";
         this.close.Size = new System.Drawing.Size(210, 17);
         this.close.TabIndex = 11;
         this.close.Text = "ShutDown PC on download completed.";
         this.close.UseVisualStyleBackColor = false;
         // 
         // vit
         // 
         this.vit.ForeColor = System.Drawing.Color.Brown;
         this.vit.Location = new System.Drawing.Point(324, 198);
         this.vit.Name = "vit";
         this.vit.Size = new System.Drawing.Size(100, 13);
         this.vit.TabIndex = 12;
         this.vit.Text = "0 KB/sec";
         this.vit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.vit.MouseHover += new System.EventHandler(this.vit_MouseHover);
         // 
         // tip
         // 
         this.tip.IsBalloon = true;
         this.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
         this.tip.ToolTipTitle = "Help:";
         // 
         // frm1
         // 
         this.ClientSize = new System.Drawing.Size(436, 225);
         this.Controls.Add(this.vit);
         this.Controls.Add(this.close);
         this.Controls.Add(this.info);
         this.Controls.Add(this.bPaste);
         this.Controls.Add(this.bBrowse);
         this.Controls.Add(this.lab);
         this.Controls.Add(this.tSource);
         this.Controls.Add(this.l2);
         this.Controls.Add(this.l1);
         this.Controls.Add(this.bCancel);
         this.Controls.Add(this.bStart);
         this.Controls.Add(this.tTarget);
         this.Controls.Add(this.pb);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "frm1";
         this.Text = " miniDownloader 1.4 - costelsoft.ro";
         this.Load += new System.EventHandler(this.frm1_Load);
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm1_FormClosing);
         this.Resize += new System.EventHandler(this.frm1_Resize);
         this.MouseHover += new System.EventHandler(this.frm1_MouseHover);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      private System.Windows.Forms.ProgressBar pb;
      private System.Windows.Forms.Button bStart;
      private System.Windows.Forms.Button bCancel;
      private System.Windows.Forms.TextBox tSource;
      private System.Windows.Forms.TextBox tTarget;
      private System.Windows.Forms.Label l1;
      private System.Windows.Forms.Label l2;
      private System.Windows.Forms.FolderBrowserDialog fol;
      private System.Windows.Forms.Timer tim;
      private System.ComponentModel.IContainer components;
      private System.Windows.Forms.Label lab;
      private System.Windows.Forms.Button bBrowse;
      private System.Windows.Forms.Button bPaste;
      private System.Windows.Forms.Label info;
      private System.Windows.Forms.NotifyIcon not;
      private System.Windows.Forms.CheckBox close;
      private System.Windows.Forms.Label vit;
      private System.Windows.Forms.ToolTip tip;
   }
}

