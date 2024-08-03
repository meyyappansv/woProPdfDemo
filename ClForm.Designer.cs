namespace WoProPdfDemo
{
    partial class ClForm
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
            sectionHeader = new TextBox();
            navigate = new Button();
            SuspendLayout();
            // 
            // sectionHeader
            // 
            sectionHeader.Location = new Point(101, 71);
            sectionHeader.Name = "sectionHeader";
            sectionHeader.Size = new Size(167, 23);
            sectionHeader.TabIndex = 0;
            // 
            // navigate
            // 
            navigate.Location = new Point(338, 73);
            navigate.Name = "navigate";
            navigate.Size = new Size(120, 23);
            navigate.TabIndex = 1;
            navigate.Text = "Navigate";
            navigate.UseVisualStyleBackColor = true;
            navigate.Click += navigate_Click;
            // 
            // ClForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(navigate);
            Controls.Add(sectionHeader);
            Name = "ClForm";
            Text = "Check List Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sectionHeader;
        private Button navigate;
    }
}