using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TextReadactor
{
    public partial class RegKeys : Form
    
    {
        public RegKeys()
        {
            InitializeComponent();
        }

        bool sw = true;
        private void Button1_Click(object sender, EventArgs e)
        {
            switch (sw)
            {
                case (true):
                    RegistryKey currentUserKey = Registry.CurrentUser;
                    RegistryKey Licences = currentUserKey.OpenSubKey("Licences");
                    string key = Licences.GetValue("Key1").ToString();
                    Licences.Close();
                    
                    if (textBox1.Text == key)
                    {
                        Hide();
                        Form Заставка = new Заставка();
                        Заставка.Show();
                    }
                    else
                        MessageBox.Show("Введен неверный ключ");
                    break;
                case (false):

                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        //public bool tm1 = true;
        //public bool tm2 = true;
        //private void Button3_Click(object sender, EventArgs e)
        //{
        //    if (tm1 == true)
        //    {
        //        Form Заставка = new Заставка();
        //        Заставка.Show();
        //        tm2 = false;
        //    }
        //    else
        //        button3.Enabled = false;
        //    Hide();
            
        //}

    }
}
