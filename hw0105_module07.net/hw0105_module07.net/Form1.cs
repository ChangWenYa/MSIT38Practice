using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw0105_module07.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void MyDelegate(string str);
        void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate = new MyDelegate(ShowMsg);
            myDelegate.Invoke("Hello");
            //button2.Click += DoShow;
            //事件訂閱在btn1-->點選btn1再選btn2才會跑出click，如果沒點選btn1，點btn2就不會有東西
        }

        private void DoShow (object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click += DoShow;
            //事件訂閱在btn2，會導致點選btn3之後無法取消Click
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Click -= DoShow;
        }
    }
}
