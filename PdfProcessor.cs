using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace WoProPdfDemo
{
    
    public partial class PdfProcessor : Form
    {
 
        private PdfViewer pdfViewer;
        public PdfProcessor(string filePath)
        {
            InitializeComponent();
            InitializePdfViewer();
            LoadPDF(filePath);
            ClForm checklist = new ClForm(pdfViewer);
            checklist.Show();

        }

        private void InitializePdfViewer()
        {
            // Initialize PdfViewer
            pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill
            };

            // Add the PdfViewer to the panel
            pdfContainer.Controls.Add(pdfViewer);
        }
        private void LoadPDF(string filePath)
        {
            try
            {
                var pdfDocument = PdfDocument.Load(filePath);
                pdfViewer.Document = pdfDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
