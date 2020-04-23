namespace WorkShop
{
    partial class LoginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button buttonSignIn;
            System.Windows.Forms.Button btnRegister;
            this.picBoxCenter = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            buttonSignIn = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = System.Drawing.Color.Snow;
            buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            buttonSignIn.FlatAppearance.BorderSize = 0;
            buttonSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSignIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonSignIn.Location = new System.Drawing.Point(43, 239);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new System.Drawing.Size(235, 35);
            buttonSignIn.TabIndex = 14;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseCompatibleTextRendering = true;
            buttonSignIn.UseMnemonic = false;
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnRegister.Location = new System.Drawing.Point(43, 298);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(235, 35);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Register";
            btnRegister.UseCompatibleTextRendering = true;
            btnRegister.UseMnemonic = false;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // picBoxCenter
            // 
            this.picBoxCenter.Image = global::WorkShop.Properties.Resources.iconfinder_tools_fix_repair_wrench_mechanic_3802001;
            this.picBoxCenter.Location = new System.Drawing.Point(108, 12);
            this.picBoxCenter.Name = "picBoxCenter";
            this.picBoxCenter.Size = new System.Drawing.Size(100, 100);
            this.picBoxCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCenter.TabIndex = 0;
            this.picBoxCenter.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::WorkShop.Properties.Resources.iconfinder_00_ELASTOFONT_STORE_READY_user_circle_2703062;
            this.pictureBoxUser.Location = new System.Drawing.Point(43, 128);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WorkShop.Properties.Resources.iconfinder_Facebook_194929;
            this.pictureBox3.Location = new System.Drawing.Point(72, 375);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxUsername.Location = new System.Drawing.Point(73, 136);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(205, 18);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(123, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login with";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(43, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 2);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(43, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 2);
            this.panel2.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassword.Location = new System.Drawing.Point(73, 185);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(205, 18);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::WorkShop.Properties.Resources.iconfinder_Password_372910;
            this.pictureBoxPassword.Location = new System.Drawing.Point(43, 177);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassword.TabIndex = 8;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WorkShop.Properties.Resources.iconfinder_Google__194926;
            this.pictureBox4.Location = new System.Drawing.Point(195, 375);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(320, 452);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(btnRegister);
            this.Controls.Add(buttonSignIn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.picBoxCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "LoginForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCenter;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

