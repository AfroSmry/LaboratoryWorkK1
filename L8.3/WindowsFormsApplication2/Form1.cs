// Нарисовать светофор.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

class Form1 : Form
{
  private int lightColor = 1;

  public Form1()
  {
    InitializeComponent();
  }

  private void Form1_Paint(object sender, PaintEventArgs e)
  {
    Graphics g = e.Graphics;

    g.FillRectangle(Brushes.White, this.ClientRectangle);
    Rectangle r = new Rectangle(10, 10, 60, 180);
    g.FillRectangle(Brushes.LightGray, r);
    Rectangle r1 = new Rectangle(10, 10, 60, 60);
    Rectangle r2 = new Rectangle(10, 70, 60, 60);
    Rectangle r3 = new Rectangle(10, 130, 60, 60);
    switch (lightColor)
    {
      case 1:
        g.FillEllipse(Brushes.Red, r1);
        g.FillEllipse(Brushes.Black, r2);
        g.FillEllipse(Brushes.Black, r3);
        break;
      case 2:
        g.FillEllipse(Brushes.Black, r1);
        g.FillEllipse(Brushes.Yellow, r2);
        g.FillEllipse(Brushes.Black, r3);
        break;
      case 3:
        g.FillEllipse(Brushes.Black, r1);
        g.FillEllipse(Brushes.Black, r2);
        g.FillEllipse(Brushes.Green, r3);
        break;
    }
  }

  private void Form1_Click(object sender, EventArgs e)
  {
    lightColor++;
    if (lightColor == 4)
      lightColor = 1;
    this.Invalidate();
  }
  private void InitializeComponent()
  {
    this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
    this.ClientSize = new System.Drawing.Size(292, 271);
    this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
    this.Click += new System.EventHandler(this.Form1_Click);
  }

  [STAThread]
  static void Main()
  {
    Application.EnableVisualStyles();
    Application.Run(new Form1());
  }

}