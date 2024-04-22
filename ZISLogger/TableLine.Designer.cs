namespace ZISLogger
{
    partial class TableLine
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            idBox = new TextBox();
            datetimeBox = new TextBox();
            contentBox = new TextBox();
            statusPanel = new Panel();
            SuspendLayout();
            // 
            // idBox
            // 
            idBox.Dock = DockStyle.Left;
            idBox.Location = new Point(28, 0);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(32, 23);
            idBox.TabIndex = 0;
            // 
            // datetimeBox
            // 
            datetimeBox.Dock = DockStyle.Left;
            datetimeBox.Location = new Point(60, 0);
            datetimeBox.Name = "datetimeBox";
            datetimeBox.ReadOnly = true;
            datetimeBox.Size = new Size(145, 23);
            datetimeBox.TabIndex = 1;
            // 
            // contentBox
            // 
            contentBox.Dock = DockStyle.Fill;
            contentBox.Location = new Point(205, 0);
            contentBox.Name = "contentBox";
            contentBox.ReadOnly = true;
            contentBox.Size = new Size(414, 23);
            contentBox.TabIndex = 2;
            // 
            // statusPanel
            // 
            statusPanel.Dock = DockStyle.Left;
            statusPanel.Location = new Point(0, 0);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(28, 23);
            statusPanel.TabIndex = 3;
            // 
            // TableLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentBox);
            Controls.Add(datetimeBox);
            Controls.Add(idBox);
            Controls.Add(statusPanel);
            Name = "TableLine";
            Size = new Size(619, 23);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox idBox;
        public TextBox datetimeBox;
        public TextBox contentBox;
        public Panel statusPanel;
    }
}
