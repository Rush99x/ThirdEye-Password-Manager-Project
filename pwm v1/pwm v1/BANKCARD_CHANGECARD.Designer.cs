namespace pwm_v1
{
    partial class BANKCARD_CHANGECARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BANKCARD_CHANGECARD));
            this.Lbl_CARD_HOLDER = new System.Windows.Forms.Label();
            this.Lbl_CARD_NUMBER = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ibtnBack = new FontAwesome.Sharp.IconButton();
            this.Txt_CardNumber = new System.Windows.Forms.TextBox();
            this.Txt_CardHolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_CARD_HOLDER
            // 
            this.Lbl_CARD_HOLDER.AutoSize = true;
            this.Lbl_CARD_HOLDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.Lbl_CARD_HOLDER.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CARD_HOLDER.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Lbl_CARD_HOLDER.Location = new System.Drawing.Point(117, 283);
            this.Lbl_CARD_HOLDER.Name = "Lbl_CARD_HOLDER";
            this.Lbl_CARD_HOLDER.Size = new System.Drawing.Size(166, 39);
            this.Lbl_CARD_HOLDER.TabIndex = 53;
            this.Lbl_CARD_HOLDER.Text = "CARD HOLDER";
            // 
            // Lbl_CARD_NUMBER
            // 
            this.Lbl_CARD_NUMBER.AutoSize = true;
            this.Lbl_CARD_NUMBER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.Lbl_CARD_NUMBER.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CARD_NUMBER.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Lbl_CARD_NUMBER.Location = new System.Drawing.Point(117, 165);
            this.Lbl_CARD_NUMBER.Name = "Lbl_CARD_NUMBER";
            this.Lbl_CARD_NUMBER.Size = new System.Drawing.Size(174, 39);
            this.Lbl_CARD_NUMBER.TabIndex = 52;
            this.Lbl_CARD_NUMBER.Text = "CARD NUMBER";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(172)))));
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(477, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 68);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ibtnBack
            // 
            this.ibtnBack.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ibtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ibtnBack.IconColor = System.Drawing.Color.White;
            this.ibtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBack.IconSize = 35;
            this.ibtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnBack.Location = new System.Drawing.Point(12, 12);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(63, 48);
            this.ibtnBack.TabIndex = 42;
            this.ibtnBack.UseVisualStyleBackColor = false;
            this.ibtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // Txt_CardNumber
            // 
            this.Txt_CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CardNumber.ForeColor = System.Drawing.Color.Silver;
            this.Txt_CardNumber.Location = new System.Drawing.Point(340, 161);
            this.Txt_CardNumber.Multiline = true;
            this.Txt_CardNumber.Name = "Txt_CardNumber";
            this.Txt_CardNumber.Size = new System.Drawing.Size(674, 43);
            this.Txt_CardNumber.TabIndex = 58;
            this.Txt_CardNumber.Text = "Ex:1234 1234 1234 1234";
            this.Txt_CardNumber.Enter += new System.EventHandler(this.Txt_CardNumber_Enter);
            this.Txt_CardNumber.Leave += new System.EventHandler(this.Txt_CardNumber_Leave);
            // 
            // Txt_CardHolder
            // 
            this.Txt_CardHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CardHolder.ForeColor = System.Drawing.Color.Silver;
            this.Txt_CardHolder.Location = new System.Drawing.Point(340, 279);
            this.Txt_CardHolder.Multiline = true;
            this.Txt_CardHolder.Name = "Txt_CardHolder";
            this.Txt_CardHolder.Size = new System.Drawing.Size(674, 43);
            this.Txt_CardHolder.TabIndex = 59;
            this.Txt_CardHolder.Text = "Ex:Card Holder";
            this.Txt_CardHolder.Enter += new System.EventHandler(this.Txt_CardHolder_Enter);
            this.Txt_CardHolder.Leave += new System.EventHandler(this.Txt_CardHolder_Leave);
            // 
            // BANKCARD_CHANGECARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.Txt_CardHolder);
            this.Controls.Add(this.Txt_CardNumber);
            this.Controls.Add(this.ibtnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Lbl_CARD_HOLDER);
            this.Controls.Add(this.Lbl_CARD_NUMBER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BANKCARD_CHANGECARD";
            this.Text = "CHANGE BANK CARDS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_CARD_HOLDER;
        private System.Windows.Forms.Label Lbl_CARD_NUMBER;
        private System.Windows.Forms.Button btnDelete;
        private FontAwesome.Sharp.IconButton ibtnBack;
        private System.Windows.Forms.TextBox Txt_CardNumber;
        private System.Windows.Forms.TextBox Txt_CardHolder;
    }
}