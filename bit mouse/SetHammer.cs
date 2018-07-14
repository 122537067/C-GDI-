using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bit_mouse
{
    public partial class SetHammer : Form
    {
        string hammerpath;//鼠标锤子图片路径
        public string Hammerpath
        {
            get { return hammerpath; }
        }

        public SetHammer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                hammerpath = "锤子";
            }
            else if (radioButton2.Checked)
            {
                hammerpath = "铁锤";
            }
            else
            {
                hammerpath = "魔法大棒";
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
