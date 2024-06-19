namespace MyProject_Travel
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            label1 = new System.Windows.Forms.Label();
            btn_Go = new System.Windows.Forms.Button();
            btn_Foreign = new System.Windows.Forms.Button();
            btn_Kor = new System.Windows.Forms.Button();
            lb_Q1 = new System.Windows.Forms.Label();
            btn_End = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_Calender = new System.Windows.Forms.Button();
            btn_Analytics = new System.Windows.Forms.Button();
            btn_Home = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(353, 202);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(399, 41);
            label1.TabIndex = 0;
            label1.Text = "A Travel Planning Kiosk";
            // 
            // btn_Go
            // 
            btn_Go.BackColor = System.Drawing.SystemColors.HighlightText;
            btn_Go.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Go.Location = new System.Drawing.Point(462, 333);
            btn_Go.Name = "btn_Go";
            btn_Go.Size = new System.Drawing.Size(144, 67);
            btn_Go.TabIndex = 1;
            btn_Go.Text = "Go";
            btn_Go.UseVisualStyleBackColor = false;
            btn_Go.Click += tbn_Go_Click;
            // 
            // btn_Foreign
            // 
            btn_Foreign.BackColor = System.Drawing.SystemColors.HighlightText;
            btn_Foreign.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Foreign.Location = new System.Drawing.Point(383, 365);
            btn_Foreign.Name = "btn_Foreign";
            btn_Foreign.Size = new System.Drawing.Size(131, 57);
            btn_Foreign.TabIndex = 1;
            btn_Foreign.Text = "해외여행";
            btn_Foreign.UseVisualStyleBackColor = false;
            btn_Foreign.Visible = false;
            btn_Foreign.Click += tbn_Foreign_Click;
            // 
            // btn_Kor
            // 
            btn_Kor.BackColor = System.Drawing.SystemColors.HighlightText;
            btn_Kor.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Kor.Location = new System.Drawing.Point(572, 365);
            btn_Kor.Name = "btn_Kor";
            btn_Kor.Size = new System.Drawing.Size(131, 57);
            btn_Kor.TabIndex = 1;
            btn_Kor.Text = "국내여행";
            btn_Kor.UseVisualStyleBackColor = false;
            btn_Kor.Visible = false;
            btn_Kor.Click += tbn_Kor_Click;
            // 
            // lb_Q1
            // 
            lb_Q1.AutoSize = true;
            lb_Q1.BackColor = System.Drawing.Color.Transparent;
            lb_Q1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Q1.Location = new System.Drawing.Point(370, 289);
            lb_Q1.Name = "lb_Q1";
            lb_Q1.Size = new System.Drawing.Size(350, 41);
            lb_Q1.TabIndex = 2;
            lb_Q1.Text = "어떤 여행을 선호하나요?";
            lb_Q1.Visible = false;
            // 
            // btn_End
            // 
            btn_End.BackColor = System.Drawing.Color.Transparent;
            btn_End.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn_End.FlatAppearance.BorderSize = 0;
            btn_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_End.Location = new System.Drawing.Point(0, 570);
            btn_End.Name = "btn_End";
            btn_End.Size = new System.Drawing.Size(200, 49);
            btn_End.TabIndex = 3;
            btn_End.Text = "Exit";
            btn_End.UseVisualStyleBackColor = false;
            btn_End.Click += btn_End_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(230, 200, 80);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Calender);
            panel1.Controls.Add(btn_Analytics);
            panel1.Controls.Add(btn_Home);
            panel1.Controls.Add(btn_End);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 619);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(200, 150);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(43, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 12);
            label3.TabIndex = 6;
            label3.Text = "Some User Text here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(55, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 16);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(67, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(65, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Calender
            // 
            btn_Calender.BackColor = System.Drawing.Color.Transparent;
            btn_Calender.FlatAppearance.BorderSize = 0;
            btn_Calender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Calender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Calender.Location = new System.Drawing.Point(0, 257);
            btn_Calender.Name = "btn_Calender";
            btn_Calender.Size = new System.Drawing.Size(200, 49);
            btn_Calender.TabIndex = 3;
            btn_Calender.Text = "Calender";
            btn_Calender.UseVisualStyleBackColor = false;
            btn_Calender.Click += btn_Calender_Click;
            // 
            // btn_Analytics
            // 
            btn_Analytics.BackColor = System.Drawing.Color.Transparent;
            btn_Analytics.FlatAppearance.BorderSize = 0;
            btn_Analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Analytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Analytics.Location = new System.Drawing.Point(0, 205);
            btn_Analytics.Name = "btn_Analytics";
            btn_Analytics.Size = new System.Drawing.Size(200, 49);
            btn_Analytics.TabIndex = 3;
            btn_Analytics.Text = "Analytics";
            btn_Analytics.UseVisualStyleBackColor = false;
            btn_Analytics.Click += btn_Analytics_Click;
            // 
            // btn_Home
            // 
            btn_Home.BackColor = System.Drawing.Color.Transparent;
            btn_Home.FlatAppearance.BorderSize = 0;
            btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Home.Location = new System.Drawing.Point(0, 152);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new System.Drawing.Size(200, 49);
            btn_Home.TabIndex = 3;
            btn_Home.Text = "Home";
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
            // 
            // Form0
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1090, 619);
            Controls.Add(panel1);
            Controls.Add(lb_Q1);
            Controls.Add(btn_Kor);
            Controls.Add(btn_Foreign);
            Controls.Add(btn_Go);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form0";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Button btn_Foreign;
        private System.Windows.Forms.Button btn_Kor;
        private System.Windows.Forms.Label lb_Q1;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calender;
        private System.Windows.Forms.Button btn_Analytics;
        private System.Windows.Forms.Button btn_Home;
    }
}