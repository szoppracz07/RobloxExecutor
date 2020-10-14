using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Collections.Specialized;

namespace RobloxExecutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();

            string path = $"./Scripts/";

            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }

            string path2 = @"C:\EasyCheats\Scripts";

            if (!Directory.Exists(path2))
            {
                DirectoryInfo di2 = Directory.CreateDirectory(path2);
            }

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void flatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using this executor");
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void flatLabel1_Click(object sender, EventArgs e)
        {

        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
