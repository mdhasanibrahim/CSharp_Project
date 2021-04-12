namespace loadingframe
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Passwordpicture = new System.Windows.Forms.PictureBox();
            this.Usernamepiture = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new MetroFramework.Controls.MetroButton();
            this.btnLogIn = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelLogin = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Passwordpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usernamepiture)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = global::loadingframe.Properties.Resources.LogInFrame2;
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel2.Controls.Add(this.metroPanel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroPanel2.Location = new System.Drawing.Point(0, 35);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(622, 715);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = true;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.Passwordpicture);
            this.metroPanel1.Controls.Add(this.Usernamepiture);
            this.metroPanel1.Controls.Add(this.btnSignUp);
            this.metroPanel1.Controls.Add(this.btnLogIn);
            this.metroPanel1.Controls.Add(this.metroTextBoxPassword);
            this.metroPanel1.Controls.Add(this.metroTextBoxUsername);
            this.metroPanel1.Controls.Add(this.metroLabelLogin);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(121, 134);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(340, 448);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = true;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Passwordpicture
            // 
            this.Passwordpicture.Image = ((System.Drawing.Image)(resources.GetObject("Passwordpicture.Image")));
            this.Passwordpicture.Location = new System.Drawing.Point(65, 193);
            this.Passwordpicture.Name = "Passwordpicture";
            this.Passwordpicture.Size = new System.Drawing.Size(32, 33);
            this.Passwordpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Passwordpicture.TabIndex = 8;
            this.Passwordpicture.TabStop = false;
            // 
            // Usernamepiture
            // 
            this.Usernamepiture.Image = ((System.Drawing.Image)(resources.GetObject("Usernamepiture.Image")));
            this.Usernamepiture.Location = new System.Drawing.Point(65, 116);
            this.Usernamepiture.Name = "Usernamepiture";
            this.Usernamepiture.Size = new System.Drawing.Size(32, 33);
            this.Usernamepiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Usernamepiture.TabIndex = 7;
            this.Usernamepiture.TabStop = false;
            this.Usernamepiture.UseWaitCursor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignUp.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignUp.Location = new System.Drawing.Point(182, 274);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 32);
            this.btnSignUp.Style = MetroFramework.MetroColorStyle.White;
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseCustomBackColor = true;
            this.btnSignUp.UseCustomForeColor = true;
            this.btnSignUp.UseSelectable = true;
            this.btnSignUp.Click += new System.EventHandler(this.metrobtnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(65, 274);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(99, 32);
            this.btnLogIn.Style = MetroFramework.MetroColorStyle.White;
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseCustomBackColor = true;
            this.btnLogIn.UseCustomForeColor = true;
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.UseWaitCursor = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBoxPassword.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(94, 193);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.PromptText = "********";
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(217, 33);
            this.metroTextBoxPassword.TabIndex = 4;
            this.metroTextBoxPassword.UseCustomBackColor = true;
            this.metroTextBoxPassword.UseCustomForeColor = true;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMark = "********";
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.Silver;
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBoxUsername
            // 
            this.metroTextBoxUsername.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.metroTextBoxUsername.CustomButton.Image = null;
            this.metroTextBoxUsername.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.metroTextBoxUsername.CustomButton.Name = "";
            this.metroTextBoxUsername.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUsername.CustomButton.TabIndex = 1;
            this.metroTextBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUsername.CustomButton.UseSelectable = true;
            this.metroTextBoxUsername.CustomButton.UseWaitCursor = true;
            this.metroTextBoxUsername.CustomButton.Visible = false;
            this.metroTextBoxUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxUsername.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBoxUsername.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxUsername.Lines = new string[0];
            this.metroTextBoxUsername.Location = new System.Drawing.Point(94, 116);
            this.metroTextBoxUsername.MaxLength = 32767;
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.PasswordChar = '\0';
            this.metroTextBoxUsername.PromptText = "Username";
            this.metroTextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUsername.SelectedText = "";
            this.metroTextBoxUsername.SelectionLength = 0;
            this.metroTextBoxUsername.SelectionStart = 0;
            this.metroTextBoxUsername.ShortcutsEnabled = true;
            this.metroTextBoxUsername.Size = new System.Drawing.Size(217, 33);
            this.metroTextBoxUsername.Style = MetroFramework.MetroColorStyle.White;
            this.metroTextBoxUsername.TabIndex = 3;
            this.metroTextBoxUsername.UseCustomBackColor = true;
            this.metroTextBoxUsername.UseCustomForeColor = true;
            this.metroTextBoxUsername.UseSelectable = true;
            this.metroTextBoxUsername.WaterMark = "Username";
            this.metroTextBoxUsername.WaterMarkColor = System.Drawing.Color.Silver;
            this.metroTextBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabelLogin
            // 
            this.metroLabelLogin.AutoSize = true;
            this.metroLabelLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelLogin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelLogin.ForeColor = System.Drawing.Color.White;
            this.metroLabelLogin.Location = new System.Drawing.Point(139, 27);
            this.metroLabelLogin.Name = "metroLabelLogin";
            this.metroLabelLogin.Size = new System.Drawing.Size(76, 25);
            this.metroLabelLogin.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabelLogin.TabIndex = 2;
            this.metroLabelLogin.Text = "LOG IN";
            this.metroLabelLogin.UseCustomBackColor = true;
            this.metroLabelLogin.UseCustomForeColor = true;
            this.metroLabelLogin.UseStyleColors = true;
            this.metroLabelLogin.UseWaitCursor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 750);
            this.Controls.Add(this.metroPanel2);
            this.Name = "LoginForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Passwordpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usernamepiture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSignUp;
        private MetroFramework.Controls.MetroButton btnLogIn;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
        private MetroFramework.Controls.MetroLabel metroLabelLogin;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox Passwordpicture;
        private System.Windows.Forms.PictureBox Usernamepiture;
    }
}