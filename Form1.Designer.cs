namespace WinForms_240111_pictureBoxGrafika
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.buttonCzysc = new System.Windows.Forms.Button();
      this.buttonOdcinek = new System.Windows.Forms.Button();
      this.buttonProstokat = new System.Windows.Forms.Button();
      this.buttonElipsa = new System.Windows.Forms.Button();
      this.buttonPieciokat = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(234, 109);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
      // 
      // buttonCzysc
      // 
      this.buttonCzysc.Location = new System.Drawing.Point(28, 459);
      this.buttonCzysc.Name = "buttonCzysc";
      this.buttonCzysc.Size = new System.Drawing.Size(75, 23);
      this.buttonCzysc.TabIndex = 1;
      this.buttonCzysc.Text = "czysc";
      this.buttonCzysc.UseVisualStyleBackColor = true;
      this.buttonCzysc.Click += new System.EventHandler(this.buttonCzysc_Click);
      // 
      // buttonOdcinek
      // 
      this.buttonOdcinek.Location = new System.Drawing.Point(145, 459);
      this.buttonOdcinek.Name = "buttonOdcinek";
      this.buttonOdcinek.Size = new System.Drawing.Size(75, 23);
      this.buttonOdcinek.TabIndex = 2;
      this.buttonOdcinek.Text = "odcinek";
      this.buttonOdcinek.UseVisualStyleBackColor = true;
      this.buttonOdcinek.Click += new System.EventHandler(this.buttonOdcinek_Click);
      // 
      // buttonProstokat
      // 
      this.buttonProstokat.Location = new System.Drawing.Point(235, 459);
      this.buttonProstokat.Name = "buttonProstokat";
      this.buttonProstokat.Size = new System.Drawing.Size(75, 23);
      this.buttonProstokat.TabIndex = 3;
      this.buttonProstokat.Text = "prostokąt";
      this.buttonProstokat.UseVisualStyleBackColor = true;
      this.buttonProstokat.Click += new System.EventHandler(this.buttonProstokat_Click);
      // 
      // buttonElipsa
      // 
      this.buttonElipsa.Location = new System.Drawing.Point(330, 459);
      this.buttonElipsa.Name = "buttonElipsa";
      this.buttonElipsa.Size = new System.Drawing.Size(75, 23);
      this.buttonElipsa.TabIndex = 4;
      this.buttonElipsa.Text = "elipsa";
      this.buttonElipsa.UseVisualStyleBackColor = true;
      this.buttonElipsa.Click += new System.EventHandler(this.buttonElipsa_Click);
      // 
      // buttonPieciokat
      // 
      this.buttonPieciokat.Location = new System.Drawing.Point(427, 459);
      this.buttonPieciokat.Name = "buttonPieciokat";
      this.buttonPieciokat.Size = new System.Drawing.Size(75, 23);
      this.buttonPieciokat.TabIndex = 5;
      this.buttonPieciokat.Text = "pięciokąt";
      this.buttonPieciokat.UseVisualStyleBackColor = true;
      this.buttonPieciokat.Click += new System.EventHandler(this.buttonPieciokat_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(533, 503);
      this.Controls.Add(this.buttonPieciokat);
      this.Controls.Add(this.buttonElipsa);
      this.Controls.Add(this.buttonProstokat);
      this.Controls.Add(this.buttonOdcinek);
      this.Controls.Add(this.buttonCzysc);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private PictureBox pictureBox1;
    private Button buttonCzysc;
    private Button buttonOdcinek;
    private Button buttonProstokat;
    private Button buttonElipsa;
    private Button buttonPieciokat;
  }
}