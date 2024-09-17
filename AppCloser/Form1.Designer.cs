namespace AppCloser
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSearch = new System.Windows.Forms.Timer(this.components);
            this.buttonStartSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Crimson;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 92);
            this.listBox1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Crimson;
            this.buttonClose.Location = new System.Drawing.Point(78, 152);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(54, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "اغلاق";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRefresh.Location = new System.Drawing.Point(12, 152);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(46, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "تحديث";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 33);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(84, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(87, 33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(45, 20);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "بحث";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPause.Location = new System.Drawing.Point(440, 80);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "ايقاف موقت";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(440, 54);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(79, 20);
            this.textBoxDuration.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "مدة ايقاف البرنامج الموقت";
            // 
            // timerSearch
            // 
            this.timerSearch.Tick += new System.EventHandler(this.timerSearch_Tick);
            // 
            // buttonStartSearch
            // 
            this.buttonStartSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonStartSearch.Location = new System.Drawing.Point(535, 79);
            this.buttonStartSearch.Name = "buttonStartSearch";
            this.buttonStartSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonStartSearch.TabIndex = 8;
            this.buttonStartSearch.Text = "بحث";
            this.buttonStartSearch.UseVisualStyleBackColor = true;
            this.buttonStartSearch.Click += new System.EventHandler(this.buttonStartSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(610, 341);
            this.Controls.Add(this.buttonStartSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Apps Closer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSearch;
        private System.Windows.Forms.Button buttonStartSearch;
    }
}
