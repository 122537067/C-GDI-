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
    public partial class Setting : Form
    {
        public Setting(int gotscore,int losescore,int winscore,int defeatscore,int propscore)
        {
            InitializeComponent();

            //获取上次修改时的数值
            this.textBox_got.Text = gotscore.ToString();
            this.textBox_lose.Text = losescore.ToString();
            this.textBox_win.Text = winscore.ToString();
            this.textBox_defeat.Text = defeatscore.ToString();
            this.textBox_prop.Text = propscore.ToString();
        }
        
        //当TextBox为空时
        public void onenull()
        {
            if(textBox_got.Text=="")
            {
                textBox_got.Text = "1";
            }
            if (textBox_lose.Text =="")
            {
                textBox_lose.Text = "1";
            }
            if (textBox_win.Text == "")
            {
                textBox_win.Text = "30";
            }
            if (textBox_defeat.Text == "")
            {
                textBox_defeat.Text = "-5";
            }
            if(textBox_prop.Text=="")
            {
                textBox_prop.Text = "-4";
            }
        }
        //封装
        public int Getscore
        {
            get { return Convert.ToInt32(textBox_got.Text); }
        }
        public int Losescore
        {
            get { return Convert.ToInt32(textBox_lose.Text); }
        }
        public int Winscore
        {
            get { return Convert.ToInt32(textBox_win.Text); }
        }
        public int Defeatscore
        {
            get { return Convert.ToInt32(textBox_defeat.Text); }
        }
        public int Propscore
        {
            get { return Convert.ToInt32(textBox_prop.Text); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onenull();
            this.DialogResult = DialogResult.OK;
        }

        private void textBox_got_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断输入的是否为数字
            //char8是退格键的键值
            if(!(Char.IsNumber(e.KeyChar))&&e.KeyChar!=(char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox_lose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox_win_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox_defeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //45是减号的ASCII值
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8&&e.KeyChar!=(char)45)
            {
                e.Handled = true;
            }
        }

        private void textBox_prop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }
    }
}
