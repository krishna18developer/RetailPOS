namespace RetailPOS
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
            this.userIDLabel = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.passCodeTextBox = new System.Windows.Forms.TextBox();
            this.passcodeLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLabel.Location = new System.Drawing.Point(12, 36);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(135, 37);
            this.userIDLabel.TabIndex = 0;
            this.userIDLabel.Text = "USERID";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTextBox.Location = new System.Drawing.Point(212, 33);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(367, 44);
            this.userIDTextBox.TabIndex = 1;
            this.userIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userIDTextBox_KeyPress);
            // 
            // passCodeTextBox
            // 
            this.passCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCodeTextBox.Location = new System.Drawing.Point(212, 103);
            this.passCodeTextBox.Name = "passCodeTextBox";
            this.passCodeTextBox.Size = new System.Drawing.Size(367, 44);
            this.passCodeTextBox.TabIndex = 3;
            this.passCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passCodeTextBox_KeyPress);
            // 
            // passcodeLabel
            // 
            this.passcodeLabel.AutoSize = true;
            this.passcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passcodeLabel.Location = new System.Drawing.Point(12, 106);
            this.passcodeLabel.Name = "passcodeLabel";
            this.passcodeLabel.Size = new System.Drawing.Size(194, 37);
            this.passcodeLabel.TabIndex = 2;
            this.passcodeLabel.Text = "PASSCODE";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(19, 186);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(560, 81);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 283);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passCodeTextBox);
            this.Controls.Add(this.passcodeLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.userIDLabel);
            this.Name = "Login";
            this.Text = "RetailPOS - Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox passCodeTextBox;
        private System.Windows.Forms.Label passcodeLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

