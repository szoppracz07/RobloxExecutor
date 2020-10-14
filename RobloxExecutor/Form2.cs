using System;
using System.Collections.Generic;
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
using WeAreDevs_API;

namespace RobloxExecutor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ExploitAPI api = new ExploitAPI();
        private void flatButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            string text = fastColoredTextBox1.Text;
            this.api.SendLimitedLuaScript(text);
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void flatButton3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void flatButton3_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => fastColoredTextBox1.Text = File.ReadAllText($"C:/EasyCheats/Scripts/{listBox1.SelectedItem}");

        private void flatButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
            Functions.PopulateListBox(listBox1, @"C:\EasyCheats\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, @"C:\EasyCheats\Scripts", "*.lua");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
            Functions.PopulateListBox(listBox1, @"C:\EasyCheats\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, @"C:\EasyCheats\Scripts", "*.lua");
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            api.IsUpdated();
            api.LaunchExploit();
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\EasyCheats\Scripts");
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            if (!Directory.Exists(@"C:\EasyCheats\Scripts\Fly.txt"))
            {
                System.IO.File.WriteAllText(@"C:\EasyCheats\Scripts\Fly.txt", webClient.DownloadString("https://pastebin.com/raw/7rXZ9VNc"));
            }
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, @"C:\EasyCheats\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, @"C:\EasyCheats\Scripts", "*.lua");

        }
    }
}
