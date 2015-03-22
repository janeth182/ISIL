using System;
using System.Windows.Forms;

public class MyForm : Form
{
  private Button btnUseVehicles = new Button();

  public MyForm()
  {
    this.Text = "My Multifile Asm Client";
    btnUseVehicles.Text = "Click Me";
    btnUseVehicles.Width = 100;
    btnUseVehicles.Height = 100;
    btnUseVehicles.Top = 10;
    btnUseVehicles.Left = 10;
    btnUseVehicles.Click += new EventHandler(btnUseVehicles_Click);
    this.Controls.Add(btnUseVehicles);  
}

  private void btnUseVehicles_Click(object o, EventArgs e)
  {
	MessageBox.Show("Hola");
  }

  private static void Main()
  {
    Application.Run(new MyForm());
  }
}