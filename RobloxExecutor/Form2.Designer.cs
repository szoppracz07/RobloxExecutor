namespace RobloxExecutor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton4 = new FlatUI.FlatButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flatButton5 = new FlatUI.FlatButton();
            this.flatButton6 = new FlatUI.FlatButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatButton7 = new FlatUI.FlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flatButton8 = new FlatUI.FlatButton();
            this.flatButton9 = new FlatUI.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBrackets = true;
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(75, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(12, 52);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(591, 386);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Text = "Script";
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(12, 444);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(98, 34);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "Execute";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.UseCustomColor = false;
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(617, 444);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(171, 34);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "Refresh";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.UseCustomColor = false;
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(220, 444);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(98, 34);
            this.flatButton3.TabIndex = 3;
            this.flatButton3.Text = "Load File";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.UseCustomColor = false;
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            this.flatButton3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flatButton3_MouseMove);
            this.flatButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flatButton3_MouseUp);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(116, 444);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(98, 34);
            this.flatButton4.TabIndex = 4;
            this.flatButton4.Text = "Clear";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.UseCustomColor = false;
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(617, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 381);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.Transparent;
            this.flatButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton5.Location = new System.Drawing.Point(753, 12);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = false;
            this.flatButton5.Size = new System.Drawing.Size(35, 34);
            this.flatButton5.TabIndex = 6;
            this.flatButton5.Text = "X";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.UseCustomColor = false;
            this.flatButton5.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // flatButton6
            // 
            this.flatButton6.BackColor = System.Drawing.Color.Transparent;
            this.flatButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton6.Location = new System.Drawing.Point(712, 12);
            this.flatButton6.Name = "flatButton6";
            this.flatButton6.Rounded = false;
            this.flatButton6.Size = new System.Drawing.Size(35, 34);
            this.flatButton6.TabIndex = 7;
            this.flatButton6.Text = "_";
            this.flatButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton6.UseCustomColor = false;
            this.flatButton6.Click += new System.EventHandler(this.flatButton6_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(12, 12);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(108, 25);
            this.flatLabel1.TabIndex = 8;
            this.flatLabel1.Text = "easyCheats";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(308, 12);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(151, 25);
            this.flatLabel2.TabIndex = 9;
            this.flatLabel2.Text = "Roblox Executor";
            // 
            // flatButton7
            // 
            this.flatButton7.BackColor = System.Drawing.Color.Transparent;
            this.flatButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton7.Location = new System.Drawing.Point(324, 444);
            this.flatButton7.Name = "flatButton7";
            this.flatButton7.Rounded = false;
            this.flatButton7.Size = new System.Drawing.Size(98, 34);
            this.flatButton7.TabIndex = 10;
            this.flatButton7.Text = "Inject";
            this.flatButton7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton7.UseCustomColor = false;
            this.flatButton7.Click += new System.EventHandler(this.flatButton7_Click);
            // 
            // flatButton8
            // 
            this.flatButton8.BackColor = System.Drawing.Color.Transparent;
            this.flatButton8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton8.Location = new System.Drawing.Point(428, 444);
            this.flatButton8.Name = "flatButton8";
            this.flatButton8.Rounded = false;
            this.flatButton8.Size = new System.Drawing.Size(175, 34);
            this.flatButton8.TabIndex = 11;
            this.flatButton8.Text = "Open Scripts";
            this.flatButton8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton8.UseCustomColor = false;
            this.flatButton8.Click += new System.EventHandler(this.flatButton8_Click);
            // 
            // flatButton9
            // 
            this.flatButton9.BackColor = System.Drawing.Color.Transparent;
            this.flatButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton9.Location = new System.Drawing.Point(535, 12);
            this.flatButton9.Name = "flatButton9";
            this.flatButton9.Rounded = false;
            this.flatButton9.Size = new System.Drawing.Size(171, 34);
            this.flatButton9.TabIndex = 12;
            this.flatButton9.Text = "Download Scripts";
            this.flatButton9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton9.UseCustomColor = false;
            this.flatButton9.Click += new System.EventHandler(this.flatButton9_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.flatButton9);
            this.Controls.Add(this.flatButton8);
            this.Controls.Add(this.flatButton7);
            this.Controls.Add(this.flatLabel2);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this.flatButton6);
            this.Controls.Add(this.flatButton5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.flatButton4);
            this.Controls.Add(this.flatButton3);
            this.Controls.Add(this.flatButton2);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.fastColoredTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roblox Executor";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton4;
        private System.Windows.Forms.ListBox listBox1;
        private FlatUI.FlatButton flatButton5;
        private FlatUI.FlatButton flatButton6;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatButton flatButton7;
        private System.Windows.Forms.Timer timer1;
        private FlatUI.FlatButton flatButton8;
        private FlatUI.FlatButton flatButton9;
    }
}