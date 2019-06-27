namespace LMS_WindowsForms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_RuserName = new System.Windows.Forms.Label();
            this.Lbl_RuserPassword = new System.Windows.Forms.Label();
            this.Txt_RuserName = new System.Windows.Forms.TextBox();
            this.Txt_RuserPassword = new System.Windows.Forms.TextBox();
            this.Txt_RuserPassword2 = new System.Windows.Forms.TextBox();
            this.Lbl_RuserPassword2 = new System.Windows.Forms.Label();
            this.Btn_Comfirm = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Register";
            // 
            // Lbl_RuserName
            // 
            this.Lbl_RuserName.AutoSize = true;
            this.Lbl_RuserName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RuserName.Location = new System.Drawing.Point(41, 103);
            this.Lbl_RuserName.Name = "Lbl_RuserName";
            this.Lbl_RuserName.Size = new System.Drawing.Size(61, 15);
            this.Lbl_RuserName.TabIndex = 2;
            this.Lbl_RuserName.Text = "User Name";
            // 
            // Lbl_RuserPassword
            // 
            this.Lbl_RuserPassword.AutoSize = true;
            this.Lbl_RuserPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RuserPassword.Location = new System.Drawing.Point(41, 147);
            this.Lbl_RuserPassword.Name = "Lbl_RuserPassword";
            this.Lbl_RuserPassword.Size = new System.Drawing.Size(54, 15);
            this.Lbl_RuserPassword.TabIndex = 3;
            this.Lbl_RuserPassword.Text = "Password";
            // 
            // Txt_RuserName
            // 
            this.Txt_RuserName.Location = new System.Drawing.Point(147, 102);
            this.Txt_RuserName.Name = "Txt_RuserName";
            this.Txt_RuserName.Size = new System.Drawing.Size(130, 20);
            this.Txt_RuserName.TabIndex = 4;
            // 
            // Txt_RuserPassword
            // 
            this.Txt_RuserPassword.Location = new System.Drawing.Point(147, 143);
            this.Txt_RuserPassword.Name = "Txt_RuserPassword";
            this.Txt_RuserPassword.PasswordChar = '*';
            this.Txt_RuserPassword.Size = new System.Drawing.Size(130, 20);
            this.Txt_RuserPassword.TabIndex = 5;
            // 
            // Txt_RuserPassword2
            // 
            this.Txt_RuserPassword2.Location = new System.Drawing.Point(147, 182);
            this.Txt_RuserPassword2.Name = "Txt_RuserPassword2";
            this.Txt_RuserPassword2.PasswordChar = '*';
            this.Txt_RuserPassword2.Size = new System.Drawing.Size(130, 20);
            this.Txt_RuserPassword2.TabIndex = 6;
            // 
            // Lbl_RuserPassword2
            // 
            this.Lbl_RuserPassword2.AutoSize = true;
            this.Lbl_RuserPassword2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RuserPassword2.Location = new System.Drawing.Point(40, 183);
            this.Lbl_RuserPassword2.Name = "Lbl_RuserPassword2";
            this.Lbl_RuserPassword2.Size = new System.Drawing.Size(97, 15);
            this.Lbl_RuserPassword2.TabIndex = 7;
            this.Lbl_RuserPassword2.Text = "Confirm Password";
            // 
            // Btn_Comfirm
            // 
            this.Btn_Comfirm.Location = new System.Drawing.Point(200, 239);
            this.Btn_Comfirm.Name = "Btn_Comfirm";
            this.Btn_Comfirm.Size = new System.Drawing.Size(75, 25);
            this.Btn_Comfirm.TabIndex = 8;
            this.Btn_Comfirm.Text = "Register";
            this.Btn_Comfirm.UseVisualStyleBackColor = true;
            this.Btn_Comfirm.Click += new System.EventHandler(this.Btn_Comfirm_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(296, 239);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 25);
            this.Btn_Reset.TabIndex = 9;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(391, 239);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 25);
            this.Btn_Back.TabIndex = 10;
            this.Btn_Back.Text = "back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(147, 54);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(130, 20);
            this.TxtID.TabIndex = 12;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(545, 297);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_Comfirm);
            this.Controls.Add(this.Lbl_RuserPassword2);
            this.Controls.Add(this.Txt_RuserPassword2);
            this.Controls.Add(this.Txt_RuserPassword);
            this.Controls.Add(this.Txt_RuserName);
            this.Controls.Add(this.Lbl_RuserPassword);
            this.Controls.Add(this.Lbl_RuserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_RuserName;
        private System.Windows.Forms.Label Lbl_RuserPassword;
        private System.Windows.Forms.TextBox Txt_RuserName;
        private System.Windows.Forms.TextBox Txt_RuserPassword;
        private System.Windows.Forms.TextBox Txt_RuserPassword2;
        private System.Windows.Forms.Label Lbl_RuserPassword2;
        private System.Windows.Forms.Button Btn_Comfirm;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
    }
}