namespace ValidWithUniquePass
{
    partial class Form1
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
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            RegisterButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(18, 66);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(154, 27);
            UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(18, 116);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(154, 27);
            PasswordTextBox.TabIndex = 1;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(40, 178);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(108, 38);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(UsernameTextBox);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Location = new Point(171, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 255);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(18, 46);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(18, 96);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Пароль:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(531, 400);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button RegisterButton;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}
