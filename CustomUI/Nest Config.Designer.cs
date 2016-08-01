namespace CustomUI
{
  partial class Nest_Config
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
      this.label1 = new System.Windows.Forms.Label();
      this.latLongTextbox = new System.Windows.Forms.TextBox();
      this.cancelButton = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.pokemonTextbox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter \"lat,long\";";
      // 
      // latLongTextbox
      // 
      this.latLongTextbox.Location = new System.Drawing.Point(16, 30);
      this.latLongTextbox.Multiline = true;
      this.latLongTextbox.Name = "latLongTextbox";
      this.latLongTextbox.Size = new System.Drawing.Size(358, 102);
      this.latLongTextbox.TabIndex = 1;
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(205, 302);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(169, 66);
      this.cancelButton.TabIndex = 4;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(16, 302);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(169, 66);
      this.saveButton.TabIndex = 5;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // pokemonTextbox
      // 
      this.pokemonTextbox.Location = new System.Drawing.Point(16, 161);
      this.pokemonTextbox.Multiline = true;
      this.pokemonTextbox.Name = "pokemonTextbox";
      this.pokemonTextbox.Size = new System.Drawing.Size(358, 102);
      this.pokemonTextbox.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 144);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Enter \"Pokemon\"";
      // 
      // Nest_Config
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 380);
      this.Controls.Add(this.pokemonTextbox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.latLongTextbox);
      this.Controls.Add(this.label1);
      this.Name = "Nest_Config";
      this.Text = "Nest_Config";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox latLongTextbox;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.TextBox pokemonTextbox;
    private System.Windows.Forms.Label label2;
  }
}