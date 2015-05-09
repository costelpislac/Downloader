using System;
using System.Windows.Forms;

namespace Downloader
{
   static class prog
   {
      [STAThread]
      static void Main() { Application.EnableVisualStyles(); Application.Run(new frm1()); }
   }
}