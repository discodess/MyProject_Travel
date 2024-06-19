namespace MyProject_Travel
{
    partial class Form00_Login
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            tbID = new System.Windows.Forms.TextBox();
            tbPassWord = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnJoin = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(152, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 31);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // tbID
            // 
            tbID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            tbID.Location = new System.Drawing.Point(96, 100);
            tbID.Name = "tbID";
            tbID.Size = new System.Drawing.Size(189, 23);
            tbID.TabIndex = 1;
            tbID.Text = "아이디";
            tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tbID.Click += tbID_Click;
            // 
            // tbPassWord
            // 
            tbPassWord.ForeColor = System.Drawing.SystemColors.WindowFrame;
            tbPassWord.Location = new System.Drawing.Point(96, 129);
            tbPassWord.Name = "tbPassWord";
            tbPassWord.Size = new System.Drawing.Size(189, 23);
            tbPassWord.TabIndex = 1;
            tbPassWord.Text = "비밀번호";
            tbPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tbPassWord.Click += tbPassWord_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnLogin.Location = new System.Drawing.Point(96, 158);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(189, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel1.Location = new System.Drawing.Point(64, 187);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(250, 3);
            panel1.TabIndex = 3;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnJoin.FlatAppearance.BorderSize = 0;
            btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnJoin.ForeColor = System.Drawing.SystemColors.WindowText;
            btnJoin.Location = new System.Drawing.Point(96, 196);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new System.Drawing.Size(189, 23);
            btnJoin.TabIndex = 2;
            btnJoin.Text = "회원가입";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Enabled = false;
            progressBar1.Location = new System.Drawing.Point(96, 84);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(189, 23);
            progressBar1.Step = 1;
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 4;
            progressBar1.Visible = false;
            // 
            // Form00_Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 261);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(btnJoin);
            Controls.Add(btnLogin);
            Controls.Add(tbPassWord);
            Controls.Add(tbID);
            Controls.Add(label1);
            Name = "Form00_Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}