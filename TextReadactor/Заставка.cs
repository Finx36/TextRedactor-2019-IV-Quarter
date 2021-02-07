using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReadactor
{
    public partial class Заставка : Form
    {
        public Заставка()
        {
            InitializeComponent();
        }

        private void Заставка_Load(object sender, EventArgs e)
        {
            AllowTransparency = true;
            TransparencyKey = Color.DimGray;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity != 1) Opacity += 0.01;
            else
            {
                Form main = new MainForm();
                timer1.Enabled = false;
                Hide();
                main.Show();
            }
        }
    }
}
