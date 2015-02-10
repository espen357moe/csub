using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Rectangle seaRectangle = new Rectangle();
            //LinearGradientBrush seaBrush = new LinearGradientBrush(seaRectangle, System.Drawing.Color.Aquamarine, Color.DarkBlue, 45, false);
                
       
      

  

            Image periskop = System.Drawing.Image.FromFile("../../images/periskop.png");
            e.Graphics.DrawImage(periskop, 0, 0 ,800, 800);

        }
    }
}
