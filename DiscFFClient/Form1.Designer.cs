namespace DiscFFClient
{
    partial class Form1
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tf2OtherListBox = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.slenderListBox = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.vshListBox = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mkListBox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.idleListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tradeListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ffListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(759, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Website";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(759, 544);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.disc-ff.com/index.php", System.UriKind.Absolute);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server Browser";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TF2 Servers";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tf2OtherListBox);
            this.groupBox9.Location = new System.Drawing.Point(6, 405);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(606, 108);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Others";
            // 
            // tf2OtherListBox
            // 
            this.tf2OtherListBox.FormattingEnabled = true;
            this.tf2OtherListBox.Items.AddRange(new object[] {
            "Deathrun [74.91.119.154:27014] - ",
            "Prophunt [74.91.113.50:27016] - ",
            "Dodgeball [162.248.92.127:27021] - ",
            "Surf [74.91.113.50:27032] - ",
            "Payload [74.91.113.50:27030] - "});
            this.tf2OtherListBox.Location = new System.Drawing.Point(6, 18);
            this.tf2OtherListBox.Name = "tf2OtherListBox";
            this.tf2OtherListBox.Size = new System.Drawing.Size(594, 82);
            this.tf2OtherListBox.TabIndex = 0;
            this.tf2OtherListBox.SelectedIndexChanged += new System.EventHandler(this.tf2OtherListBox_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.slenderListBox);
            this.groupBox8.Location = new System.Drawing.Point(6, 348);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(606, 51);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Slender Fortress";
            // 
            // slenderListBox
            // 
            this.slenderListBox.FormattingEnabled = true;
            this.slenderListBox.Items.AddRange(new object[] {
            "Slender 1 [74.91.113.50:27019] - ",
            "Slender 2 [74.91.113.50:27091] - "});
            this.slenderListBox.Location = new System.Drawing.Point(6, 14);
            this.slenderListBox.Name = "slenderListBox";
            this.slenderListBox.Size = new System.Drawing.Size(594, 30);
            this.slenderListBox.TabIndex = 0;
            this.slenderListBox.SelectedIndexChanged += new System.EventHandler(this.slenderListBox_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.vshListBox);
            this.groupBox7.Location = new System.Drawing.Point(6, 284);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(606, 58);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Saxton Hale";
            // 
            // vshListBox
            // 
            this.vshListBox.FormattingEnabled = true;
            this.vshListBox.Items.AddRange(new object[] {
            "Saxton Hale 1 [74.91.113.65:27015] - ",
            "Saxton Hale 2 [74.91.113.50:27077] - "});
            this.vshListBox.Location = new System.Drawing.Point(6, 19);
            this.vshListBox.Name = "vshListBox";
            this.vshListBox.Size = new System.Drawing.Size(594, 30);
            this.vshListBox.TabIndex = 0;
            this.vshListBox.SelectedIndexChanged += new System.EventHandler(this.vshListBox_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mkListBox);
            this.groupBox6.Location = new System.Drawing.Point(6, 223);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(606, 55);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mario Kart";
            // 
            // mkListBox
            // 
            this.mkListBox.FormattingEnabled = true;
            this.mkListBox.Items.AddRange(new object[] {
            "Randomizer [74.91.119.154:27029] - ",
            "x10 [74.91.113.50:27049] - "});
            this.mkListBox.Location = new System.Drawing.Point(6, 16);
            this.mkListBox.Name = "mkListBox";
            this.mkListBox.Size = new System.Drawing.Size(594, 30);
            this.mkListBox.TabIndex = 0;
            this.mkListBox.SelectedIndexChanged += new System.EventHandler(this.mkListBox_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.idleListBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(606, 64);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Idle Servers";
            // 
            // idleListBox
            // 
            this.idleListBox.FormattingEnabled = true;
            this.idleListBox.Items.AddRange(new object[] {
            "Idle/Trade 1 [74.91.119.154:27015] - ",
            "Idle/Trade 2 [74.91.119.154:27017] - ",
            "Idle/Trade 3 [74.91.113.65:27019] - "});
            this.idleListBox.Location = new System.Drawing.Point(6, 14);
            this.idleListBox.Name = "idleListBox";
            this.idleListBox.Size = new System.Drawing.Size(594, 43);
            this.idleListBox.TabIndex = 0;
            this.idleListBox.SelectedIndexChanged += new System.EventHandler(this.idleListBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tradeListBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 54);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trade Servers";
            // 
            // tradeListBox
            // 
            this.tradeListBox.FormattingEnabled = true;
            this.tradeListBox.Items.AddRange(new object[] {
            "Trade/Fun 1 [216.52.148.85:27015] - ",
            "Trade/Fun 2 [74.91.113.50:27066] - "});
            this.tradeListBox.Location = new System.Drawing.Point(6, 16);
            this.tradeListBox.Name = "tradeListBox";
            this.tradeListBox.Size = new System.Drawing.Size(594, 30);
            this.tradeListBox.TabIndex = 0;
            this.tradeListBox.SelectedIndexChanged += new System.EventHandler(this.tradeListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ffListBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 68);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Freak Fortress";
            // 
            // ffListBox
            // 
            this.ffListBox.FormattingEnabled = true;
            this.ffListBox.Items.AddRange(new object[] {
            "Freak Fortress 1 [74.91.119.154:27016] - ",
            "Freak Fortress 2 [74.91.119.154:27019] - ",
            "Freak Fortress 3 [74.91.113.65:27017] - "});
            this.ffListBox.Location = new System.Drawing.Point(6, 16);
            this.ffListBox.Name = "ffListBox";
            this.ffListBox.Size = new System.Drawing.Size(594, 43);
            this.ffListBox.TabIndex = 0;
            this.ffListBox.SelectedIndexChanged += new System.EventHandler(this.ffListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 594);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Disc-FF Desktop Client v1.1.0 by Kyle Smith";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ffListBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox mkListBox;
        private System.Windows.Forms.ListBox idleListBox;
        private System.Windows.Forms.ListBox tradeListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox tf2OtherListBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox slenderListBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox vshListBox;
        private System.Windows.Forms.Button button3;
    }
}

