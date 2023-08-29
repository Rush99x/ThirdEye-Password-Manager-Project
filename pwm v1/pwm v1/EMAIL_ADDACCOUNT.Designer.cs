namespace pwm_v1
{
    partial class EMAIL_ADDACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMAIL_ADDACCOUNT));
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblAccountName = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnClear = new System.Windows.Forms.Button();
            this.RtxtComment = new System.Windows.Forms.RichTextBox();
            this.PanelComment = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.TxtAccountName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PanelComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblPassword.Location = new System.Drawing.Point(72, 294);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(141, 39);
            this.LblPassword.TabIndex = 34;
            this.LblPassword.Text = "PASSWORD";
            // 
            // LblAccountName
            // 
            this.LblAccountName.AutoSize = true;
            this.LblAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.LblAccountName.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccountName.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblAccountName.Location = new System.Drawing.Point(72, 192);
            this.LblAccountName.Name = "LblAccountName";
            this.LblAccountName.Size = new System.Drawing.Size(185, 39);
            this.LblAccountName.TabIndex = 32;
            this.LblAccountName.Text = "ACCOUNT NAME";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.BtnAdd.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(293, 646);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(204, 57);
            this.BtnAdd.TabIndex = 38;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.MediumVioletRed;
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(2, 1);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(71, 56);
            this.IbtnBack.TabIndex = 41;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.BtnClear.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(643, 646);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(204, 57);
            this.BtnClear.TabIndex = 42;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // RtxtComment
            // 
            this.RtxtComment.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtComment.ForeColor = System.Drawing.Color.Silver;
            this.RtxtComment.Location = new System.Drawing.Point(13, 52);
            this.RtxtComment.Name = "RtxtComment";
            this.RtxtComment.Size = new System.Drawing.Size(736, 108);
            this.RtxtComment.TabIndex = 43;
            this.RtxtComment.Text = "Add Your Comment Here";
            this.RtxtComment.Enter += new System.EventHandler(this.RtxtComment_Enter);
            this.RtxtComment.Leave += new System.EventHandler(this.RtxtComment_Leave);
            // 
            // PanelComment
            // 
            this.PanelComment.BackColor = System.Drawing.Color.Purple;
            this.PanelComment.Controls.Add(this.lblComment);
            this.PanelComment.Controls.Add(this.RtxtComment);
            this.PanelComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelComment.Location = new System.Drawing.Point(204, 394);
            this.PanelComment.Name = "PanelComment";
            this.PanelComment.Size = new System.Drawing.Size(763, 175);
            this.PanelComment.TabIndex = 44;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(16, 5);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(100, 35);
            this.lblComment.TabIndex = 44;
            this.lblComment.Text = "Comment";
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountName.ForeColor = System.Drawing.Color.Silver;
            this.TxtAccountName.Location = new System.Drawing.Point(311, 188);
            this.TxtAccountName.Multiline = true;
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(674, 43);
            this.TxtAccountName.TabIndex = 45;
            this.TxtAccountName.Text = "EX.Account Name";
            this.TxtAccountName.Enter += new System.EventHandler(this.TxtAccountName_Enter);
            this.TxtAccountName.Leave += new System.EventHandler(this.TxtAccountName_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassword.Location = new System.Drawing.Point(311, 290);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(674, 43);
            this.TxtPassword.TabIndex = 46;
            this.TxtPassword.Text = "EX.Password";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // EMAIL_ADDACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtAccountName);
            this.Controls.Add(this.PanelComment);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.IbtnBack);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EMAIL_ADDACCOUNT";
            this.Text = "Add E-Mail Account";
            this.PanelComment.ResumeLayout(false);
            this.PanelComment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblAccountName;
        private System.Windows.Forms.Button BtnAdd;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.RichTextBox RtxtComment;
        private System.Windows.Forms.Panel PanelComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox TxtAccountName;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}