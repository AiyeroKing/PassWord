namespace Password
{
    partial class PasswordMunes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordMunes));
            this.LOGIN_laying = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LOGIN_laying)).BeginInit();
            this.SuspendLayout();
            // 
            // LOGIN_laying
            // 
            this.LOGIN_laying.InitialImage = ((System.Drawing.Image)(resources.GetObject("LOGIN_laying.InitialImage")));
            this.LOGIN_laying.Location = new System.Drawing.Point(166, 50);
            this.LOGIN_laying.Name = "LOGIN_laying";
            this.LOGIN_laying.Size = new System.Drawing.Size(156, 84);
            this.LOGIN_laying.TabIndex = 0;
            this.LOGIN_laying.TabStop = false;
            // 
            // PasswordMunes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 208);
            this.Controls.Add(this.LOGIN_laying);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordMunes";
            this.Text = "登录等待";
            ((System.ComponentModel.ISupportInitialize)(this.LOGIN_laying)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LOGIN_laying;
    }
}