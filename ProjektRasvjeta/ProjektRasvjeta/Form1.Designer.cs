namespace ProjektRasvjeta
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUName = new System.Windows.Forms.TextBox();
            this.textBoxPWord = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(17, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxUName
            // 
            this.textBoxUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxUName.Location = new System.Drawing.Point(136, 72);
            this.textBoxUName.Name = "textBoxUName";
            this.textBoxUName.Size = new System.Drawing.Size(156, 32);
            this.textBoxUName.TabIndex = 2;
            // 
            // textBoxPWord
            // 
            this.textBoxPWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxPWord.Location = new System.Drawing.Point(136, 117);
            this.textBoxPWord.Name = "textBoxPWord";
            this.textBoxPWord.Size = new System.Drawing.Size(156, 32);
            this.textBoxPWord.TabIndex = 3;
            this.textBoxPWord.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonLogin.Location = new System.Drawing.Point(80, 177);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(135, 56);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dobrodošli";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPWord);
            this.Controls.Add(this.textBoxUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUName;
        private System.Windows.Forms.TextBox textBoxPWord;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
    }
}

