namespace Password.Main.TelphoneForm
{
    partial class EdiotTelPhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdiotTelPhone));
            this.Ediot_TEL_Retion = new System.Windows.Forms.ComboBox();
            this.Ediot_TEL_Birthday = new System.Windows.Forms.DateTimePicker();
            this.Ediot_TEL_Sex = new System.Windows.Forms.ComboBox();
            this.Cell_btn_Ediot_Telphone = new System.Windows.Forms.Button();
            this.OK_btn_Ediot_Telphone = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ediot_TEL_Idcard = new System.Windows.Forms.TextBox();
            this.Ediot_TEL_Remark = new System.Windows.Forms.TextBox();
            this.Ediot_TEL_Address = new System.Windows.Forms.TextBox();
            this.Ediot_TEL_Company = new System.Windows.Forms.TextBox();
            this.Ediot_TEL_Email = new System.Windows.Forms.TextBox();
            this.Ediot_TEL_QQ = new System.Windows.Forms.TextBox();
            this.Ediot_TEL_Phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ediot_TEL_Telphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ediot_TEL_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ediot_TEL_Retion
            // 
            this.Ediot_TEL_Retion.FormattingEnabled = true;
            this.Ediot_TEL_Retion.Items.AddRange(new object[] {
            "普通朋友",
            "亲人",
            "兄弟",
            "爱人",
            "公司"});
            this.Ediot_TEL_Retion.Location = new System.Drawing.Point(128, 240);
            this.Ediot_TEL_Retion.Name = "Ediot_TEL_Retion";
            this.Ediot_TEL_Retion.Size = new System.Drawing.Size(121, 20);
            this.Ediot_TEL_Retion.TabIndex = 60;
            // 
            // Ediot_TEL_Birthday
            // 
            this.Ediot_TEL_Birthday.Location = new System.Drawing.Point(128, 183);
            this.Ediot_TEL_Birthday.Name = "Ediot_TEL_Birthday";
            this.Ediot_TEL_Birthday.Size = new System.Drawing.Size(200, 21);
            this.Ediot_TEL_Birthday.TabIndex = 59;
            this.Ediot_TEL_Birthday.Value = new System.DateTime(2010, 10, 10, 0, 0, 0, 0);
            // 
            // Ediot_TEL_Sex
            // 
            this.Ediot_TEL_Sex.FormattingEnabled = true;
            this.Ediot_TEL_Sex.Items.AddRange(new object[] {
            "未填",
            "男",
            "女"});
            this.Ediot_TEL_Sex.Location = new System.Drawing.Point(128, 103);
            this.Ediot_TEL_Sex.Name = "Ediot_TEL_Sex";
            this.Ediot_TEL_Sex.Size = new System.Drawing.Size(93, 20);
            this.Ediot_TEL_Sex.TabIndex = 58;
            // 
            // Cell_btn_Ediot_Telphone
            // 
            this.Cell_btn_Ediot_Telphone.Location = new System.Drawing.Point(299, 476);
            this.Cell_btn_Ediot_Telphone.Name = "Cell_btn_Ediot_Telphone";
            this.Cell_btn_Ediot_Telphone.Size = new System.Drawing.Size(75, 23);
            this.Cell_btn_Ediot_Telphone.TabIndex = 56;
            this.Cell_btn_Ediot_Telphone.Text = "取消";
            this.Cell_btn_Ediot_Telphone.UseVisualStyleBackColor = true;
            this.Cell_btn_Ediot_Telphone.Click += new System.EventHandler(this.Cell_btn_Ediot_Telphone_Click);
            // 
            // OK_btn_Ediot_Telphone
            // 
            this.OK_btn_Ediot_Telphone.Location = new System.Drawing.Point(128, 476);
            this.OK_btn_Ediot_Telphone.Name = "OK_btn_Ediot_Telphone";
            this.OK_btn_Ediot_Telphone.Size = new System.Drawing.Size(75, 23);
            this.OK_btn_Ediot_Telphone.TabIndex = 57;
            this.OK_btn_Ediot_Telphone.Text = "提交添加";
            this.OK_btn_Ediot_Telphone.UseVisualStyleBackColor = true;
            this.OK_btn_Ediot_Telphone.Click += new System.EventHandler(this.OK_btn_Ediot_Telphone_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "关系：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "身份证号码：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(81, 399);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 37;
            this.label17.Text = "备注：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(81, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 38;
            this.label15.Text = "地址：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 39;
            this.label16.Text = "公司：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 40;
            this.label14.Text = "电子邮箱：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "QQ号码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 42;
            this.label10.Text = "生日：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "手机号码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 44;
            this.label6.Text = "性别：";
            // 
            // Ediot_TEL_Idcard
            // 
            this.Ediot_TEL_Idcard.Location = new System.Drawing.Point(128, 210);
            this.Ediot_TEL_Idcard.Name = "Ediot_TEL_Idcard";
            this.Ediot_TEL_Idcard.Size = new System.Drawing.Size(278, 21);
            this.Ediot_TEL_Idcard.TabIndex = 49;
            // 
            // Ediot_TEL_Remark
            // 
            this.Ediot_TEL_Remark.Location = new System.Drawing.Point(128, 396);
            this.Ediot_TEL_Remark.Multiline = true;
            this.Ediot_TEL_Remark.Name = "Ediot_TEL_Remark";
            this.Ediot_TEL_Remark.Size = new System.Drawing.Size(295, 43);
            this.Ediot_TEL_Remark.TabIndex = 53;
            // 
            // Ediot_TEL_Address
            // 
            this.Ediot_TEL_Address.Location = new System.Drawing.Point(128, 345);
            this.Ediot_TEL_Address.Multiline = true;
            this.Ediot_TEL_Address.Name = "Ediot_TEL_Address";
            this.Ediot_TEL_Address.Size = new System.Drawing.Size(295, 45);
            this.Ediot_TEL_Address.TabIndex = 52;
            // 
            // Ediot_TEL_Company
            // 
            this.Ediot_TEL_Company.Location = new System.Drawing.Point(128, 318);
            this.Ediot_TEL_Company.Name = "Ediot_TEL_Company";
            this.Ediot_TEL_Company.Size = new System.Drawing.Size(246, 21);
            this.Ediot_TEL_Company.TabIndex = 51;
            // 
            // Ediot_TEL_Email
            // 
            this.Ediot_TEL_Email.Location = new System.Drawing.Point(128, 291);
            this.Ediot_TEL_Email.Name = "Ediot_TEL_Email";
            this.Ediot_TEL_Email.Size = new System.Drawing.Size(218, 21);
            this.Ediot_TEL_Email.TabIndex = 50;
            // 
            // Ediot_TEL_QQ
            // 
            this.Ediot_TEL_QQ.Location = new System.Drawing.Point(128, 264);
            this.Ediot_TEL_QQ.Name = "Ediot_TEL_QQ";
            this.Ediot_TEL_QQ.Size = new System.Drawing.Size(134, 21);
            this.Ediot_TEL_QQ.TabIndex = 54;
            // 
            // Ediot_TEL_Phone
            // 
            this.Ediot_TEL_Phone.Location = new System.Drawing.Point(128, 156);
            this.Ediot_TEL_Phone.Name = "Ediot_TEL_Phone";
            this.Ediot_TEL_Phone.Size = new System.Drawing.Size(150, 21);
            this.Ediot_TEL_Phone.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 46;
            this.label7.Text = "电话号码：";
            // 
            // Ediot_TEL_Telphone
            // 
            this.Ediot_TEL_Telphone.Location = new System.Drawing.Point(128, 131);
            this.Ediot_TEL_Telphone.Name = "Ediot_TEL_Telphone";
            this.Ediot_TEL_Telphone.Size = new System.Drawing.Size(134, 21);
            this.Ediot_TEL_Telphone.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "姓名：";
            // 
            // Ediot_TEL_Name
            // 
            this.Ediot_TEL_Name.Location = new System.Drawing.Point(128, 75);
            this.Ediot_TEL_Name.Name = "Ediot_TEL_Name";
            this.Ediot_TEL_Name.Size = new System.Drawing.Size(110, 21);
            this.Ediot_TEL_Name.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("SketchFlow Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(121, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Edoit.Telphone";
            // 
            // EdiotTelPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 528);
            this.Controls.Add(this.Ediot_TEL_Retion);
            this.Controls.Add(this.Ediot_TEL_Birthday);
            this.Controls.Add(this.Ediot_TEL_Sex);
            this.Controls.Add(this.Cell_btn_Ediot_Telphone);
            this.Controls.Add(this.OK_btn_Ediot_Telphone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ediot_TEL_Idcard);
            this.Controls.Add(this.Ediot_TEL_Remark);
            this.Controls.Add(this.Ediot_TEL_Address);
            this.Controls.Add(this.Ediot_TEL_Company);
            this.Controls.Add(this.Ediot_TEL_Email);
            this.Controls.Add(this.Ediot_TEL_QQ);
            this.Controls.Add(this.Ediot_TEL_Phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ediot_TEL_Telphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ediot_TEL_Name);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdiotTelPhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑通讯录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationExit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Ediot_TEL_Retion;
        private System.Windows.Forms.DateTimePicker Ediot_TEL_Birthday;
        private System.Windows.Forms.ComboBox Ediot_TEL_Sex;
        private System.Windows.Forms.Button Cell_btn_Ediot_Telphone;
        private System.Windows.Forms.Button OK_btn_Ediot_Telphone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ediot_TEL_Idcard;
        private System.Windows.Forms.TextBox Ediot_TEL_Remark;
        private System.Windows.Forms.TextBox Ediot_TEL_Address;
        private System.Windows.Forms.TextBox Ediot_TEL_Company;
        private System.Windows.Forms.TextBox Ediot_TEL_Email;
        private System.Windows.Forms.TextBox Ediot_TEL_QQ;
        private System.Windows.Forms.TextBox Ediot_TEL_Phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Ediot_TEL_Telphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ediot_TEL_Name;
        private System.Windows.Forms.Label label4;
    }
}