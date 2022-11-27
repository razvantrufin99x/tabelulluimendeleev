using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tabelulluimendeleev
{
    public partial class elementchimic : UserControl
    {
        public void setLabel(string s)
        {
            label1.Text = s;
        
        }

        public Form1 f;


        public elementchimic()
        {
            InitializeComponent();
        }

        private void elementchimic_Load(object sender, EventArgs e)
        {
            try {
                f = (Form1)ParentForm;
            }
            catch { }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            f.Text = label1.Text;
            f.setLabel(label1.Text);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            f.setLabel(label1.Text);
        }
    }
}
