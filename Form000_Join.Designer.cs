namespace MyProject_Travel
{
    partial class Form000_Join
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbName = new System.Windows.Forms.TextBox();
            btnCheck = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            tbPhoneNumber = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tbID = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            tbPassWord = new System.Windows.Forms.TextBox();
            btnDoJoin = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(117, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 29);
            label1.TabIndex = 0;
            label1.Text = "회원가입";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(25, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "이름";
            // 
            // tbName
            // 
            tbName.Location = new System.Drawing.Point(25, 73);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(202, 23);
            tbName.TabIndex = 2;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheck.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCheck.ForeColor = System.Drawing.SystemColors.WindowText;
            btnCheck.Location = new System.Drawing.Point(233, 181);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new System.Drawing.Size(75, 23);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "중복 확인";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(25, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "휴대폰";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new System.Drawing.Point(25, 126);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new System.Drawing.Size(202, 23);
            tbPhoneNumber.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(25, 163);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 1;
            label4.Text = "아이디";
            // 
            // tbID
            // 
            tbID.Location = new System.Drawing.Point(25, 181);
            tbID.Name = "tbID";
            tbID.Size = new System.Drawing.Size(202, 23);
            tbID.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(25, 217);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 15);
            label5.TabIndex = 1;
            label5.Text = "비밀번호";
            // 
            // tbPassWord
            // 
            tbPassWord.Location = new System.Drawing.Point(25, 235);
            tbPassWord.Name = "tbPassWord";
            tbPassWord.Size = new System.Drawing.Size(202, 23);
            tbPassWord.TabIndex = 2;
            // 
            // btnDoJoin
            // 
            btnDoJoin.BackColor = System.Drawing.Color.DarkOrange;
            btnDoJoin.FlatAppearance.BorderSize = 0;
            btnDoJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDoJoin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDoJoin.ForeColor = System.Drawing.SystemColors.WindowText;
            btnDoJoin.Location = new System.Drawing.Point(16, 293);
            btnDoJoin.Name = "btnDoJoin";
            btnDoJoin.Size = new System.Drawing.Size(140, 30);
            btnDoJoin.TabIndex = 3;
            btnDoJoin.Text = "가입하기";
            btnDoJoin.UseVisualStyleBackColor = false;
            btnDoJoin.Click += btnDoJoin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.BlanchedAlmond;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            btnCancel.Location = new System.Drawing.Point(178, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(140, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form000_Join
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(334, 361);
            Controls.Add(btnCancel);
            Controls.Add(btnDoJoin);
            Controls.Add(btnCheck);
            Controls.Add(tbPassWord);
            Controls.Add(label5);
            Controls.Add(tbID);
            Controls.Add(label4);
            Controls.Add(tbPhoneNumber);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form000_Join";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form000_Join";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Button btnDoJoin;
        private System.Windows.Forms.Button btnCancel;
    }
}