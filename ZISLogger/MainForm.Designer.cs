namespace ZISLogger
{
    partial class MainForm
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
            panel = new Panel();
            statusStrip1 = new StatusStrip();
            encTime = new ToolStripStatusLabel();
            mainTab = new TabControl();
            mainPage = new TabPage();
            incorrectDataLabel = new Label();
            encryptButton = new Button();
            decryptButton = new Button();
            label4 = new Label();
            ivBox = new TextBox();
            label3 = new Label();
            keyBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            decryptBox = new TextBox();
            encryptBox = new TextBox();
            logPage = new TabPage();
            vScrollBar1 = new VScrollBar();
            panel2 = new Panel();
            panel.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainTab.SuspendLayout();
            mainPage.SuspendLayout();
            logPage.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(statusStrip1);
            panel.Controls.Add(mainTab);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(830, 480);
            panel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { encTime });
            statusStrip1.Location = new Point(0, 458);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(830, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // encTime
            // 
            encTime.Name = "encTime";
            encTime.Size = new Size(0, 17);
            // 
            // mainTab
            // 
            mainTab.Controls.Add(mainPage);
            mainTab.Controls.Add(logPage);
            mainTab.Dock = DockStyle.Fill;
            mainTab.Location = new Point(0, 0);
            mainTab.Name = "mainTab";
            mainTab.SelectedIndex = 0;
            mainTab.Size = new Size(830, 480);
            mainTab.TabIndex = 2;
            // 
            // mainPage
            // 
            mainPage.Controls.Add(incorrectDataLabel);
            mainPage.Controls.Add(encryptButton);
            mainPage.Controls.Add(decryptButton);
            mainPage.Controls.Add(label4);
            mainPage.Controls.Add(ivBox);
            mainPage.Controls.Add(label3);
            mainPage.Controls.Add(keyBox);
            mainPage.Controls.Add(label2);
            mainPage.Controls.Add(label1);
            mainPage.Controls.Add(decryptBox);
            mainPage.Controls.Add(encryptBox);
            mainPage.Location = new Point(4, 24);
            mainPage.Name = "mainPage";
            mainPage.Padding = new Padding(3);
            mainPage.Size = new Size(822, 452);
            mainPage.TabIndex = 0;
            mainPage.Text = "main";
            mainPage.UseVisualStyleBackColor = true;
            // 
            // incorrectDataLabel
            // 
            incorrectDataLabel.AutoSize = true;
            incorrectDataLabel.ForeColor = Color.Red;
            incorrectDataLabel.Location = new Point(3, 356);
            incorrectDataLabel.Name = "incorrectDataLabel";
            incorrectDataLabel.Size = new Size(105, 15);
            incorrectDataLabel.TabIndex = 11;
            incorrectDataLabel.Text = "Incorrect key or IV!";
            incorrectDataLabel.Visible = false;
            // 
            // encryptButton
            // 
            encryptButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            encryptButton.Location = new Point(660, 204);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(75, 23);
            encryptButton.TabIndex = 10;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            decryptButton.Location = new Point(741, 204);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(75, 23);
            decryptButton.TabIndex = 9;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 178);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Initial vector:";
            // 
            // ivBox
            // 
            ivBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ivBox.Location = new Point(89, 175);
            ivBox.Name = "ivBox";
            ivBox.Size = new Size(730, 23);
            ivBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 149);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "Key:";
            // 
            // keyBox
            // 
            keyBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            keyBox.Location = new Point(89, 146);
            keyBox.Name = "keyBox";
            keyBox.Size = new Size(730, 23);
            keyBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 215);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Encrypted text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Decrypted text";
            // 
            // decryptBox
            // 
            decryptBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            decryptBox.Location = new Point(3, 20);
            decryptBox.Multiline = true;
            decryptBox.Name = "decryptBox";
            decryptBox.Size = new Size(816, 120);
            decryptBox.TabIndex = 2;
            // 
            // encryptBox
            // 
            encryptBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            encryptBox.Location = new Point(3, 233);
            encryptBox.Multiline = true;
            encryptBox.Name = "encryptBox";
            encryptBox.Size = new Size(816, 120);
            encryptBox.TabIndex = 1;
            // 
            // logPage
            // 
            logPage.Controls.Add(vScrollBar1);
            logPage.Controls.Add(panel2);
            logPage.Location = new Point(4, 24);
            logPage.Name = "logPage";
            logPage.Padding = new Padding(3);
            logPage.Size = new Size(822, 452);
            logPage.TabIndex = 1;
            logPage.Text = "logs";
            logPage.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(798, 3);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(21, 446);
            vScrollBar1.TabIndex = 0;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(789, 100);
            panel2.TabIndex = 1;
            panel2.Scroll += vScrollBar1_Scroll;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 480);
            Controls.Add(panel);
            Name = "MainForm";
            Text = "Main";
            Load += Form1_Load;
            Shown += MainForm_Shown;
            Scroll += vScrollBar1_Scroll;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainTab.ResumeLayout(false);
            mainPage.ResumeLayout(false);
            mainPage.PerformLayout();
            logPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private VScrollBar vScrollBar1;
        private Panel panel2;
        private TabControl mainTab;
        private TabPage mainPage;
        private TabPage logPage;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel encTime;
        private Label label1;
        private TextBox decryptBox;
        private TextBox encryptBox;
        private Button encryptButton;
        private Button decryptButton;
        private Label label4;
        private TextBox ivBox;
        private Label label3;
        private TextBox keyBox;
        private Label label2;
        private Label incorrectDataLabel;
    }
}
