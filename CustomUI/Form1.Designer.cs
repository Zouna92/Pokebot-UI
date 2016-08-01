namespace CustomUI
{
  partial class MainWindow
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.creatorTag = new System.Windows.Forms.Label();
      this.expButton = new System.Windows.Forms.Button();
      this.snipeButton = new System.Windows.Forms.Button();
      this.label11 = new System.Windows.Forms.Label();
      this.snipeLocationTextbox = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.snipeNameTextbox = new System.Windows.Forms.TextBox();
      this.nestSnipingButton = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.loginButton = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.autoSnipeButton = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.farmConfigButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // creatorTag
      // 
      this.creatorTag.AllowDrop = true;
      this.creatorTag.AutoEllipsis = true;
      this.creatorTag.Location = new System.Drawing.Point(1119, 355);
      this.creatorTag.Name = "creatorTag";
      this.creatorTag.Size = new System.Drawing.Size(100, 23);
      this.creatorTag.TabIndex = 0;
      this.creatorTag.Text = "made by Zouna";
      // 
      // expButton
      // 
      this.expButton.Location = new System.Drawing.Point(15, 107);
      this.expButton.Name = "expButton";
      this.expButton.Size = new System.Drawing.Size(180, 89);
      this.expButton.TabIndex = 1;
      this.expButton.Text = "Exp - No Sniping";
      this.expButton.UseVisualStyleBackColor = true;
      this.expButton.Click += new System.EventHandler(this.expButton_Click);
      // 
      // snipeButton
      // 
      this.snipeButton.Location = new System.Drawing.Point(12, 202);
      this.snipeButton.Name = "snipeButton";
      this.snipeButton.Size = new System.Drawing.Size(366, 89);
      this.snipeButton.TabIndex = 3;
      this.snipeButton.Text = "Single Snipe";
      this.snipeButton.UseVisualStyleBackColor = true;
      this.snipeButton.Click += new System.EventHandler(this.snipeButton_Click);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(12, 326);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(48, 13);
      this.label11.TabIndex = 25;
      this.label11.Text = "Location";
      // 
      // snipeLocationTextbox
      // 
      this.snipeLocationTextbox.Location = new System.Drawing.Point(90, 323);
      this.snipeLocationTextbox.Name = "snipeLocationTextbox";
      this.snipeLocationTextbox.Size = new System.Drawing.Size(288, 20);
      this.snipeLocationTextbox.TabIndex = 24;
      this.snipeLocationTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(12, 300);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(35, 13);
      this.label12.TabIndex = 23;
      this.label12.Text = "Name";
      // 
      // snipeNameTextbox
      // 
      this.snipeNameTextbox.Location = new System.Drawing.Point(90, 297);
      this.snipeNameTextbox.Name = "snipeNameTextbox";
      this.snipeNameTextbox.Size = new System.Drawing.Size(288, 20);
      this.snipeNameTextbox.TabIndex = 22;
      this.snipeNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // nestSnipingButton
      // 
      this.nestSnipingButton.Location = new System.Drawing.Point(198, 107);
      this.nestSnipingButton.Name = "nestSnipingButton";
      this.nestSnipingButton.Size = new System.Drawing.Size(128, 89);
      this.nestSnipingButton.TabIndex = 26;
      this.nestSnipingButton.Text = "Exp - Nest Sniping";
      this.nestSnipingButton.UseVisualStyleBackColor = true;
      this.nestSnipingButton.Click += new System.EventHandler(this.nestSnipingButton_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(322, 107);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(56, 89);
      this.button2.TabIndex = 27;
      this.button2.Text = "Nest Config";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.nestConfig_Click);
      // 
      // loginButton
      // 
      this.loginButton.Location = new System.Drawing.Point(15, 12);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(180, 89);
      this.loginButton.TabIndex = 28;
      this.loginButton.Text = "Login";
      this.loginButton.UseVisualStyleBackColor = true;
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(403, 21);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(783, 331);
      this.richTextBox1.TabIndex = 30;
      this.richTextBox1.Text = "";
      // 
      // autoSnipeButton
      // 
      this.autoSnipeButton.Location = new System.Drawing.Point(322, 202);
      this.autoSnipeButton.Name = "autoSnipeButton";
      this.autoSnipeButton.Size = new System.Drawing.Size(56, 89);
      this.autoSnipeButton.TabIndex = 31;
      this.autoSnipeButton.Text = "Auto Snipe";
      this.autoSnipeButton.UseVisualStyleBackColor = true;
      this.autoSnipeButton.Click += new System.EventHandler(this.autoSnipeButton_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(198, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(128, 89);
      this.button1.TabIndex = 32;
      this.button1.Text = "Farm Pokeballs";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.farmPokeballs_Click);
      // 
      // farmConfigButton
      // 
      this.farmConfigButton.Location = new System.Drawing.Point(322, 12);
      this.farmConfigButton.Name = "farmConfigButton";
      this.farmConfigButton.Size = new System.Drawing.Size(56, 89);
      this.farmConfigButton.TabIndex = 33;
      this.farmConfigButton.Text = "Farm Config broken and disabled";
      this.farmConfigButton.UseVisualStyleBackColor = true;
      this.farmConfigButton.Click += new System.EventHandler(this.farmConfigButton_Click);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1211, 374);
      this.Controls.Add(this.farmConfigButton);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.autoSnipeButton);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.loginButton);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.nestSnipingButton);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.snipeLocationTextbox);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.snipeNameTextbox);
      this.Controls.Add(this.snipeButton);
      this.Controls.Add(this.expButton);
      this.Controls.Add(this.creatorTag);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainWindow";
      this.Text = "Pokemon Go Bot UI";
      this.Load += new System.EventHandler(this.MainWindow_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label creatorTag;
    private System.Windows.Forms.Button expButton;
    private System.Windows.Forms.Button snipeButton;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox snipeLocationTextbox;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox snipeNameTextbox;
    private System.Windows.Forms.Button nestSnipingButton;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button loginButton;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button autoSnipeButton;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button farmConfigButton;
  }
}

