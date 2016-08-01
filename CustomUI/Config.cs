using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUI
{
  public partial class Config : Form
  {
    public bool isGoogle = true;
    public Config()
    {
      InitializeComponent();
      initPage();
    }
    private void initPage()
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var path = currentDirectory + "\\Config\\auth.json";


      StreamReader sr = new StreamReader(path);
      string line = "";
      string[] split;
      StringBuilder sb = new StringBuilder();
      line = sr.ReadLine();
      while ((line = sr.ReadLine()) != null)
      {
        if (line.Contains("AuthType"))
        {
          split = line.Split(':');
          if (split[1] == " \"google\",")
          {
            isGoogle = true;
            googleRadiobutton.Checked = true;
          }
          else
          {
            isGoogle = false;
            ptcRadiobutton.Checked = true;
          }
        }
        if (isGoogle)
        {
          if (line.Contains("GoogleUsername"))
          {
            split = line.Split(':');
            sb.Append(split[1]);
            sb.Remove(0, 2);
            sb.Remove(sb.ToString().Length - 2, 2);
            usernameBox.Text = sb.ToString();
            sb.Clear();
          }
          if (line.Contains("GooglePassword"))
          {
            split = line.Split(':');
            sb.Append(split[1]);
            sb.Remove(0, 2);
            sb.Remove(sb.ToString().Length - 2, 2);
            passwordBox.Text = sb.ToString();
            sb.Clear();
          }
        }
        else
        {
          if (line.Contains("PtcUsername"))
          {
            split = line.Split(':');
            sb.Append(split[1]);
            sb.Remove(0, 2);
            sb.Remove(sb.ToString().Length - 2, 2);
            usernameBox.Text = sb.ToString();
            sb.Clear();
          }
          if (line.Contains("PtcPassword"))
          {
            split = line.Split(':');
            sb.Append(split[1]);
            sb.Remove(0, 2);
            sb.Remove(sb.ToString().Length - 2, 2);
            passwordBox.Text = sb.ToString();
            sb.Clear();
          }
        }
      }
      sr.Close();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      saveToBotConfig();
      saveToSnipeXml();
      this.Close();
    }

    private void saveToBotConfig()
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var path = currentDirectory + "\\Config\\auth.json";


      StreamWriter authJson = new StreamWriter(path);
      authJson.WriteLine("{");
      if (isGoogle)
      {
        authJson.WriteLine("\"AuthType\": \"Google\",");
      }
      else
      {
        authJson.WriteLine("\"AuthType\": \"Ptc\",");
      }
      authJson.WriteLine("\"GoogleRefreshToken\": null,");
      if (isGoogle)
      {
        authJson.WriteLine("\"PtcUsername\": null,");
        authJson.WriteLine("\"PtcPassword\": null,");
        authJson.WriteLine("\"GoogleUsername\": \"" + usernameBox.Text + "\",");
        authJson.WriteLine("\"GooglePassword\": \"" + passwordBox.Text + "\",");
      }
      else
      {
        authJson.WriteLine("\"PtcUsername\": \"" + usernameBox.Text + "\",");
        authJson.WriteLine("\"PtcPassword\": \"" + passwordBox.Text + "\",");
        authJson.WriteLine("\"GoogleUsername\": null,");
        authJson.WriteLine("\"GooglePassword\": null,");
      }
      authJson.WriteLine("}");
      authJson.Close();
    }

    private void saveToSnipeXml()
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var path = currentDirectory + "\\user.xml";
      var tmpPath = currentDirectory + "\\tmpuser.xml";

      StreamReader sr = new StreamReader(path);
      StreamWriter sw = new StreamWriter(tmpPath);
      string line = "";

      while ((line = sr.ReadLine()) != null)
      {
        if (isGoogle)
        {
          if (line.Contains("AuthType"))
          {
            sw.WriteLine("<AuthType>Google</AuthType>");
          }
          else if (line.Contains("GoogleUsername"))
          {
            sw.WriteLine("<GoogleUsername>" + usernameBox.Text + "</GoogleUsername>");
          }
          else if (line.Contains("GooglePassword"))
          {
            sw.WriteLine("<GooglePassword>" + passwordBox.Text + "</GooglePassword>");
          }
          else
          {
            sw.WriteLine(line);
          }
        }
        else
        {
          if (line.Contains("AuthType"))
          {
            sw.WriteLine("<AuthType>Ptc</AuthType>");
          }
          else if (line.Contains("PtcUsername"))
          {
            sw.WriteLine("<PtcUsername>" + usernameBox.Text + "</PtcUsername>");
          }
          else if (line.Contains("PtcPassword"))
          {
            sw.WriteLine("<PtcPassword>" + passwordBox.Text + "</PtcPassword>");
          }
          else
          {
            sw.WriteLine(line);
          }
        }
      }
      sw.Close();
      sr.Close();
      System.IO.File.Delete(path);
      System.IO.File.Copy(tmpPath, path);
      System.IO.File.Delete(tmpPath);
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cancelButton_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }

    private void googleRadiobutton_CheckedChanged(object sender, EventArgs e)
    {
      isGoogle = true;
    }

    private void ptcRadiobutton_CheckedChanged(object sender, EventArgs e)
    {
      isGoogle = false;
    }
  }
}
