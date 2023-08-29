namespace pwm_v1
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblUserEmail = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblConfirm_Password = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_UserEmail = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_Confirm_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnRegister.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(128, 635);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(219, 70);
            this.BtnRegister.TabIndex = 15;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnClear.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(496, 635);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(219, 70);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBack.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(841, 635);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(219, 70);
            this.BtnBack.TabIndex = 17;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblUserName.Location = new System.Drawing.Point(83, 105);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(138, 39);
            this.LblUserName.TabIndex = 18;
            this.LblUserName.Text = "User Name";
            // 
            // LblUserEmail
            // 
            this.LblUserEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserEmail.AutoSize = true;
            this.LblUserEmail.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblUserEmail.Location = new System.Drawing.Point(83, 215);
            this.LblUserEmail.Name = "LblUserEmail";
            this.LblUserEmail.Size = new System.Drawing.Size(135, 39);
            this.LblUserEmail.TabIndex = 19;
            this.LblUserEmail.Text = "User Email";
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPassword.Location = new System.Drawing.Point(83, 326);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(129, 39);
            this.LblPassword.TabIndex = 20;
            this.LblPassword.Text = "Password";
            // 
            // LblConfirm_Password
            // 
            this.LblConfirm_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblConfirm_Password.AutoSize = true;
            this.LblConfirm_Password.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirm_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblConfirm_Password.Location = new System.Drawing.Point(83, 454);
            this.LblConfirm_Password.Name = "LblConfirm_Password";
            this.LblConfirm_Password.Size = new System.Drawing.Size(129, 78);
            this.LblConfirm_Password.TabIndex = 21;
            this.LblConfirm_Password.Text = "Confirm\r\nPassword";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserName.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserName.ForeColor = System.Drawing.Color.Silver;
            this.Txt_UserName.Location = new System.Drawing.Point(342, 105);
            this.Txt_UserName.Multiline = true;
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(718, 39);
            this.Txt_UserName.TabIndex = 22;
            this.Txt_UserName.Text = "Ex:User Name";
            this.Txt_UserName.Enter += new System.EventHandler(this.Txt_UserName_Enter);
            this.Txt_UserName.Leave += new System.EventHandler(this.Txt_UserName_Leave);
            // 
            // Txt_UserEmail
            // 
            this.Txt_UserEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserEmail.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserEmail.ForeColor = System.Drawing.Color.Silver;
            this.Txt_UserEmail.Location = new System.Drawing.Point(342, 215);
            this.Txt_UserEmail.Multiline = true;
            this.Txt_UserEmail.Name = "Txt_UserEmail";
            this.Txt_UserEmail.Size = new System.Drawing.Size(718, 39);
            this.Txt_UserEmail.TabIndex = 23;
            this.Txt_UserEmail.Text = "Ex:Someone@Company.Com";
            this.Txt_UserEmail.Enter += new System.EventHandler(this.Txt_UserEmail_Enter);
            this.Txt_UserEmail.Leave += new System.EventHandler(this.Txt_UserEmail_Leave);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Password.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.ForeColor = System.Drawing.Color.Silver;
            this.Txt_Password.Location = new System.Drawing.Point(342, 331);
            this.Txt_Password.Multiline = true;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(718, 39);
            this.Txt_Password.TabIndex = 24;
            this.Txt_Password.Text = "Ex:**********Password";
            this.Txt_Password.Enter += new System.EventHandler(this.Txt_Password_Enter);
            this.Txt_Password.Leave += new System.EventHandler(this.Txt_Password_Leave);
            // 
            // Txt_Confirm_Password
            // 
            this.Txt_Confirm_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Confirm_Password.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Confirm_Password.ForeColor = System.Drawing.Color.Silver;
            this.Txt_Confirm_Password.Location = new System.Drawing.Point(342, 483);
            this.Txt_Confirm_Password.Multiline = true;
            this.Txt_Confirm_Password.Name = "Txt_Confirm_Password";
            this.Txt_Confirm_Password.Size = new System.Drawing.Size(718, 39);
            this.Txt_Confirm_Password.TabIndex = 25;
            this.Txt_Confirm_Password.Text = "Ex:**********Confirm Password";
            this.Txt_Confirm_Password.Enter += new System.EventHandler(this.Txt_Confirm_Password_Enter);
            this.Txt_Confirm_Password.Leave += new System.EventHandler(this.Txt_Confirm_Password_Leave);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(143)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.Txt_Confirm_Password);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserEmail);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.LblConfirm_Password);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserEmail);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Registration";
            this.Text = "REGISTRATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblUserEmail;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblConfirm_Password;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.TextBox Txt_UserEmail;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_Confirm_Password;
    }
}