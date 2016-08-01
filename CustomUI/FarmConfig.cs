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
  public partial class FarmConfig : Form
  {
    int switchMode = 0;
    bool repeat = false;
    public FarmConfig()
    {
      InitializeComponent();
      initPage();
    }

    private void initPage()
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var path = currentDirectory + "\\customConfigs\\farmConfig.txt";

      StreamReader sr = new StreamReader(path);
      string line;
      string[] split;
      line = sr.ReadLine(); //TimeInMinutes
      split = line.Split(':');
      minuteTextbox.Text = split[1];
      line = sr.ReadLine(); //switchMode
      split = line.Split(':');
      if (split[1] == "0")
      {
      }
      else if (split[1] == "1")
      {
        switchCheckbox.Checked = true;
        noSnipingRadioButton.Checked = true;
        switchMode = 1;
      }
      else if (split[1] == "2")
      {
        switchCheckbox.Checked = true;
        nestSnipingRadioButton.Checked = true;
        switchMode = 2;
      }
      else if (split[1] == "3")
      {
        switchCheckbox.Checked = true;
        autoSnipingRadioButton.Checked = true;
        switchMode = 3;
      }

      line = sr.ReadLine(); //repeat
      split = line.Split(':');
      if (split[1] == "true")
      {
        repeatFarmingCheckbox.Checked = true;
      }
      sr.Close();
    }

    private void switchCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      if (!switchCheckbox.Checked)
      {
        switchMode = 0;
      }
      repeatFarmingCheckbox.Enabled = !repeatFarmingCheckbox.Enabled;
      noSnipingRadioButton.Enabled = !noSnipingRadioButton.Enabled;
      nestSnipingRadioButton.Enabled = !nestSnipingRadioButton.Enabled;
      autoSnipingRadioButton.Enabled = !autoSnipingRadioButton.Enabled;
    }

    private void repeatFarmingCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      repeat = !repeat;
    }

    private void noSnipingRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      switchMode = 1;
    }

    private void nestSnipingRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      switchMode = 2;
    }

    private void autoSnipingRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      switchMode = 3;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var path = currentDirectory + "\\customConfigs\\farmConfig.txt";

      System.IO.File.Delete(path);
      StreamWriter sw = new StreamWriter(path);
      sw.WriteLine("TimeInMinutes:" + minuteTextbox.Text);
      sw.WriteLine("switchMode:" + switchMode);
      sw.WriteLine("repeat:" + repeat.ToString());
      sw.Close();
      this.Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
