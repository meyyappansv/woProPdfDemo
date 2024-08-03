namespace WoProPdfDemo
{
    partial class PdfProcessor
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
            pdfContainer = new Panel();
            SuspendLayout();
            // 
            // pdfContainer
            // 
            pdfContainer.Location = new Point(23, 27);
            pdfContainer.Name = "pdfContainer";
            pdfContainer.Size = new Size(1100, 1200);
            pdfContainer.TabIndex = 0;
            // 
            // PdfProcessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 1061);
            Controls.Add(pdfContainer);
            Name = "PdfProcessor";
            Text = "PdfViewer";
            ResumeLayout(false);
        }

        #endregion

        private Panel pdfContainer;
    }
}