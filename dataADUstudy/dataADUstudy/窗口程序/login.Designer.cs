namespace dataADUstudy.窗口程序
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.DoLogin = new System.Windows.Forms.Button();
            this.DoNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tusername = new System.Windows.Forms.TextBox();
            this.Tpass = new System.Windows.Forms.TextBox();
            this.identity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Verification_Code = new System.Windows.Forms.TextBox();
            this.Verification_Code_in = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DoRegist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoLogin
            // 
            this.DoLogin.Location = new System.Drawing.Point(383, 294);
            this.DoLogin.Name = "DoLogin";
            this.DoLogin.Size = new System.Drawing.Size(75, 23);
            this.DoLogin.TabIndex = 0;
            this.DoLogin.Text = "登录";
            this.DoLogin.UseVisualStyleBackColor = true;
            this.DoLogin.Click += new System.EventHandler(this.DoLogin_Click);
            // 
            // DoNo
            // 
            this.DoNo.Location = new System.Drawing.Point(543, 294);
            this.DoNo.Name = "DoNo";
            this.DoNo.Size = new System.Drawing.Size(75, 23);
            this.DoNo.TabIndex = 1;
            this.DoNo.Text = "取消";
            this.DoNo.UseVisualStyleBackColor = true;
            this.DoNo.Click += new System.EventHandler(this.DoNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // Tusername
            // 
            this.Tusername.Location = new System.Drawing.Point(441, 159);
            this.Tusername.Name = "Tusername";
            this.Tusername.Size = new System.Drawing.Size(100, 21);
            this.Tusername.TabIndex = 4;
            // 
            // Tpass
            // 
            this.Tpass.Location = new System.Drawing.Point(441, 196);
            this.Tpass.Name = "Tpass";
            this.Tpass.Size = new System.Drawing.Size(100, 21);
            this.Tpass.TabIndex = 5;
            // 
            // identity
            // 
            this.identity.FormattingEnabled = true;
            this.identity.Items.AddRange(new object[] {
            "学生",
            "教师",
            "管理员"});
            this.identity.Location = new System.Drawing.Point(441, 226);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(100, 20);
            this.identity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "选择身份：";
            // 
            // Verification_Code
            // 
            this.Verification_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Verification_Code.ForeColor = System.Drawing.Color.White;
            this.Verification_Code.Location = new System.Drawing.Point(547, 257);
            this.Verification_Code.Name = "Verification_Code";
            this.Verification_Code.ReadOnly = true;
            this.Verification_Code.Size = new System.Drawing.Size(71, 21);
            this.Verification_Code.TabIndex = 11;
            this.Verification_Code.Text = "6666";
            this.Verification_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Verification_Code_in
            // 
            this.Verification_Code_in.Location = new System.Drawing.Point(441, 255);
            this.Verification_Code_in.Name = "Verification_Code_in";
            this.Verification_Code_in.Size = new System.Drawing.Size(100, 21);
            this.Verification_Code_in.TabIndex = 10;
            this.Verification_Code_in.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Verification_Code_in_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "验证码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // DoRegist
            // 
            this.DoRegist.Location = new System.Drawing.Point(463, 294);
            this.DoRegist.Name = "DoRegist";
            this.DoRegist.Size = new System.Drawing.Size(75, 23);
            this.DoRegist.TabIndex = 13;
            this.DoRegist.Text = "注册";
            this.DoRegist.UseVisualStyleBackColor = true;
            this.DoRegist.Click += new System.EventHandler(this.DoRegist_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 452);
            this.Controls.Add(this.DoRegist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Verification_Code);
            this.Controls.Add(this.Verification_Code_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.identity);
            this.Controls.Add(this.Tpass);
            this.Controls.Add(this.Tusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoNo);
            this.Controls.Add(this.DoLogin);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoLogin;
        private System.Windows.Forms.Button DoNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public  System.Windows.Forms.TextBox Tusername;
        public System.Windows.Forms.TextBox Tpass;
        public System.Windows.Forms.ComboBox identity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Verification_Code;
        private System.Windows.Forms.TextBox Verification_Code_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DoRegist;
    }
}