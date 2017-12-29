namespace dataADUstudy.窗口程序
{
    partial class regist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regist));
            this.label1 = new System.Windows.Forms.Label();
            this.RegistIdentity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RGname = new System.Windows.Forms.TextBox();
            this.RGpass = new System.Windows.Forms.TextBox();
            this.RGpass2 = new System.Windows.Forms.TextBox();
            this.RGnumber = new System.Windows.Forms.TextBox();
            this.RGbanji = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.code = new System.Windows.Forms.TextBox();
            this.Verification_Code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择身份：";
            // 
            // RegistIdentity
            // 
            this.RegistIdentity.FormattingEnabled = true;
            this.RegistIdentity.Items.AddRange(new object[] {
            "学生",
            "教师",
            "请选择您的身份"});
            this.RegistIdentity.Location = new System.Drawing.Point(100, 74);
            this.RegistIdentity.Name = "RegistIdentity";
            this.RegistIdentity.Size = new System.Drawing.Size(121, 20);
            this.RegistIdentity.TabIndex = 1;
            this.RegistIdentity.SelectedIndexChanged += new System.EventHandler(this.RegistIdentity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(109, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "确认密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "教师编号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "班级：";
            // 
            // RGname
            // 
            this.RGname.Location = new System.Drawing.Point(101, 34);
            this.RGname.Name = "RGname";
            this.RGname.Size = new System.Drawing.Size(120, 21);
            this.RGname.TabIndex = 8;
            this.RGname.Leave += new System.EventHandler(this.RGname_Leave);
            // 
            // RGpass
            // 
            this.RGpass.Location = new System.Drawing.Point(101, 79);
            this.RGpass.Name = "RGpass";
            this.RGpass.PasswordChar = '*';
            this.RGpass.Size = new System.Drawing.Size(120, 21);
            this.RGpass.TabIndex = 9;
            // 
            // RGpass2
            // 
            this.RGpass2.Location = new System.Drawing.Point(101, 130);
            this.RGpass2.Name = "RGpass2";
            this.RGpass2.PasswordChar = '*';
            this.RGpass2.Size = new System.Drawing.Size(120, 21);
            this.RGpass2.TabIndex = 10;
            this.RGpass2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RGpass2_KeyUp);
            // 
            // RGnumber
            // 
            this.RGnumber.Location = new System.Drawing.Point(101, 175);
            this.RGnumber.Name = "RGnumber";
            this.RGnumber.Size = new System.Drawing.Size(120, 21);
            this.RGnumber.TabIndex = 11;
            this.RGnumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RGnumber_KeyUp);
            // 
            // RGbanji
            // 
            this.RGbanji.Location = new System.Drawing.Point(101, 218);
            this.RGbanji.Name = "RGbanji";
            this.RGbanji.Size = new System.Drawing.Size(120, 21);
            this.RGbanji.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(89, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(207, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "返回登录";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(241, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.code);
            this.panel1.Controls.Add(this.Verification_Code);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.RGpass);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.RGbanji);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.RGnumber);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RGpass2);
            this.panel1.Controls.Add(this.RGname);
            this.panel1.Location = new System.Drawing.Point(13, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 393);
            this.panel1.TabIndex = 16;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(100, 269);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(120, 21);
            this.code.TabIndex = 18;
            this.code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.code_KeyUp);
            // 
            // Verification_Code
            // 
            this.Verification_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Verification_Code.ForeColor = System.Drawing.Color.White;
            this.Verification_Code.Location = new System.Drawing.Point(226, 270);
            this.Verification_Code.Name = "Verification_Code";
            this.Verification_Code.ReadOnly = true;
            this.Verification_Code.Size = new System.Drawing.Size(71, 21);
            this.Verification_Code.TabIndex = 17;
            this.Verification_Code.Text = "6666";
            this.Verification_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "验证码：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(303, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "labe12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(241, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "如：3班";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(241, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "label11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(239, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(241, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "labe14";
            // 
            // regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(399, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegistIdentity);
            this.Controls.Add(this.label1);
            this.Name = "regist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "regist";
            this.Load += new System.EventHandler(this.regist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RegistIdentity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RGname;
        private System.Windows.Forms.TextBox RGpass;
        private System.Windows.Forms.TextBox RGpass2;
        private System.Windows.Forms.TextBox RGnumber;
        private System.Windows.Forms.TextBox RGbanji;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox Verification_Code;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

    }
}