namespace pwm_v1
{
    partial class WEB_CHANGEACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WEB_CHANGEACCOUNT));
            this.LblWEBSITE_ADDRESS = new System.Windows.Forms.Label();
            this.LblPASSWORD = new System.Windows.Forms.Label();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.Lbl_LOGIN = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtLogIn = new System.Windows.Forms.TextBox();
            this.TxtWebsite_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblWEBSITE_ADDRESS
            // 
            this.LblWEBSITE_ADDRESS.AutoSize = true;
            this.LblWEBSITE_ADDRESS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblWEBSITE_ADDRESS.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWEBSITE_ADDRESS.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblWEBSITE_ADDRESS.Location = new System.Drawing.Point(101, 162);
            this.LblWEBSITE_ADDRESS.Name = "LblWEBSITE_ADDRESS";
            this.LblWEBSITE_ADDRESS.Size = new System.Drawing.Size(220, 39);
            this.LblWEBSITE_ADDRESS.TabIndex = 48;
            this.LblWEBSITE_ADDRESS.Text = "WEBSITE ADDRESS";
            // 
            // LblPASSWORD
            // 
            this.LblPASSWORD.AutoSize = true;
            this.LblPASSWORD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblPASSWORD.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPASSWORD.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblPASSWORD.Location = new System.Drawing.Point(101, 398);
            this.LblPASSWORD.Name = "LblPASSWORD";
            this.LblPASSWORD.Size = new System.Drawing.Size(141, 39);
            this.LblPASSWORD.TabIndex = 54;
            this.LblPASSWORD.Text = "PASSWORD";
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.MediumVioletRed;
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(3, 3);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(68, 54);
            this.IbtnBack.TabIndex = 40;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(113)))), ((int)(((byte)(160)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(467, 609);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(204, 68);
            this.BtnUpdate.TabIndex = 57;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Lbl_LOGIN
            // 
            this.Lbl_LOGIN.AutoSize = true;
            this.Lbl_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.Lbl_LOGIN.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LOGIN.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Lbl_LOGIN.Location = new System.Drawing.Point(101, 279);
            this.Lbl_LOGIN.Name = "Lbl_LOGIN";
            this.Lbl_LOGIN.Size = new System.Drawing.Size(85, 39);
            this.Lbl_LOGIN.TabIndex = 59;
            this.Lbl_LOGIN.Text = "LOG IN";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassword.Location = new System.Drawing.Point(372, 396);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(659, 43);
            this.TxtPassword.TabIndex = 62;
            this.TxtPassword.Text = "Ex:Password";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtLogIn
            // 
            this.TxtLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogIn.ForeColor = System.Drawing.Color.Silver;
            this.TxtLogIn.Location = new System.Drawing.Point(372, 279);
            this.TxtLogIn.Multiline = true;
            this.TxtLogIn.Name = "TxtLogIn";
            this.TxtLogIn.Size = new System.Drawing.Size(659, 43);
            this.TxtLogIn.TabIndex = 61;
            this.TxtLogIn.Text = "Ex:LogIn";
            this.TxtLogIn.Enter += new System.EventHandler(this.TxtLogIn_Enter);
            this.TxtLogIn.Leave += new System.EventHandler(this.TxtLogIn_Leave);
            // 
            // TxtWebsite_Address
            // 
            this.TxtWebsite_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWebsite_Address.ForeColor = System.Drawing.Color.Silver;
            this.TxtWebsite_Address.Location = new System.Drawing.Point(372, 162);
            this.TxtWebsite_Address.Multiline = true;
            this.TxtWebsite_Address.Name = "TxtWebsite_Address";
            this.TxtWebsite_Address.Size = new System.Drawing.Size(659, 43);
            this.TxtWebsite_Address.TabIndex = 60;
            this.TxtWebsite_Address.Text = "Ex:Website Address";
            this.TxtWebsite_Address.Enter += new System.EventHandler(this.TxtWebsite_Address_Enter);
            this.TxtWebsite_Address.Leave += new System.EventHandler(this.TxtWebsite_Address_Leave);
            // 
            // WEB_CHANGEACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtLogIn);
            this.Controls.Add(this.TxtWebsite_Address);
            this.Controls.Add(this.IbtnBack);
            this.Controls.Add(this.Lbl_LOGIN);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.LblPASSWORD);
            this.Controls.Add(this.LblWEBSITE_ADDRESS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WEB_CHANGEACCOUNT";
            this.Text = "CHANGE ACCOUNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblWEBSITE_ADDRESS;
        private System.Windows.Forms.Label LblPASSWORD;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label Lbl_LOGIN;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtLogIn;
        private System.Windows.Forms.TextBox TxtWebsite_Address;
    }
}