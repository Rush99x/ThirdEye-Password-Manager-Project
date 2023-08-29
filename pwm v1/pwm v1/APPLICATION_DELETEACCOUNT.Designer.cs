namespace pwm_v1
{
    partial class APPLICATION_DELETEACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APPLICATION_DELETEACCOUNT));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblApplication_Name = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.TxtApplication_Name = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.lblPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblPassword.Location = new System.Drawing.Point(76, 360);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(141, 39);
            this.lblPassword.TabIndex = 67;
            this.lblPassword.Text = "PASSWORD";
            // 
            // lblApplication_Name
            // 
            this.lblApplication_Name.AutoSize = true;
            this.lblApplication_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.lblApplication_Name.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplication_Name.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblApplication_Name.Location = new System.Drawing.Point(76, 215);
            this.lblApplication_Name.Name = "lblApplication_Name";
            this.lblApplication_Name.Size = new System.Drawing.Size(221, 39);
            this.lblApplication_Name.TabIndex = 65;
            this.lblApplication_Name.Text = "APPLICATION NAME";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(470, 611);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(204, 69);
            this.BtnDelete.TabIndex = 64;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.MediumVioletRed;
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(2, 3);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(63, 54);
            this.IbtnBack.TabIndex = 0;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // TxtApplication_Name
            // 
            this.TxtApplication_Name.BackColor = System.Drawing.Color.White;
            this.TxtApplication_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtApplication_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApplication_Name.ForeColor = System.Drawing.Color.Silver;
            this.TxtApplication_Name.Location = new System.Drawing.Point(358, 211);
            this.TxtApplication_Name.Multiline = true;
            this.TxtApplication_Name.Name = "TxtApplication_Name";
            this.TxtApplication_Name.Size = new System.Drawing.Size(674, 43);
            this.TxtApplication_Name.TabIndex = 69;
            this.TxtApplication_Name.Text = "Ex.AccountName";
            this.TxtApplication_Name.Enter += new System.EventHandler(this.TxtApplication_Name_Enter);
            this.TxtApplication_Name.Leave += new System.EventHandler(this.TxtApplication_Name_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassword.Location = new System.Drawing.Point(358, 360);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(674, 43);
            this.TxtPassword.TabIndex = 70;
            this.TxtPassword.Text = "Ex:Password";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // APPLICATION_DELETEACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtApplication_Name);
            this.Controls.Add(this.IbtnBack);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblApplication_Name);
            this.Controls.Add(this.BtnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "APPLICATION_DELETEACCOUNT";
            this.Text = "DELETE ACCOUNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblApplication_Name;
        private System.Windows.Forms.Button BtnDelete;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.TextBox TxtApplication_Name;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}