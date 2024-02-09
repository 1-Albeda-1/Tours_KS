namespace Tours_KS.Forms.Authorization
{
    partial class AuthorizationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonEnterGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(256, 141);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(425, 39);
            this.textBoxPassword.TabIndex = 26;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(256, 52);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(425, 39);
            this.textBoxLogin.TabIndex = 25;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(565, 220);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(196, 76);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(68, 220);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(196, 76);
            this.buttonEnter.TabIndex = 29;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonEnterGuest
            // 
            this.buttonEnterGuest.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterGuest.Location = new System.Drawing.Point(319, 220);
            this.buttonEnterGuest.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEnterGuest.Name = "buttonEnterGuest";
            this.buttonEnterGuest.Size = new System.Drawing.Size(196, 76);
            this.buttonEnterGuest.TabIndex = 31;
            this.buttonEnterGuest.Text = "Войти как гость";
            this.buttonEnterGuest.UseVisualStyleBackColor = true;
            this.buttonEnterGuest.Click += new System.EventHandler(this.buttonEnterGuest_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 346);
            this.Controls.Add(this.buttonEnterGuest);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(842, 410);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonEnterGuest;
    }
}