namespace PracticWork2
{
    partial class Autorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            registration = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.Location = new Point(12, 62);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Login";
            LoginTextBox.Size = new Size(232, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(12, 139);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(232, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // registration
            // 
            registration.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            registration.Location = new Point(116, 344);
            registration.Name = "registration";
            registration.Size = new Size(128, 23);
            registration.TabIndex = 2;
            registration.Text = "Зарегистрироваться";
            registration.UseVisualStyleBackColor = true;
            registration.Click += registration_Click;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 379);
            Controls.Add(registration);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            MinimumSize = new Size(272, 418);
            Name = "Autorization";
            Text = "Autorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button registration;
    }
}
