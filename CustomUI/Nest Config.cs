using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUI
{
  public partial class Nest_Config : Form
  {
    MainWindow mainWindow;
    Process processTemp = new Process();
    public Nest_Config(MainWindow form)
    {
      mainWindow = form;
      InitializeComponent();
      initTextboxes();
    }

    private void initTextboxes()
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var path = currentDirectory + "\\customConfigs\\nestConfig.json";
      StreamReader json = new StreamReader(path);
      string line;
      while ((line = json.ReadLine()) != null)
      {
        if (line.Contains("PokemonToSnipe"))
        {
          while (!line.Contains("],"))
          {
            line = json.ReadLine();
            if (line.Contains("Latitude"))
            {
              var split = line.Split(':');
              latLongTextbox.AppendText(split[1]);
            }
            if (line.Contains("Longitude"))
            {
              var split = line.Split(':');
              latLongTextbox.AppendText(split[1] + "\r\n");
            }
          }
          line = json.ReadLine();
          line = json.ReadLine();
          while (!line.Contains("]"))
          {
            pokemonTextbox.AppendText(line + "\r\n");
            line = json.ReadLine();
          }
        }
      }
      json.Close();
      Process processTemp = new Process();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var oldPath = currentDirectory + "\\customConfigs\\nestConfig.json";
      var tmpPath = currentDirectory + "\\customConfigs\\tmpNestConfig.json";
      var newPath = currentDirectory + "\\Config\\Config.json";

      StreamReader oldNestConfigJson = new StreamReader(oldPath);
      StreamWriter tmpNestConfigJson = new StreamWriter(tmpPath);
      string rLine;
      while ((rLine = oldNestConfigJson.ReadLine()) != null)
      {
        if (!rLine.Contains("PokemonToSnipe"))
        {
          tmpNestConfigJson.WriteLine(rLine);
        }
        else
        {
          while ((rLine = oldNestConfigJson.ReadLine()) != null)
          {
            rLine = oldNestConfigJson.ReadLine();
          }
        }
      }
      tmpNestConfigJson.WriteLine("\"PokemonToSnipe\": {");
      tmpNestConfigJson.WriteLine("\"Locations\": [");
      string[] lines = latLongTextbox.Lines;
      string[] split;
      foreach (string line in lines)
      {
        split = line.Split(',');
        if (split[0].Length > 1)
        {
          tmpNestConfigJson.WriteLine("{");
          tmpNestConfigJson.WriteLine("\"Latitude\":" + split[0]+",");
          tmpNestConfigJson.WriteLine("\"Longitude\":" + split[1]);
          tmpNestConfigJson.WriteLine("},");
        }
      }
      tmpNestConfigJson.WriteLine("],");
      tmpNestConfigJson.WriteLine("\"Pokemon\": [");
      lines = pokemonTextbox.Lines;
      foreach (string line in lines)
      {
        tmpNestConfigJson.WriteLine(line);
      }
      tmpNestConfigJson.WriteLine("]");
      tmpNestConfigJson.WriteLine("}");
      tmpNestConfigJson.WriteLine("}");
      tmpNestConfigJson.Close();
      oldNestConfigJson.Close();
      System.IO.File.Delete(oldPath);
      System.IO.File.Copy(tmpPath, oldPath);
      System.IO.File.Delete(tmpPath);
      System.IO.File.Delete(newPath);
      System.IO.File.Copy(oldPath, newPath);
      this.Close();
      if (mainWindow.mainThread != null)
      {
        mainWindow.mainThread = null;
      }
      mainWindow.mainThread = new System.Threading.Thread(mainWindow.restartProcess);
      mainWindow.mainThread.Start();
    }
  }
}
