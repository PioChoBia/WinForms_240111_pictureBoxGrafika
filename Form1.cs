using System.Security.Cryptography.X509Certificates;

namespace WinForms_240111_pictureBoxGrafika
{
  public partial class Form1 : Form
  {  

    public Form1()
    {
      InitializeComponent();
      pictureBox1.Size=new Size(400,400);
      pictureBox1.Location = new Point(10, 10);
      //pictureBox1.BackColor= Color.Gray;
    }

  
    //rysuje na pocz¹tku i po ka¿dym Refresh()
    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.Clear(Color.White);
      e.Graphics.DrawString(
        "mo¿na coœ tu stworzyæ\nzapraszam do malowania",
        new Font("Arial", 20), Brushes.DarkSlateGray, new PointF(10, 10));
    }

    private void buttonCzysc_Click(object sender, EventArgs e)
    {
      pictureBox1.Refresh();
    }

    private void buttonOdcinek_Click(object sender, EventArgs e)
    {
      pictureBox1.CreateGraphics().DrawLine(
        new Pen(Color.Black,3),
        new Point(0, 0), new Point(399, 399));
    }

    private void buttonProstokat_Click(object sender, EventArgs e)
    {
      Graphics g = pictureBox1.CreateGraphics();
      g.DrawRectangle(
        Pens.Brown,
        new Rectangle(new Point(10, 10), new Size(50, 80)) );
    }

    private void buttonElipsa_Click(object sender, EventArgs e)
    {

    }

    private void buttonPieciokat_Click(object sender, EventArgs e)
    {

    }


  }
}