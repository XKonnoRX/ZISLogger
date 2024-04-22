namespace ZISLogger
{
    partial class AuthForm
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
            loginBox = new TextBox();
            passBox = new TextBox();
            EnterButton = new Button();
            label1 = new Label();
            incorrectLabel = new Label();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox.Location = new Point(69, 79);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(201, 35);
            loginBox.TabIndex = 1;
            loginBox.Text = "Login";
            loginBox.Enter += loginBox_Enter;
            loginBox.Leave += loginBox_Leave;
            // 
            // passBox
            // 
            passBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passBox.Location = new Point(69, 120);
            passBox.Name = "passBox";
            passBox.Size = new Size(201, 35);
            passBox.TabIndex = 2;
            passBox.Text = "Password";
            passBox.Enter += passBox_Enter;
            passBox.Leave += passBox_Leave;
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(205, 172);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(65, 23);
            EnterButton.TabIndex = 0;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(69, 18);
            label1.Name = "label1";
            label1.Size = new Size(204, 40);
            label1.TabIndex = 0;
            label1.Text = "Authentication";
            // 
            // incorrectLabel
            // 
            incorrectLabel.AutoSize = true;
            incorrectLabel.ForeColor = Color.Red;
            incorrectLabel.Location = new Point(69, 158);
            incorrectLabel.Name = "incorrectLabel";
            incorrectLabel.Size = new Size(83, 15);
            incorrectLabel.TabIndex = 3;
            incorrectLabel.Text = "Incorrect data!";
            incorrectLabel.Visible = false;
            // 
            // AuthForm
            // 
            AcceptButton = EnterButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 219);
            Controls.Add(incorrectLabel);
            Controls.Add(label1);
            Controls.Add(EnterButton);
            Controls.Add(passBox);
            Controls.Add(loginBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AuthForm";
            Text = "AuthForm";
            FormClosing += AuthForm_FormClosing;
            Load += AuthForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginBox;
        private TextBox passBox;
        private Button EnterButton;
        private Label label1;
        private Label incorrectLabel;
    }
}