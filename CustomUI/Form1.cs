using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUI
{
  public partial class MainWindow : Form
  {
    public bool snipe = false;
    public bool farm = false;
    public Thread mainThread = null;
    Process cmdProcess = null;
    public MainWindow()
    {
      InitializeComponent();
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {

    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);

      if (e.CloseReason == CloseReason.WindowsShutDown)
        return;

      // Confirm user wants to close
      switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
      {
        case DialogResult.No:
          e.Cancel = true;
          break;
        case DialogResult.Yes:
          if (cmdProcess != null)
          {
            mainThread = null;
            cmdProcess.Kill();
          }
          break;
        default:
          break;
      }
    }

    private void nestConfig_Click(object sender, EventArgs e)
    {
      Nest_Config nWindow = new Nest_Config(this);
      nWindow.Show();
    }

    private void nestSnipingButton_Click(object sender, EventArgs e)
    {
      if (mainThread != null)
      {
        if (!mainThread.IsAlive)
        {
          cmdProcess = null;
        }
        else
        {
          mainThread.Abort();
        }
      }
      snipe = true;
      farm = false;
      mainThread = new Thread(restartProcess);
      mainThread.Start();
    }

    private void expButton_Click(object sender, EventArgs e)
    {
      if (mainThread != null)
      {
        if (!mainThread.IsAlive)
        {
          cmdProcess = null;
        }
        else
        {
          mainThread.Abort();
        }
      }
      snipe = false;
      farm = false;
      mainThread = new Thread(restartProcess);
      mainThread.Start();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
      Config cWindow = new Config();
      cWindow.Show();
    }

    public void restartProcess()
    {
      if (cmdProcess != null)
      {
        cmdProcess.Kill();
      }

      var currentDirectory = Directory.GetCurrentDirectory();
      var sourceFile = "";
      if (!farm)
      {
        if (snipe)
        {
          sourceFile = currentDirectory + "\\customConfigs\\nestConfig.json";
        }
        else
        {
          sourceFile = currentDirectory + "\\customConfigs\\normalConfig.json";
        }
      }
      else
      {
        sourceFile = currentDirectory + "\\customConfigs\\pokeballFarmConfig.json";
      }
      var destFile = currentDirectory + "\\Config\\Config.json";
      System.IO.File.Delete(destFile);
      System.IO.File.Copy(sourceFile, destFile, true);

      using (cmdProcess = new Process())
      {
        cmdProcess.StartInfo.FileName = currentDirectory + "\\PokeMobBot.exe";
        cmdProcess.StartInfo.CreateNoWindow = true;
        cmdProcess.StartInfo.UseShellExecute = false;
        cmdProcess.StartInfo.RedirectStandardOutput = true;

        // Set event handler
        cmdProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);

        // Start the process.
        cmdProcess.Start();

        // Start the asynchronous read
        cmdProcess.BeginOutputReadLine();

        cmdProcess.WaitForExit();
      }
    }

    private void snipeButton_Click(object sender, EventArgs e)
    {
      if (!mainThread.IsAlive)
      {
        cmdProcess = null;
      }
      snipe = false;
      mainThread = new Thread(snipePokemon);
      mainThread.Start();
    }

    public void snipePokemon()
    {
      if (cmdProcess != null)
      {
        cmdProcess.Kill();
      }

      var currentDirectory = Directory.GetCurrentDirectory();

      using (cmdProcess = new Process())
      {
        cmdProcess.StartInfo.FileName = currentDirectory + "\\PokeSniper2\\PokeSniper2.exe";
        cmdProcess.StartInfo.CreateNoWindow = true;
        string[] split;
        try
        {
          split = snipeLocationTextbox.Text.Split(',');
          try
          {
            string latitude = split[0];
            string longitude = split[1];

            cmdProcess.StartInfo.Arguments = snipeNameTextbox.Text + " " + latitude + " " + longitude; //Pokemon Latitude Longitude
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.RedirectStandardOutput = true;

            // Set event handler
            cmdProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);

            // Start the process.
            cmdProcess.Start();

            // Start the asynchronous read
            cmdProcess.BeginOutputReadLine();

            cmdProcess.WaitForExit();
          }
          catch (Exception e)
          {
            richTextBox1.Text = "error: latitude,longitude were not in the correct format correct example(34.3434,23.222) restart the client";
          };
        }
        catch (Exception e)
        {
          richTextBox1.Text = "error: not a valid name, restart the client";
        };
      }
    }

    public void autoSnipe()
    {
      if (cmdProcess != null)
      {
        cmdProcess.Kill();
      }

      var currentDirectory = Directory.GetCurrentDirectory();

      using (cmdProcess = new Process())
      {
        cmdProcess.StartInfo.FileName = currentDirectory + "\\PokeSniper2\\PokeSniper2.exe";
        cmdProcess.StartInfo.CreateNoWindow = true;
        cmdProcess.StartInfo.Arguments = "-autosniping";
        cmdProcess.StartInfo.UseShellExecute = false;
        cmdProcess.StartInfo.RedirectStandardOutput = true;

        // Set event handler
        cmdProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);

        // Start the process.
        cmdProcess.Start();

        // Start the asynchronous read
        cmdProcess.BeginOutputReadLine();

        cmdProcess.WaitForExit();
      }
    }

    void SortOutputHandler(object sender, DataReceivedEventArgs e)
    {
      Trace.WriteLine(e.Data);
      this.BeginInvoke(new MethodInvoker(() =>
      {
        richTextBox1.AppendText(Environment.NewLine + e.Data ?? string.Empty);
        richTextBox1.ScrollToCaret();
      }));
    }

    private void autoSnipeButton_Click(object sender, EventArgs e)
    {
      if (mainThread != null)
      {
        if (!mainThread.IsAlive)
        {
          cmdProcess = null;
        }
        else
        {
          mainThread.Abort();
        }
      }
      snipe = false;
      mainThread = new Thread(autoSnipe);
      mainThread.Start();
    }

    private void farmPokeballs_Click(object sender, EventArgs e)
    {
      if (mainThread != null)
      {
        if (!mainThread.IsAlive)
        {
          cmdProcess = null;
        }
        else
        {
          mainThread.Abort();
        }
      }
      farm = true;
      mainThread = new Thread(restartProcess);
      mainThread.Start();
    }

    private void toDo()
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var path = currentDirectory + "\\customConfigs\\farmConfig.txt";
      int timeInMinutes;
      string switchMode;
      bool repeat;

      StreamReader sr = new StreamReader(path);
      string line;
      string[] split;

      line = sr.ReadLine(); //timeInMinutes
      split = line.Split(':');
      timeInMinutes = int.Parse(split[1]);

      line = sr.ReadLine(); //switchMode
      split = line.Split(':');
      switchMode = split[1];

      line = sr.ReadLine(); //repeat
      split = line.Split(':');
      if (split[1] == "true")
      {
        repeat = true;
      }
      else
      {
        repeat = false;
      }
      creatorTag.Text = "Sleeping";
      Thread.Sleep(timeInMinutes * 60 * 1000);
      creatorTag.Text = "Woke up";

      if (switchMode == "0")
      {
      }
      else if (switchMode == "1") //EXP-noSnipe
      {
        if (mainThread != null)
        {
          mainThread = null;
        }
        snipe = false;
        farm = false;
        mainThread = new Thread(restartProcess);
        mainThread.Start();
      }
      else if (switchMode == "2")//EXP-nestSnipe
      {
        if (mainThread != null)
        {
          mainThread = null;
        }
        snipe = true;
        farm = false;
        mainThread = new Thread(restartProcess);
        mainThread.Start();
      }
      else if (switchMode == "3")//Auto Snipe
      {
        if (mainThread != null)
        {
          mainThread = null;
        }
        farm = true;
        mainThread = new Thread(restartProcess);
        mainThread.Start();
      }

      if (repeat)
      {
      }
    }

    private void farmConfigButton_Click(object sender, EventArgs e)
    {
      FarmConfig fWindow = new FarmConfig();
      fWindow.Show();
    }
  }
}

public static class ProcessExtensions
{
  public static bool IsRunning(this Process process)
  {
    if (process == null)
    {
      return false;
    }

    try
    {
      Process.GetProcessById(process.Id);
    }
    catch (ArgumentException)
    {
      return false;
    }
    return true;
  }
}
