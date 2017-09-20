using System.Windows.Forms;

namespace Password
{
    partial class PassMenusOne
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassMenusOne));
            this.Ok_button = new System.Windows.Forms.Button();
            this.Esc_button = new System.Windows.Forms.Button();
            this.MiYao_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ok_button
            // 
            this.Ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok_button.Location = new System.Drawing.Point(169, 191);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(75, 25);
            this.Ok_button.TabIndex = 0;
            this.Ok_button.Text = "确定";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // Esc_button
            // 
            this.Esc_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Esc_button.Location = new System.Drawing.Point(336, 191);
            this.Esc_button.Name = "Esc_button";
            this.Esc_button.Size = new System.Drawing.Size(75, 23);
            this.Esc_button.TabIndex = 0;
            this.Esc_button.Text = "退出";
            this.Esc_button.UseVisualStyleBackColor = true;
            this.Esc_button.Click += new System.EventHandler(this.Esc_button_Click);
            // 
            // MiYao_input
            // 
            this.MiYao_input.Location = new System.Drawing.Point(245, 108);
            this.MiYao_input.Name = "MiYao_input";
            this.MiYao_input.PasswordChar = '*';
            this.MiYao_input.Size = new System.Drawing.Size(224, 21);
            this.MiYao_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(114, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入秘钥";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("方正姚体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(71, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "账 号 密 码 登 陆 密 钥 输 入";
            // 
            // PassMenusOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MiYao_input);
            this.Controls.Add(this.Esc_button);
            this.Controls.Add(this.Ok_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "PassMenusOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通行证";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationExit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Button Esc_button;
        private System.Windows.Forms.TextBox MiYao_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

