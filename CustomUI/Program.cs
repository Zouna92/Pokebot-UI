using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUI
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      MainWindow mWindow = new MainWindow();
      mWindow.Show();
      Application.EnableVisualStyles();
      //Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(mWindow);
    }
  }
}
