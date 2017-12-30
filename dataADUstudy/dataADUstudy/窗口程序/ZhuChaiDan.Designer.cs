namespace dataADUstudy
{
    partial class ZhuChaiDan
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZhuChaiDan));
            this.adminmnue = new System.Windows.Forms.MenuStrip();
            this.审核管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.待审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.teamnue = new System.Windows.Forms.MenuStrip();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询所有成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stumnue = new System.Windows.Forms.MenuStrip();
            this.成绩查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.个人成绩查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.账号管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程归属 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.daishenghe = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GeRenChengji_op = new System.Windows.Forms.Panel();
            this.StuNum_in = new System.Windows.Forms.TextBox();
            this.Search_TS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adminmnue.SuspendLayout();
            this.teamnue.SuspendLayout();
            this.stumnue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.daishenghe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.GeRenChengji_op.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminmnue
            // 
            this.adminmnue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.审核管理ToolStripMenuItem,
            this.添加用户ToolStripMenuItem,
            this.退出登录ToolStripMenuItem2});
            this.adminmnue.Location = new System.Drawing.Point(0, 50);
            this.adminmnue.Name = "adminmnue";
            this.adminmnue.Size = new System.Drawing.Size(1008, 25);
            this.adminmnue.TabIndex = 0;
            this.adminmnue.Text = "menuStrip1";
            // 
            // 审核管理ToolStripMenuItem
            // 
            this.审核管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.待审核ToolStripMenuItem,
            this.审核ToolStripMenuItem});
            this.审核管理ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.审核管理ToolStripMenuItem.Name = "审核管理ToolStripMenuItem";
            this.审核管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.审核管理ToolStripMenuItem.Text = "审核管理";
            // 
            // 待审核ToolStripMenuItem
            // 
            this.待审核ToolStripMenuItem.Name = "待审核ToolStripMenuItem";
            this.待审核ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.待审核ToolStripMenuItem.Text = "待审核";
            this.待审核ToolStripMenuItem.Click += new System.EventHandler(this.待审核ToolStripMenuItem_Click);
            // 
            // 审核ToolStripMenuItem
            // 
            this.审核ToolStripMenuItem.Name = "审核ToolStripMenuItem";
            this.审核ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.审核ToolStripMenuItem.Text = "已审核";
            this.审核ToolStripMenuItem.Click += new System.EventHandler(this.审核ToolStripMenuItem_Click);
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem1,
            this.删除用户ToolStripMenuItem});
            this.添加用户ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加用户ToolStripMenuItem.Text = "用户管理";
            // 
            // 添加用户ToolStripMenuItem1
            // 
            this.添加用户ToolStripMenuItem1.Name = "添加用户ToolStripMenuItem1";
            this.添加用户ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.添加用户ToolStripMenuItem1.Text = "添加用户";
            this.添加用户ToolStripMenuItem1.Click += new System.EventHandler(this.添加用户ToolStripMenuItem1_Click);
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            this.删除用户ToolStripMenuItem.Click += new System.EventHandler(this.删除用户ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem2
            // 
            this.退出登录ToolStripMenuItem2.ForeColor = System.Drawing.Color.DarkRed;
            this.退出登录ToolStripMenuItem2.Name = "退出登录ToolStripMenuItem2";
            this.退出登录ToolStripMenuItem2.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem2.Text = "退出登录";
            this.退出登录ToolStripMenuItem2.Click += new System.EventHandler(this.退出登录ToolStripMenuItem2_Click);
            // 
            // teamnue
            // 
            this.teamnue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩查询ToolStripMenuItem,
            this.账号管理ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.teamnue.Location = new System.Drawing.Point(0, 25);
            this.teamnue.Name = "teamnue";
            this.teamnue.Size = new System.Drawing.Size(1008, 25);
            this.teamnue.TabIndex = 1;
            this.teamnue.Text = "menuStrip2";
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询所有成绩ToolStripMenuItem,
            this.个人成绩查询ToolStripMenuItem});
            this.成绩查询ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            // 
            // 查询所有成绩ToolStripMenuItem
            // 
            this.查询所有成绩ToolStripMenuItem.Name = "查询所有成绩ToolStripMenuItem";
            this.查询所有成绩ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询所有成绩ToolStripMenuItem.Text = "查询所有成绩";
            this.查询所有成绩ToolStripMenuItem.Click += new System.EventHandler(this.查询所有成绩ToolStripMenuItem_Click);
            // 
            // 个人成绩查询ToolStripMenuItem
            // 
            this.个人成绩查询ToolStripMenuItem.Name = "个人成绩查询ToolStripMenuItem";
            this.个人成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.个人成绩查询ToolStripMenuItem.Text = "个人成绩查询";
            this.个人成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.个人成绩查询ToolStripMenuItem_Click);
            // 
            // 账号管理ToolStripMenuItem
            // 
            this.账号管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem2});
            this.账号管理ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.账号管理ToolStripMenuItem.Name = "账号管理ToolStripMenuItem";
            this.账号管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.账号管理ToolStripMenuItem.Text = "账号管理";
            // 
            // 修改密码ToolStripMenuItem2
            // 
            this.修改密码ToolStripMenuItem2.Name = "修改密码ToolStripMenuItem2";
            this.修改密码ToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.修改密码ToolStripMenuItem2.Text = "修改密码";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // stumnue
            // 
            this.stumnue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩查询ToolStripMenuItem1,
            this.账号管理ToolStripMenuItem1,
            this.退出登录ToolStripMenuItem1});
            this.stumnue.Location = new System.Drawing.Point(0, 0);
            this.stumnue.Name = "stumnue";
            this.stumnue.Size = new System.Drawing.Size(1008, 25);
            this.stumnue.TabIndex = 2;
            this.stumnue.Text = "menuStrip3";
            // 
            // 成绩查询ToolStripMenuItem1
            // 
            this.成绩查询ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人成绩查询ToolStripMenuItem1});
            this.成绩查询ToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkRed;
            this.成绩查询ToolStripMenuItem1.Name = "成绩查询ToolStripMenuItem1";
            this.成绩查询ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.成绩查询ToolStripMenuItem1.Text = "成绩查询";
            // 
            // 个人成绩查询ToolStripMenuItem1
            // 
            this.个人成绩查询ToolStripMenuItem1.Name = "个人成绩查询ToolStripMenuItem1";
            this.个人成绩查询ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.个人成绩查询ToolStripMenuItem1.Text = "个人成绩查询";
            this.个人成绩查询ToolStripMenuItem1.Click += new System.EventHandler(this.个人成绩查询ToolStripMenuItem1_Click);
            // 
            // 账号管理ToolStripMenuItem1
            // 
            this.账号管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem1});
            this.账号管理ToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkRed;
            this.账号管理ToolStripMenuItem1.Name = "账号管理ToolStripMenuItem1";
            this.账号管理ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.账号管理ToolStripMenuItem1.Text = "账号管理";
            // 
            // 修改密码ToolStripMenuItem1
            // 
            this.修改密码ToolStripMenuItem1.Name = "修改密码ToolStripMenuItem1";
            this.修改密码ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.修改密码ToolStripMenuItem1.Text = "修改密码";
            // 
            // 退出登录ToolStripMenuItem1
            // 
            this.退出登录ToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkRed;
            this.退出登录ToolStripMenuItem1.Name = "退出登录ToolStripMenuItem1";
            this.退出登录ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem1.Text = "退出登录";
            this.退出登录ToolStripMenuItem1.Click += new System.EventHandler(this.退出登录ToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(413, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "欢迎使用学生成绩管理系统v1.0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.学号,
            this.课程归属,
            this.课程名,
            this.成绩,
            this.姓名});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(31, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(943, 38);
            this.dataGridView1.TabIndex = 4;
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Width = 150;
            // 
            // 学号
            // 
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            this.学号.ReadOnly = true;
            this.学号.Width = 150;
            // 
            // 课程归属
            // 
            this.课程归属.HeaderText = "课程归属";
            this.课程归属.Name = "课程归属";
            this.课程归属.ReadOnly = true;
            this.课程归属.Width = 150;
            // 
            // 课程名
            // 
            this.课程名.HeaderText = "课程名";
            this.课程名.Name = "课程名";
            this.课程名.ReadOnly = true;
            this.课程名.Width = 150;
            // 
            // 成绩
            // 
            this.成绩.HeaderText = "成绩";
            this.成绩.Name = "成绩";
            this.成绩.ReadOnly = true;
            this.成绩.Width = 150;
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            this.姓名.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "请输入要审核的用户名：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(357, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "通过审核";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // daishenghe
            // 
            this.daishenghe.BackColor = System.Drawing.Color.Transparent;
            this.daishenghe.Controls.Add(this.label3);
            this.daishenghe.Controls.Add(this.textBox1);
            this.daishenghe.Controls.Add(this.label2);
            this.daishenghe.Controls.Add(this.button1);
            this.daishenghe.Location = new System.Drawing.Point(31, 122);
            this.daishenghe.Name = "daishenghe";
            this.daishenghe.Size = new System.Drawing.Size(943, 68);
            this.daishenghe.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(479, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(31, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(943, 45);
            this.dataGridView2.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "用户名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "密码";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "身份";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "学号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "班级";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(31, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 79);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(357, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "删除用户";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(479, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "请输入要删除的用户名：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // GeRenChengji_op
            // 
            this.GeRenChengji_op.BackColor = System.Drawing.Color.Transparent;
            this.GeRenChengji_op.Controls.Add(this.StuNum_in);
            this.GeRenChengji_op.Controls.Add(this.Search_TS);
            this.GeRenChengji_op.Controls.Add(this.label6);
            this.GeRenChengji_op.Location = new System.Drawing.Point(31, 282);
            this.GeRenChengji_op.Name = "GeRenChengji_op";
            this.GeRenChengji_op.Size = new System.Drawing.Size(943, 100);
            this.GeRenChengji_op.TabIndex = 12;
            // 
            // StuNum_in
            // 
            this.StuNum_in.Location = new System.Drawing.Point(357, 34);
            this.StuNum_in.Name = "StuNum_in";
            this.StuNum_in.Size = new System.Drawing.Size(100, 21);
            this.StuNum_in.TabIndex = 7;
            this.StuNum_in.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StuNum_in_KeyUp);
            // 
            // Search_TS
            // 
            this.Search_TS.AutoSize = true;
            this.Search_TS.ForeColor = System.Drawing.Color.White;
            this.Search_TS.Location = new System.Drawing.Point(479, 38);
            this.Search_TS.Name = "Search_TS";
            this.Search_TS.Size = new System.Drawing.Size(41, 12);
            this.Search_TS.TabIndex = 9;
            this.Search_TS.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(224, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "请输入学号：";
            // 
            // ZhuChaiDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.GeRenChengji_op);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.daishenghe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminmnue);
            this.Controls.Add(this.teamnue);
            this.Controls.Add(this.stumnue);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.MainMenuStrip = this.adminmnue;
            this.Name = "ZhuChaiDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主菜单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZhuChaiDan_Closing);
            this.Load += new System.EventHandler(this.ZhuChaiDan_Load);
            this.adminmnue.ResumeLayout(false);
            this.adminmnue.PerformLayout();
            this.teamnue.ResumeLayout(false);
            this.teamnue.PerformLayout();
            this.stumnue.ResumeLayout(false);
            this.stumnue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.daishenghe.ResumeLayout(false);
            this.daishenghe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GeRenChengji_op.ResumeLayout(false);
            this.GeRenChengji_op.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip adminmnue;
        private System.Windows.Forms.ToolStripMenuItem 审核管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 待审核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 审核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip teamnue;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询所有成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip stumnue;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 个人成绩查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 账号管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程归属;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel daishenghe;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel GeRenChengji_op;
        private System.Windows.Forms.TextBox StuNum_in;
        private System.Windows.Forms.Label Search_TS;
        private System.Windows.Forms.Label label6;
    }
}

