namespace Password.Main.PassWordForm
{
    partial class AddAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountForm));
            this.label4 = new System.Windows.Forms.Label();
            this.ADD_Account_Retion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ADD_Account_Remark = new System.Windows.Forms.TextBox();
            this.ADD_TEL_PassWord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ADD_TEL_UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ADD_Account_Name = new System.Windows.Forms.TextBox();
            this.Cell_btn_ADD_Password = new System.Windows.Forms.Button();
            this.OK_btn_ADD_Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("SketchFlow Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(59, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "ADD.AccountPasswords";
            // 
            // ADD_Account_Retion
            // 
            this.ADD_Account_Retion.FormattingEnabled = true;
            this.ADD_Account_Retion.Items.AddRange(new object[] {
            "未填",
            "QQ",
            "邮箱",
            "登录密码",
            "卡",
            "浏览器",
            "游戏"});
            this.ADD_Account_Retion.Location = new System.Drawing.Point(142, 112);
            this.ADD_Account_Retion.Name = "ADD_Account_Retion";
            this.ADD_Account_Retion.Size = new System.Drawing.Size(134, 20);
            this.ADD_Account_Retion.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "备注：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "用户名密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "类型：";
            // 
            // ADD_Account_Remark
            // 
            this.ADD_Account_Remark.Location = new System.Drawing.Point(142, 192);
            this.ADD_Account_Remark.Multiline = true;
            this.ADD_Account_Remark.Name = "ADD_Account_Remark";
            this.ADD_Account_Remark.Size = new System.Drawing.Size(278, 87);
            this.ADD_Account_Remark.TabIndex = 39;
            // 
            // ADD_TEL_PassWord
            // 
            this.ADD_TEL_PassWord.Location = new System.Drawing.Point(142, 165);
            this.ADD_TEL_PassWord.Name = "ADD_TEL_PassWord";
            this.ADD_TEL_PassWord.Size = new System.Drawing.Size(153, 21);
            this.ADD_TEL_PassWord.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "用户名账号：";
            // 
            // ADD_TEL_UserName
            // 
            this.ADD_TEL_UserName.Location = new System.Drawing.Point(142, 140);
            this.ADD_TEL_UserName.Name = "ADD_TEL_UserName";
            this.ADD_TEL_UserName.Size = new System.Drawing.Size(162, 21);
            this.ADD_TEL_UserName.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "名称：";
            // 
            // ADD_Account_Name
            // 
            this.ADD_Account_Name.Location = new System.Drawing.Point(142, 84);
            this.ADD_Account_Name.Name = "ADD_Account_Name";
            this.ADD_Account_Name.Size = new System.Drawing.Size(242, 21);
            this.ADD_Account_Name.TabIndex = 40;
            // 
            // Cell_btn_ADD_Password
            // 
            this.Cell_btn_ADD_Password.Location = new System.Drawing.Point(284, 308);
            this.Cell_btn_ADD_Password.Name = "Cell_btn_ADD_Password";
            this.Cell_btn_ADD_Password.Size = new System.Drawing.Size(75, 23);
            this.Cell_btn_ADD_Password.TabIndex = 42;
            this.Cell_btn_ADD_Password.Text = "取消";
            this.Cell_btn_ADD_Password.UseVisualStyleBackColor = true;
            this.Cell_btn_ADD_Password.Click += new System.EventHandler(this.Cell_btn_ADD_Password_Click);
            // 
            // OK_btn_ADD_Password
            // 
            this.OK_btn_ADD_Password.Location = new System.Drawing.Point(113, 308);
            this.OK_btn_ADD_Password.Name = "OK_btn_ADD_Password";
            this.OK_btn_ADD_Password.Size = new System.Drawing.Size(75, 23);
            this.OK_btn_ADD_Password.TabIndex = 43;
            this.OK_btn_ADD_Password.Text = "提交添加";
            this.OK_btn_ADD_Password.UseVisualStyleBackColor = true;
            this.OK_btn_ADD_Password.Click += new System.EventHandler(this.OK_btn_ADD_Password_Click);
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 394);
            this.Controls.Add(this.Cell_btn_ADD_Password);
            this.Controls.Add(this.OK_btn_ADD_Password);
            this.Controls.Add(this.ADD_Account_Retion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ADD_Account_Remark);
            this.Controls.Add(this.ADD_TEL_PassWord);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ADD_TEL_UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ADD_Account_Name);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加账号信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationExit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ADD_Account_Retion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ADD_Account_Remark;
        private System.Windows.Forms.TextBox ADD_TEL_PassWord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ADD_TEL_UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ADD_Account_Name;
        private System.Windows.Forms.Button Cell_btn_ADD_Password;
        private System.Windows.Forms.Button OK_btn_ADD_Password;
    }
}