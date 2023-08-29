namespace pwm_v1
{
    partial class EMAIL_CHANGEACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMAIL_CHANGEACCOUNT));
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblAccountName = new System.Windows.Forms.Label();
            this.BtnUPDATE = new System.Windows.Forms.Button();
            this.BtnDELETE = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.TxtAccountName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblPassword.Location = new System.Drawing.Point(69, 373);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(162, 39);
            this.LblPassword.TabIndex = 31;
            this.LblPassword.Text = "   PASSWORD";
            // 
            // LblAccountName
            // 
            this.LblAccountName.AutoSize = true;
            this.LblAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblAccountName.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccountName.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblAccountName.Location = new System.Drawing.Point(86, 240);
            this.LblAccountName.Name = "LblAccountName";
            this.LblAccountName.Size = new System.Drawing.Size(185, 39);
            this.LblAccountName.TabIndex = 29;
            this.LblAccountName.Text = "ACCOUNT NAME";
            // 
            // BtnUPDATE
            // 
            this.BtnUPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.BtnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUPDATE.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUPDATE.ForeColor = System.Drawing.Color.White;
            this.BtnUPDATE.Location = new System.Drawing.Point(161, 635);
            this.BtnUPDATE.Name = "BtnUPDATE";
            this.BtnUPDATE.Size = new System.Drawing.Size(204, 57);
            this.BtnUPDATE.TabIndex = 35;
            this.BtnUPDATE.Text = "UPDATE";
            this.BtnUPDATE.UseVisualStyleBackColor = false;
            this.BtnUPDATE.Click += new System.EventHandler(this.BtnUPDATE_Click);
            // 
            // BtnDELETE
            // 
            this.BtnDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.BtnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDELETE.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDELETE.ForeColor = System.Drawing.Color.White;
            this.BtnDELETE.Location = new System.Drawing.Point(487, 635);
            this.BtnDELETE.Name = "BtnDELETE";
            this.BtnDELETE.Size = new System.Drawing.Size(204, 57);
            this.BtnDELETE.TabIndex = 36;
            this.BtnDELETE.Text = "DELETE";
            this.BtnDELETE.UseVisualStyleBackColor = false;
            this.BtnDELETE.Click += new System.EventHandler(this.BtnDELETE_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(817, 635);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(204, 57);
            this.BtnClear.TabIndex = 37;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.MediumVioletRed;
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(12, 4);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(63, 56);
            this.IbtnBack.TabIndex = 40;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountName.ForeColor = System.Drawing.Color.Silver;
            this.TxtAccountName.Location = new System.Drawing.Point(369, 232);
            this.TxtAccountName.Multiline = true;
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(667, 47);
            this.TxtAccountName.TabIndex = 41;
            this.TxtAccountName.Text = "EX.AccountName";
            this.TxtAccountName.Enter += new System.EventHandler(this.TxtAccountName_Enter);
            this.TxtAccountName.Leave += new System.EventHandler(this.TxtAccountName_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassword.Location = new System.Drawing.Point(369, 365);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(667, 47);
            this.TxtPassword.TabIndex = 42;
            this.TxtPassword.Text = "EX.Password";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // EMAIL_CHANGEACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtAccountName);
            this.Controls.Add(this.IbtnBack);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDELETE);
            this.Controls.Add(this.BtnUPDATE);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EMAIL_CHANGEACCOUNT";
            this.Text = "CHANGE E -MAIL ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblAccountName;
        private System.Windows.Forms.Button BtnUPDATE;
        private System.Windows.Forms.Button BtnDELETE;
        private System.Windows.Forms.Button BtnClear;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.TextBox TxtAccountName;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}