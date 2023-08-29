namespace pwm_v1
{
    partial class APPLICATION_CHANGEACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APPLICATION_CHANGEACCOUNT));
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.LblApplication_Name = new System.Windows.Forms.Label();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtApplication_Name = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.Lbl_Password.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Password.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Lbl_Password.Location = new System.Drawing.Point(87, 381);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(141, 39);
            this.Lbl_Password.TabIndex = 34;
            this.Lbl_Password.Text = "PASSWORD";
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.Lbl_UserName.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserName.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Lbl_UserName.Location = new System.Drawing.Point(87, 281);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(142, 39);
            this.Lbl_UserName.TabIndex = 33;
            this.Lbl_UserName.Text = "USER NAME";
            // 
            // LblApplication_Name
            // 
            this.LblApplication_Name.AutoSize = true;
            this.LblApplication_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblApplication_Name.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplication_Name.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblApplication_Name.Location = new System.Drawing.Point(87, 186);
            this.LblApplication_Name.Name = "LblApplication_Name";
            this.LblApplication_Name.Size = new System.Drawing.Size(221, 39);
            this.LblApplication_Name.TabIndex = 32;
            this.LblApplication_Name.Text = "APPLICATION NAME";
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.MediumVioletRed;
            this.IbtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(5, 5);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(70, 55);
            this.IbtnBack.TabIndex = 42;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(272, 631);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(204, 57);
            this.BtnUpdate.TabIndex = 40;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(671, 631);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(204, 57);
            this.BtnClear.TabIndex = 41;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtApplication_Name
            // 
            this.TxtApplication_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApplication_Name.ForeColor = System.Drawing.Color.Silver;
            this.TxtApplication_Name.Location = new System.Drawing.Point(388, 186);
            this.TxtApplication_Name.Multiline = true;
            this.TxtApplication_Name.Name = "TxtApplication_Name";
            this.TxtApplication_Name.Size = new System.Drawing.Size(674, 43);
            this.TxtApplication_Name.TabIndex = 43;
            this.TxtApplication_Name.Text = "Ex:Application Name";
            this.TxtApplication_Name.Enter += new System.EventHandler(this.TxtApplication_Name_Enter);
            this.TxtApplication_Name.Leave += new System.EventHandler(this.TxtApplication_Name_Leave);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.Silver;
            this.TxtUserName.Location = new System.Drawing.Point(388, 281);
            this.TxtUserName.Multiline = true;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(674, 43);
            this.TxtUserName.TabIndex = 44;
            this.TxtUserName.Text = "Ex:User Name";
            this.TxtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            this.TxtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassword.Location = new System.Drawing.Point(388, 377);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(674, 43);
            this.TxtPassword.TabIndex = 45;
            this.TxtPassword.Text = "Ex:Password";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // APPLICATION_CHANGEACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtApplication_Name);
            this.Controls.Add(this.IbtnBack);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.LblApplication_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "APPLICATION_CHANGEACCOUNT";
            this.Text = "CHANGE ACCOUNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label LblApplication_Name;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClear;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.TextBox TxtApplication_Name;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}