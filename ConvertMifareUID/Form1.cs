using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConvertMifareUID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox2.Text = tmcUID.ConvertToDec(tmcUID.reversUID(textBox1.Text));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                button1_Click(button1, null);
            e.Handled = !System.Uri.IsHexDigit(e.KeyChar)
                && e.KeyChar != 0x8     //Backspace
                && e.KeyChar != 0x3     //Ctrl + C
                && e.KeyChar != 0x16;   //Crtl + V
        }
    }
}
