namespace pwm_v1
{
    partial class WEB_DELETEACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WEB_DELETEACCOUNT));
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblWEBSITE_ADDRESS = new System.Windows.Forms.Label();
            this.LblPASSWORD = new System.Windows.Forms.Label();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.TxtWebsite_Address = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(113)))), ((int)(((byte)(160)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(450, 615);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(204, 57);
            this.BtnDelete.TabIndex = 59;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblWEBSITE_ADDRESS
            // 
            this.LblWEBSITE_ADDRESS.AutoSize = true;
            this.LblWEBSITE_ADDRESS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblWEBSITE_ADDRESS.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWEBSITE_ADDRESS.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblWEBSITE_ADDRESS.Location = new System.Drawing.Point(100, 220);
            this.LblWEBSITE_ADDRESS.Name = "LblWEBSITE_ADDRESS";
            this.LblWEBSITE_ADDRESS.Size = new System.Drawing.Size(220, 39);
            this.LblWEBSITE_ADDRESS.TabIndex = 60;
            this.LblWEBSITE_ADDRESS.Text = "WEBSITE ADDRESS";
            // 
            // LblPASSWORD
            // 
            this.LblPASSWORD.AutoSize = true;
            this.LblPASSWORD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblPASSWORD.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPASSWORD.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblPASSWORD.Location = new System.Drawing.Point(100, 357);
            this.LblPASSWORD.Name = "LblPASSWORD";
            this.LblPASSWORD.Size = new System.Drawing.Size(141, 39);
            this.LblPASSWORD.TabIndex = 62;
            this.LblPASSWORD.Text = "PASSWORD";
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(3, 3);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(63, 53);
            this.IbtnBack.TabIndex = 12;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // TxtWebsite_Address
            // 
            this.TxtWebsite_Address.BackColor = System.Drawing.SystemColors.Window;
            this.TxtWebsite_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWebsite_Address.ForeColor = System.Drawing.Color.Silver;
            this.TxtWebsite_Address.Location = new System.Drawing.Point(433, 220);
            this.TxtWebsite_Address.Multiline = true;
            this.TxtWebsite_Address.Name = "TxtWebsite_Address";
            this.TxtWebsite_Address.Size = new System.Drawing.Size(626, 44);
            this.TxtWebsite_Address.TabIndex = 63;
            this.TxtWebsite_Address.Text = "Ex:Website Address";
            this.TxtWebsite_Address.Enter += new System.EventHandler(this.TxtWebsite_Address_Enter);
            this.TxtWebsite_Address.Leave += new System.EventHandler(this.TxtWebsite_Address_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassword.Location = new System.Drawing.Point(433, 352);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(626, 44);
            this.TxtPassword.TabIndex = 64;
            this.TxtPassword.Text = "Ex:Password";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // WEB_DELETEACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtWebsite_Address);
            this.Controls.Add(this.IbtnBack);
            this.Controls.Add(this.LblPASSWORD);
            this.Controls.Add(this.LblWEBSITE_ADDRESS);
            this.Controls.Add(this.BtnDelete);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WEB_DELETEACCOUNT";
            this.Text = "DELETE ACCOUNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblWEBSITE_ADDRESS;
        private System.Windows.Forms.Label LblPASSWORD;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.TextBox TxtWebsite_Address;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}