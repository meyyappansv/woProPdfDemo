using PdfiumViewer;

namespace WoProPdfDemo
{
    public partial class LaunchChecklist : Form
    {
        public LaunchChecklist()
        {
            InitializeComponent();
        }

        private void launchsession_Click(object sender, EventArgs e)
        {
           

            PdfProcessor pdfProcessorInstance = new PdfProcessor("C:\\Temp\\WI-OP\\WI-OP-319-00 3U_020924_A Assembly Instructions.pdf");
            pdfProcessorInstance.Show();

            ClForm checklist = new ClForm(pdfProcessorInstance.getpdfViewer());
            checklist.Show();


        }
    }
}
