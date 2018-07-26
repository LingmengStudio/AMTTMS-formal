namespace AMTTMS
{
    partial class AMTTMS_Regist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMTTMS_Regist));
            this.txt_regist_name = new System.Windows.Forms.TextBox();
            this.txt_regist_pass = new System.Windows.Forms.TextBox();
            this.txt_regist_gameid = new System.Windows.Forms.TextBox();
            this.txt_regist_gamename = new System.Windows.Forms.TextBox();
            this.btn_user_regist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_regist_name
            // 
            this.txt_regist_name.Location = new System.Drawing.Point(427, 140);
            this.txt_regist_name.Name = "txt_regist_name";
            this.txt_regist_name.Size = new System.Drawing.Size(170, 21);
            this.txt_regist_name.TabIndex = 0;
            // 
            // txt_regist_pass
            // 
            this.txt_regist_pass.Location = new System.Drawing.Point(427, 188);
            this.txt_regist_pass.Name = "txt_regist_pass";
            this.txt_regist_pass.PasswordChar = '*';
            this.txt_regist_pass.Size = new System.Drawing.Size(170, 21);
            this.txt_regist_pass.TabIndex = 1;
            // 
            // txt_regist_gameid
            // 
            this.txt_regist_gameid.Location = new System.Drawing.Point(427, 233);
            this.txt_regist_gameid.Name = "txt_regist_gameid";
            this.txt_regist_gameid.Size = new System.Drawing.Size(170, 21);
            this.txt_regist_gameid.TabIndex = 2;
            // 
            // txt_regist_gamename
            // 
            this.txt_regist_gamename.Location = new System.Drawing.Point(427, 279);
            this.txt_regist_gamename.Name = "txt_regist_gamename";
            this.txt_regist_gamename.Size = new System.Drawing.Size(170, 21);
            this.txt_regist_gamename.TabIndex = 3;
            // 
            // btn_user_regist
            // 
            this.btn_user_regist.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_user_regist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_user_regist.Image = global::AMTTMS.Properties.Resources.AMTTMS_button2;
            this.btn_user_regist.Location = new System.Drawing.Point(386, 304);
            this.btn_user_regist.Name = "btn_user_regist";
            this.btn_user_regist.Size = new System.Drawing.Size(140, 40);
            this.btn_user_regist.TabIndex = 4;
            this.btn_user_regist.Text = "用户注册";
            this.btn_user_regist.UseVisualStyleBackColor = true;
            this.btn_user_regist.Click += new System.EventHandler(this.btn_user_regist_Click);
            // 
            // AMTTMS_Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AMTTMS.Properties.Resources.AMTTMS_Regist_Background_modify4;
            this.ClientSize = new System.Drawing.Size(623, 347);
            this.Controls.Add(this.btn_user_regist);
            this.Controls.Add(this.txt_regist_gamename);
            this.Controls.Add(this.txt_regist_gameid);
            this.Controls.Add(this.txt_regist_pass);
            this.Controls.Add(this.txt_regist_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AMTTMS_Regist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AM技术组";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_regist_name;
        private System.Windows.Forms.TextBox txt_regist_pass;
        private System.Windows.Forms.TextBox txt_regist_gameid;
        private System.Windows.Forms.TextBox txt_regist_gamename;
        private System.Windows.Forms.Button btn_user_regist;
    }
}