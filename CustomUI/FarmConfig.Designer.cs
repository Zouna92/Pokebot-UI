namespace CustomUI
{
  partial class FarmConfig
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.saveButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.switchCheckbox = new System.Windows.Forms.CheckBox();
      this.minuteTextbox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.repeatFarmingCheckbox = new System.Windows.Forms.CheckBox();
      this.noSnipingRadioButton = new System.Windows.Forms.RadioButton();
      this.nestSnipingRadioButton = new System.Windows.Forms.RadioButton();
      this.autoSnipingRadioButton = new System.Windows.Forms.RadioButton();
      this.SuspendLayout();
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(12, 190);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(122, 59);
      this.saveButton.TabIndex = 0;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(150, 190);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(122, 59);
      this.cancelButton.TabIndex = 1;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // switchCheckbox
      // 
      this.switchCheckbox.AutoSize = true;
      this.switchCheckbox.Location = new System.Drawing.Point(12, 65);
      this.switchCheckbox.Name = "switchCheckbox";
      this.switchCheckbox.Size = new System.Drawing.Size(140, 17);
      this.switchCheckbox.TabIndex = 5;
      this.switchCheckbox.Text = "Switch mode after farm?";
      this.switchCheckbox.UseVisualStyleBackColor = true;
      this.switchCheckbox.CheckedChanged += new System.EventHandler(this.switchCheckbox_CheckedChanged);
      // 
      // minuteTextbox
      // 
      this.minuteTextbox.Location = new System.Drawing.Point(25, 33);
      this.minuteTextbox.Name = "minuteTextbox";
      this.minuteTextbox.Size = new System.Drawing.Size(66, 20);
      this.minuteTextbox.TabIndex = 6;
      this.minuteTextbox.Text = "5";
      this.minuteTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(230, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Farm duration ( recommended atleast 5-10 min )";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(97, 37);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Minutes";
      // 
      // repeatFarmingCheckbox
      // 
      this.repeatFarmingCheckbox.AutoSize = true;
      this.repeatFarmingCheckbox.Enabled = false;
      this.repeatFarmingCheckbox.Location = new System.Drawing.Point(26, 88);
      this.repeatFarmingCheckbox.Name = "repeatFarmingCheckbox";
      this.repeatFarmingCheckbox.Size = new System.Drawing.Size(107, 17);
      this.repeatFarmingCheckbox.TabIndex = 9;
      this.repeatFarmingCheckbox.Text = "Repeat Farming?";
      this.repeatFarmingCheckbox.UseVisualStyleBackColor = true;
      this.repeatFarmingCheckbox.CheckedChanged += new System.EventHandler(this.repeatFarmingCheckbox_CheckedChanged);
      // 
      // noSnipingRadioButton
      // 
      this.noSnipingRadioButton.AutoSize = true;
      this.noSnipingRadioButton.Enabled = false;
      this.noSnipingRadioButton.Location = new System.Drawing.Point(26, 111);
      this.noSnipingRadioButton.Name = "noSnipingRadioButton";
      this.noSnipingRadioButton.Size = new System.Drawing.Size(98, 17);
      this.noSnipingRadioButton.TabIndex = 11;
      this.noSnipingRadioButton.TabStop = true;
      this.noSnipingRadioButton.Text = "EXP-NoSniping";
      this.noSnipingRadioButton.UseVisualStyleBackColor = true;
      this.noSnipingRadioButton.CheckedChanged += new System.EventHandler(this.noSnipingRadioButton_CheckedChanged);
      // 
      // nestSnipingRadioButton
      // 
      this.nestSnipingRadioButton.AutoSize = true;
      this.nestSnipingRadioButton.Enabled = false;
      this.nestSnipingRadioButton.Location = new System.Drawing.Point(26, 134);
      this.nestSnipingRadioButton.Name = "nestSnipingRadioButton";
      this.nestSnipingRadioButton.Size = new System.Drawing.Size(106, 17);
      this.nestSnipingRadioButton.TabIndex = 12;
      this.nestSnipingRadioButton.TabStop = true;
      this.nestSnipingRadioButton.Text = "EXP-NestSniping";
      this.nestSnipingRadioButton.UseVisualStyleBackColor = true;
      this.nestSnipingRadioButton.CheckedChanged += new System.EventHandler(this.nestSnipingRadioButton_CheckedChanged);
      // 
      // autoSnipingRadioButton
      // 
      this.autoSnipingRadioButton.AutoSize = true;
      this.autoSnipingRadioButton.Enabled = false;
      this.autoSnipingRadioButton.Location = new System.Drawing.Point(26, 157);
      this.autoSnipingRadioButton.Name = "autoSnipingRadioButton";
      this.autoSnipingRadioButton.Size = new System.Drawing.Size(85, 17);
      this.autoSnipingRadioButton.TabIndex = 13;
      this.autoSnipingRadioButton.TabStop = true;
      this.autoSnipingRadioButton.Text = "Auto Sniping";
      this.autoSnipingRadioButton.UseVisualStyleBackColor = true;
      this.autoSnipingRadioButton.CheckedChanged += new System.EventHandler(this.autoSnipingRadioButton_CheckedChanged);
      // 
      // FarmConfig
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.autoSnipingRadioButton);
      this.Controls.Add(this.nestSnipingRadioButton);
      this.Controls.Add(this.noSnipingRadioButton);
      this.Controls.Add(this.repeatFarmingCheckbox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.minuteTextbox);
      this.Controls.Add(this.switchCheckbox);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.saveButton);
      this.Name = "FarmConfig";
      this.Text = "FarmConfig";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.CheckBox switchCheckbox;
    private System.Windows.Forms.TextBox minuteTextbox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox repeatFarmingCheckbox;
    private System.Windows.Forms.RadioButton noSnipingRadioButton;
    private System.Windows.Forms.RadioButton nestSnipingRadioButton;
    private System.Windows.Forms.RadioButton autoSnipingRadioButton;
  }
}