using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoProPdfDemo
{
    public partial class ClForm : Form
    {
        private PdfViewer clPdfObj;

        public ClForm(PdfViewer pdfObj)
        {
            InitializeComponent();
            clPdfObj = pdfObj;
        }

        private void navigate_Click(object sender, EventArgs e)
        {
            string bookmarkName = sectionHeader.Text;
            if (NavigateToBookmark(bookmarkName) == -1)
            {
                //Provided value is a subheading. Search for subheading 
                //NavigateToSubheading(bookmarkName);
            }
        }

        private int NavigateToBookmark(string bookmarkName)
        {
            if (clPdfObj.Document == null) return -1;
            MessageBox.Show(string.Join(Environment.NewLine, clPdfObj.Document.Bookmarks));

            var bookmark = FindBookmark(clPdfObj.Document.Bookmarks, bookmarkName);
            if (bookmark != null)
            {
                clPdfObj.Renderer.ZoomMode = PdfViewerZoomMode.FitWidth;
                clPdfObj.Renderer.Page = bookmark.PageIndex;
                return 0;
            }
            else
            {
                MessageBox.Show("Bookmark not found");
                return -1;
            }
        }

        private PdfBookmark FindBookmark(PdfBookmarkCollection bookmarks, string bookmarkName)
        {
            foreach (var bookmark in bookmarks)
            {
                if (bookmark.Title.Equals(bookmarkName, StringComparison.OrdinalIgnoreCase))
                {
                    return bookmark;
                }
                var found = FindBookmark(bookmark.Children, bookmarkName);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }
    }
}
