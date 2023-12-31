﻿namespace pwm_v1
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.DataGrid_Email = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Email
            // 
            this.DataGrid_Email.AllowUserToOrderColumns = true;
            this.DataGrid_Email.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Email.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.DataGrid_Email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Email.Location = new System.Drawing.Point(21, 85);
            this.DataGrid_Email.Name = "DataGrid_Email";
            this.DataGrid_Email.RowHeadersWidth = 51;
            this.DataGrid_Email.RowTemplate.Height = 24;
            this.DataGrid_Email.Size = new System.Drawing.Size(1132, 539);
            this.DataGrid_Email.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(228, 642);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(228, 75);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnChange.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChange.ForeColor = System.Drawing.Color.White;
            this.BtnChange.Location = new System.Drawing.Point(682, 642);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(228, 75);
            this.BtnChange.TabIndex = 6;
            this.BtnChange.Text = "CHANGE";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 40;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBack.Location = new System.Drawing.Point(1, -1);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(72, 61);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DataGrid_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Email";
            this.Text = "E - MAIL";
            this.Load += new System.EventHandler(this.Email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Email;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnChange;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}