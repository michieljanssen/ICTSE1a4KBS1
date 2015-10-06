using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


//Scherm

namespace xXxGitrekt420xXx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics dc = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            dc.DrawRectangle(pen, 0, 0, 100, 100);
            protected override OnPaint(PaintEventArgs e);

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics dc = this.CreateGraphics();
        Pen p = new Pen(Color.Black, 1);
        dc.DrawLine(p, 10, 10, 100, 100);
        Pen thickBluePen = new Pen(Color.Blue, 10);
        dc.DrawEllipse(thickBluePen, 100, 100, 200, 200);
        Pen thickRedPen = new Pen(Color.Red, 10);
        dc.DrawRectangle(thickRedPen, 100, 100, 200, 200);
    }


    private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
