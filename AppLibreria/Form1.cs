using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLibreria;

namespace AppLibreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnViaTel_Click(object sender, EventArgs e)
        {
            var FormViaTele = new Form2();
            FormViaTele.Show();
        }

        private void btnPresencial_Click(object sender, EventArgs e)
        {
            var FormPresenc = new Form3();
            FormPresenc.Show();
        }


        





    }
}
