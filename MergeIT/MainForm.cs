using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace MergeIT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
    
            saveFileDialogPdfOutput.FileOk += SaveFileDialogPdfOutput_FileOk;
            openFileDialogPdfSources.FileOk += OpenFileDialogPdfSources_FileOk;
        }

        private void OpenFileDialogPdfSources_FileOk(object sender, CancelEventArgs e)
        {
            lstPdfInput.Items.AddRange(openFileDialogPdfSources.FileNames);
        }

        private void Merge()
        {
            using (PdfDocument outPdf = new PdfDocument())
            {
                foreach (string fileName in lstPdfInput.Items)
                {
                    using (PdfDocument pdf = PdfReader.Open(fileName, PdfDocumentOpenMode.Import))
                    {
                        CopyPages(pdf, outPdf);
                    }

                    progressMerge.Value++;
                    Application.DoEvents();
                }

                outPdf.Save(txtOutput.Text);

                progressMerge.Value = progressMerge.Maximum;
                Application.DoEvents();
            }
        }

        private void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }

        private void btnPdfBrowse_Click(object sender, EventArgs e)
        {
            openFileDialogPdfSources.ShowDialog();
        }

        private void btnPdfOutputBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialogPdfOutput.ShowDialog();
        }

        private void SaveFileDialogPdfOutput_FileOk(object sender, CancelEventArgs e)
        {
            txtOutput.Text = saveFileDialogPdfOutput.FileName;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                progressMerge.Minimum = 0;
                progressMerge.Maximum = lstPdfInput.Items.Count;
                progressMerge.Value = 0;
                progressMerge.Visible = true;
                Application.DoEvents();

                Merge();

                MessageBox.Show("Files successfully merged", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressMerge.Visible = false;
                Cursor.Current = Cursors.Default;
            }
        }

        private void picMerge_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© Chris Boshoff\nEmail: merge@chrisboshoff.co.za\nWeb: https://chrisboshoff.co.za", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
