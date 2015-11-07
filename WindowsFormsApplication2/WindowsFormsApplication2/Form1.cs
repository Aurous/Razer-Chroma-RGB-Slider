using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corale.Colore;
using Corale.Colore.Razer.Mouse;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_color();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            update_color();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
            update_color();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            numericUpDown3.Value = trackBar3.Value;
            update_color();
        }
        public void update_color()
        {
            var r = (byte)trackBar1.Value;
            var b = (byte)trackBar2.Value;
            var g = (byte)trackBar3.Value;
            var color = new Corale.Colore.Core.Color(r, b, g);
            Corale.Colore.Razer.Mouse.Led led1 = Led.Logo;
            Corale.Colore.Core.Mouse.Instance.SetLed(led1, color);
            Corale.Colore.Razer.Mouse.Led led2 = Led.ScrollWheel;
            Corale.Colore.Core.Mouse.Instance.SetLed(led2, color);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Decimal.ToInt32(numericUpDown1.Value);
            update_color();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = Decimal.ToInt32(numericUpDown2.Value);
            update_color();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Value = Decimal.ToInt32(numericUpDown3.Value);
            update_color();
        }
    }
}
