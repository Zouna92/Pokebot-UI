namespace CustomUI
{
  partial class Config
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
      this.label2 = new System.Windows.Forms.Label();
      this.usernameBox = new System.Windows.Forms.TextBox();
      this.passwordBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.saveButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.googleRadiobutton = new System.Windows.Forms.RadioButton();
      this.ptcRadiobutton = new System.Windows.Forms.RadioButton();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Username";
      // 
      // usernameBox
      // 
      this.usernameBox.Location = new System.Drawing.Point(98, 43);
      this.usernameBox.Name = "usernameBox";
      this.usernameBox.Size = new System.Drawing.Size(216, 20);
      this.usernameBox.TabIndex = 2;
      // 
      // passwordBox
      // 
      this.passwordBox.Location = new System.Drawing.Point(98, 69);
      this.passwordBox.Name = "passwordBox";
      this.passwordBox.Size = new System.Drawing.Size(216, 20);
      this.passwordBox.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Password";
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(33, 102);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(125, 49);
      this.saveButton.TabIndex = 16;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(189, 102);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(125, 49);
      this.cancelButton.TabIndex = 20;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
      // 
      // googleRadiobutton
      // 
      this.googleRadiobutton.AutoSize = true;
      this.googleRadiobutton.Location = new System.Drawing.Point(15, 13);
      this.googleRadiobutton.Name = "googleRadiobutton";
      this.googleRadiobutton.Size = new System.Drawing.Size(59, 17);
      this.googleRadiobutton.TabIndex = 21;
      this.googleRadiobutton.TabStop = true;
      this.googleRadiobutton.Text = "Google";
      this.googleRadiobutton.UseVisualStyleBackColor = true;
      this.googleRadiobutton.CheckedChanged += new System.EventHandler(this.googleRadiobutton_CheckedChanged);
      // 
      // ptcRadiobutton
      // 
      this.ptcRadiobutton.AutoSize = true;
      this.ptcRadiobutton.Location = new System.Drawing.Point(99, 12);
      this.ptcRadiobutton.Name = "ptcRadiobutton";
      this.ptcRadiobutton.Size = new System.Drawing.Size(46, 17);
      this.ptcRadiobutton.TabIndex = 22;
      this.ptcRadiobutton.TabStop = true;
      this.ptcRadiobutton.Text = "PTC";
      this.ptcRadiobutton.UseVisualStyleBackColor = true;
      this.ptcRadiobutton.CheckedChanged += new System.EventHandler(this.ptcRadiobutton_CheckedChanged);
      // 
      // Config
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(349, 163);
      this.Controls.Add(this.ptcRadiobutton);
      this.Controls.Add(this.googleRadiobutton);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.passwordBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.usernameBox);
      this.Controls.Add(this.label2);
      this.Name = "Config";
      this.Text = "Login information";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox usernameBox;
    private System.Windows.Forms.TextBox passwordBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.RadioButton googleRadiobutton;
    private System.Windows.Forms.RadioButton ptcRadiobutton;
  }
}