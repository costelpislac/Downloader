using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;

namespace Downloader
{

   public partial class frm1 : Form
   {

      public frm1() { InitializeComponent(); }

      //
      WebClient wc; string s; long b1 = 0, b2; double d;

      //http://visualstudiogallery.msdn.microsoft.com/6eb51f05-ef01-4513-ac83-4c5f50c95fb5/file/67453/38/PHP.VS.1.8.4704.vsix
      void frm1_Load(object o, EventArgs e)
      {
         if(Clipboard.ContainsText() && Clipboard.GetText().Length < 2000)
         { s = Clipboard.GetText(); if(s.Contains("tp") && s.Contains(".") && s.Contains("/")) tSource.Text = s; }
         //destination
         tTarget.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
         //memoria
         Process.GetCurrentProcess().MaxWorkingSet = Process.GetCurrentProcess().MaxWorkingSet;
      }

      //
      void tSource_TextChanged(object o, EventArgs e)
      {
         if(tSource.Text.Length < 2000)
         { if(tSource.Text.Contains("tp") && tSource.Text.Contains(".") && tSource.Text.Contains("/") && tTarget.Text.Length > 3) bStart.Enabled = true; else bStart.Enabled = false; }
         else { MessageBox.Show(this, "Path too long ! (max 2000 characters)", Text, MessageBoxButtons.OK, MessageBoxIcon.Error); tSource.Text = tSource.Text.Substring(0, 63); tSource.Focus(); }
      }

      //
      void tTarget_TextChanged(object o, EventArgs e) { if(tSource.Text.Length > 5) bStart.Enabled = true; else bStart.Enabled = false; }

      //
      void bStart_Click(object o, EventArgs e)
      {
         wc = new WebClient(); lab.Visible = true; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
         wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
         tSource.ReadOnly = true; bPaste.Enabled = false; bBrowse.Enabled = false;
         try
         {
            wc.DownloadFileAsync(new Uri(tSource.Text), tTarget.Text + "\\" + Path.GetFileName(tSource.Text).Replace("\\", "").Replace("/", "").Replace(":", "").Replace("*", "").
               Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", ""));
            bStart.Enabled = false; bCancel.Enabled = true;
         }
         catch(Exception ex) { MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error); wc.Dispose(); }
         //memoria
         Process.GetCurrentProcess().MaxWorkingSet = Process.GetCurrentProcess().MaxWorkingSet; tim.Start();
      }

      //
      void wc_DownloadProgressChanged(object o, DownloadProgressChangedEventArgs e)
      {
         pb.Value = e.ProgressPercentage;
         info.Text = (e.TotalBytesToReceive / 1024).ToString("N0") + "\r\n" + (e.BytesReceived / 1024).ToString("N0") + "\r\n" + e.ProgressPercentage.ToString() + " %";
      }

      //
      void bCancel_Click(object o, EventArgs e)
      {
         tSource.ReadOnly = false; bPaste.Enabled = true; bBrowse.Enabled = true; wc.CancelAsync(); wc.Dispose(); bCancel.Enabled = false;
         //memoria
         Process.GetCurrentProcess().MaxWorkingSet = Process.GetCurrentProcess().MaxWorkingSet;
      }

      //
      void wc_DownloadFileCompleted(object o, AsyncCompletedEventArgs c)
      {
         bCancel.Enabled = false; tim.Stop();
         //
         if(pb.Value < 100) //canceled
         {
            try { File.Delete(tTarget.Text + "\\" + Path.GetFileName(tSource.Text)); }
            catch(Exception ex) { MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //
            if(MessageBox.Show(this, "Download canceled. Exit ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            { not.Visible = false; Application.Exit(); }
            else { pb.Value = 0; lab.Visible = false; info.Text = ""; bStart.Enabled = true; }
         }
         else //completed
         {
            if(close.Checked) { Process.Start("ShutDown", "/s"); }
            else
            {
               if(MessageBox.Show(this, "Download completed. Exit ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
               { not.Visible = false; Application.Exit(); }
               else
               { pb.Value = 0; lab.Visible = false; info.Text = ""; tSource.ReadOnly = false; bPaste.Enabled = true; bBrowse.Enabled = true; bStart.Enabled = true; }
            }
         }
      }

      //
      void bPaste_Click(object o, EventArgs e) { tSource.Text = Clipboard.GetText(); }

      //
      void bBrowse_Click(object o, EventArgs e)
      {
         if(fol.ShowDialog(this) == DialogResult.OK)
         {
            if(File.Exists(fol.SelectedPath + "\\" + Path.GetFileName(tSource.Text)))
               MessageBox.Show(this, "'" + fol.SelectedPath + "\\" + Path.GetFileName(tSource.Text) + "' already exists !", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            tTarget.Text = fol.SelectedPath;
         }
      }

      //
      void frm1_FormClosing(object o, FormClosingEventArgs e)
      { if(bCancel.Enabled == true) { MessageBox.Show(this, "Download in progress.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information); e.Cancel = true; } }

      //
      void frm1_Resize(object o, EventArgs e)
      {
         if(WindowState == FormWindowState.Minimized)
         { not.Icon = Icon; not.BalloonTipText = "You have successfully minimized your miniDownloader."; not.Visible = true; not.ShowBalloonTip(300); Hide(); }
         else if(WindowState == FormWindowState.Normal) not.Visible = false;
      }

      //
      void not_MouseUp(object o, MouseEventArgs e) { not.Visible = false; Show(); WindowState = FormWindowState.Normal; }

      //
      void tim_Tick(object o, EventArgs e)
      {
         if(info.Text.Contains("\r\n"))
         {
            b2 = Convert.ToInt64(info.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None)[1].Replace(".", "").Replace(",", ""));
            d = b2 - b1; vit.Text = Math.Round(d, 2).ToString() + " KB/sec"; b1 = b2;
         }
      }

      //
      void bPaste_MouseHover(object o, EventArgs e) { tip.Show("1) Paste URL", this, 404, -10, 999); }
      void bBrowse_MouseHover(object o, EventArgs e) { tip.Show("2) Browse", this, 404, 36, 999); }
      void vit_MouseHover(object o, EventArgs e) { tip.Show("Download speed", this, 370, 155, 999); }

      //
      void frm1_MouseHover(object o, EventArgs e) { tip.RemoveAll(); }

      //
      void not_MouseMove(object o, MouseEventArgs e) { not.Text = Path.GetFileName(tSource.Text) + " - " + pb.Value.ToString() + "% completed."; }




   }
}