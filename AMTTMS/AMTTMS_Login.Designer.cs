namespace AMTTMS
{
    partial class AMTTMS_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMTTMS_Login));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_userpass = new System.Windows.Forms.TextBox();
            this.btn_regist = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_forget = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(156, 121);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(190, 21);
            this.txt_username.TabIndex = 0;
            // 
            // txt_userpass
            // 
            this.txt_userpass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_userpass.Location = new System.Drawing.Point(156, 161);
            this.txt_userpass.Name = "txt_userpass";
            this.txt_userpass.PasswordChar = '*';
            this.txt_userpass.Size = new System.Drawing.Size(190, 21);
            this.txt_userpass.TabIndex = 1;
            // 
            // btn_regist
            // 
            this.btn_regist.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_regist.Image = global::AMTTMS.Properties.Resources.AMTTMS_button2;
            this.btn_regist.Location = new System.Drawing.Point(97, 212);
            this.btn_regist.Name = "btn_regist";
            this.btn_regist.Size = new System.Drawing.Size(75, 23);
            this.btn_regist.TabIndex = 2;
            this.btn_regist.Text = "团员注册";
            this.btn_regist.UseVisualStyleBackColor = true;
            this.btn_regist.Click += new System.EventHandler(this.btn_regist_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Image = global::AMTTMS.Properties.Resources.AMTTMS_button2;
            this.btn_login.Location = new System.Drawing.Point(231, 212);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "团员登陆";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_forget
            // 
            this.btn_forget.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_forget.Image = global::AMTTMS.Properties.Resources.AMTTMS_button2;
            this.btn_forget.Location = new System.Drawing.Point(97, 256);
            this.btn_forget.Name = "btn_forget";
            this.btn_forget.Size = new System.Drawing.Size(75, 23);
            this.btn_forget.TabIndex = 4;
            this.btn_forget.Text = "忘记密码";
            this.btn_forget.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.Image = global::AMTTMS.Properties.Resources.AMTTMS_button2;
            this.btn_cancel.Location = new System.Drawing.Point(231, 256);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "退出系统";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AMTTMS_Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AMTTMS.Properties.Resources.AMTTMS_background_modify2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(408, 315);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_forget);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_regist);
            this.Controls.Add(this.txt_userpass);
            this.Controls.Add(this.txt_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AMTTMS_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AM技术组";
            this.Load += new System.EventHandler(this.AMTTMS_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_userpass;
        private System.Windows.Forms.Button btn_regist;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_forget;
        private System.Windows.Forms.Button btn_cancel;
    }
}

