using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeTrackeringMouseV03
{
    public partial class MouseTestField : Form
    {
        public MouseTestField()
        {
            InitializeComponent();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.BackColor = Color.Chartreuse;
            label1.Text = "DoubleClick";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.BlueViolet;
            label1.Text = "Click";
        }
    }
}
