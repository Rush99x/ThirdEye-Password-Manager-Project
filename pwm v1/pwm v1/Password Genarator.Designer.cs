namespace pwm_v1
{
    partial class Password_Genarator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Genarator));
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.CHECKBOX_PWG_12C = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_PWG_10C = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_PWG_8C = new System.Windows.Forms.CheckBox();
            this.Txt_Password_Window = new System.Windows.Forms.TextBox();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.LblDiscription = new System.Windows.Forms.Label();
            this.LblOr = new System.Windows.Forms.Label();
            this.BtnCopyPassword = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.BtnGenerate.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.ForeColor = System.Drawing.Color.White;
            this.BtnGenerate.Location = new System.Drawing.Point(140, 628);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(204, 57);
            this.BtnGenerate.TabIndex = 11;
            this.BtnGenerate.Text = "Genarate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // CHECKBOX_PWG_12C
            // 
            this.CHECKBOX_PWG_12C.AutoSize = true;
            this.CHECKBOX_PWG_12C.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CHECKBOX_PWG_12C.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_PWG_12C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CHECKBOX_PWG_12C.Location = new System.Drawing.Point(711, 126);
            this.CHECKBOX_PWG_12C.Name = "CHECKBOX_PWG_12C";
            this.CHECKBOX_PWG_12C.Size = new System.Drawing.Size(172, 40);
            this.CHECKBOX_PWG_12C.TabIndex = 9;
            this.CHECKBOX_PWG_12C.Text = " 12 Charactors";
            this.CHECKBOX_PWG_12C.UseVisualStyleBackColor = false;
            // 
            // CHECKBOX_PWG_10C
            // 
            this.CHECKBOX_PWG_10C.AutoSize = true;
            this.CHECKBOX_PWG_10C.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CHECKBOX_PWG_10C.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_PWG_10C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CHECKBOX_PWG_10C.Location = new System.Drawing.Point(463, 126);
            this.CHECKBOX_PWG_10C.Name = "CHECKBOX_PWG_10C";
            this.CHECKBOX_PWG_10C.Size = new System.Drawing.Size(165, 40);
            this.CHECKBOX_PWG_10C.TabIndex = 8;
            this.CHECKBOX_PWG_10C.Text = "10 Charactors";
            this.CHECKBOX_PWG_10C.UseVisualStyleBackColor = false;
            // 
            // CHECKBOX_PWG_8C
            // 
            this.CHECKBOX_PWG_8C.AutoSize = true;
            this.CHECKBOX_PWG_8C.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CHECKBOX_PWG_8C.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_PWG_8C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CHECKBOX_PWG_8C.Location = new System.Drawing.Point(231, 126);
            this.CHECKBOX_PWG_8C.Name = "CHECKBOX_PWG_8C";
            this.CHECKBOX_PWG_8C.Size = new System.Drawing.Size(160, 40);
            this.CHECKBOX_PWG_8C.TabIndex = 7;
            this.CHECKBOX_PWG_8C.Text = "8 Charactors";
            this.CHECKBOX_PWG_8C.UseVisualStyleBackColor = false;
            // 
            // Txt_Password_Window
            // 
            this.Txt_Password_Window.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password_Window.Location = new System.Drawing.Point(152, 405);
            this.Txt_Password_Window.Multiline = true;
            this.Txt_Password_Window.Name = "Txt_Password_Window";
            this.Txt_Password_Window.Size = new System.Drawing.Size(886, 151);
            this.Txt_Password_Window.TabIndex = 6;
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(169)))));
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(3, 4);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(79, 61);
            this.IbtnBack.TabIndex = 12;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.LblDisplay.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplay.ForeColor = System.Drawing.Color.White;
            this.LblDisplay.Location = new System.Drawing.Point(290, 27);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(547, 50);
            this.LblDisplay.TabIndex = 13;
            this.LblDisplay.Text = "Please Select Prefered Charactor Size";
            // 
            // TxtLength
            // 
            this.TxtLength.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLength.ForeColor = System.Drawing.Color.Silver;
            this.TxtLength.Location = new System.Drawing.Point(561, 309);
            this.TxtLength.Multiline = true;
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(67, 42);
            this.TxtLength.TabIndex = 14;
            this.TxtLength.Text = "Size";
            this.TxtLength.Enter += new System.EventHandler(this.TxtLength_Enter);
            this.TxtLength.Leave += new System.EventHandler(this.TxtLength_Leave);
            // 
            // LblDiscription
            // 
            this.LblDiscription.AutoSize = true;
            this.LblDiscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.LblDiscription.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiscription.ForeColor = System.Drawing.Color.White;
            this.LblDiscription.Location = new System.Drawing.Point(293, 316);
            this.LblDiscription.Name = "LblDiscription";
            this.LblDiscription.Size = new System.Drawing.Size(192, 35);
            this.LblDiscription.TabIndex = 15;
            this.LblDiscription.Text = "Enter Prefered Size";
            // 
            // LblOr
            // 
            this.LblOr.AutoSize = true;
            this.LblOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.LblOr.Font = new System.Drawing.Font("Agency FB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOr.ForeColor = System.Drawing.Color.White;
            this.LblOr.Location = new System.Drawing.Point(502, 215);
            this.LblOr.Name = "LblOr";
            this.LblOr.Size = new System.Drawing.Size(62, 52);
            this.LblOr.TabIndex = 16;
            this.LblOr.Text = "OR";
            // 
            // BtnCopyPassword
            // 
            this.BtnCopyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.BtnCopyPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopyPassword.ForeColor = System.Drawing.Color.White;
            this.BtnCopyPassword.Location = new System.Drawing.Point(463, 628);
            this.BtnCopyPassword.Name = "BtnCopyPassword";
            this.BtnCopyPassword.Size = new System.Drawing.Size(204, 57);
            this.BtnCopyPassword.TabIndex = 17;
            this.BtnCopyPassword.Text = "Copy Password";
            this.BtnCopyPassword.UseVisualStyleBackColor = false;
            this.BtnCopyPassword.Click += new System.EventHandler(this.BtnCopyPassword_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.BtnClear.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(786, 628);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(204, 57);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Password_Genarator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCopyPassword);
            this.Controls.Add(this.LblOr);
            this.Controls.Add(this.LblDiscription);
            this.Controls.Add(this.TxtLength);
            this.Controls.Add(this.LblDisplay);
            this.Controls.Add(this.IbtnBack);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.CHECKBOX_PWG_12C);
            this.Controls.Add(this.CHECKBOX_PWG_10C);
            this.Controls.Add(this.CHECKBOX_PWG_8C);
            this.Controls.Add(this.Txt_Password_Window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Password_Genarator";
            this.Text = "PASSWORD GENARATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.CheckBox CHECKBOX_PWG_12C;
        private System.Windows.Forms.CheckBox CHECKBOX_PWG_10C;
        private System.Windows.Forms.CheckBox CHECKBOX_PWG_8C;
        private System.Windows.Forms.TextBox Txt_Password_Window;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.Label LblDisplay;
        private System.Windows.Forms.TextBox TxtLength;
        private System.Windows.Forms.Label LblDiscription;
        private System.Windows.Forms.Label LblOr;
        private System.Windows.Forms.Button BtnCopyPassword;
        private System.Windows.Forms.Button BtnClear;
    }
}