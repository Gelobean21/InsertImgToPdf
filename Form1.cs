using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = iTextSharp.text.Image;

namespace insert_image_to_pdf
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string pdfPath = string.Empty;
        string[] pdfPaths;
        string imagePath = string.Empty;
        string outputPath = string.Empty;
        int x1 = 0;
        int x2 = 0;
        int y1 = 0;
        int y2 = 0;

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        
        private void generatePDF()
        {
            try
            {
                for (int z = 0; z < pdfPaths.Length; z++)
                {
                    using (Stream inputPdfStream = new FileStream(pdfPaths[z], FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (Stream inputImageStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (Stream outputPdfStream = new FileStream(outputPath + "\\" + Path.GetFileNameWithoutExtension(pdfPaths[z]) + "1.pdf",
                        FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        var reader = new PdfReader(inputPdfStream);
                        var stamper = new PdfStamper(reader, outputPdfStream);
                        Image image = Image.GetInstance(inputImageStream);

                        for (int i = 1; i < reader.NumberOfPages + 1; i++)
                        {
                            var pdfContentByte = stamper.GetOverContent(i);
                            image.SetAbsolutePosition(x1, y1);
                            pdfContentByte.AddImage(image);
                            image.SetAbsolutePosition(x2, y2);
                            pdfContentByte.AddImage(image);

                        }
                        stamper.Close();
                    }
                    bwMain.ReportProgress(z + 1);

                }
                bwMain.ReportProgress(100);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF File (*.pdf) |*.pdf";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pdfPaths = ofd.FileNames;
                    txtPdf.Text = "Files selected";
                }
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png) |*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    txtImg.Text = imagePath;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            if(int.TryParse(txtX1.Text, out x1))
            {
                if (int.TryParse(txtX2.Text, out x2))
                {
                    if (int.TryParse(txtY1.Text, out y1))
                    {
                        if (int.TryParse(txtY2.Text, out y2))
                        {
                            if (txtPdf.Text != "" && File.Exists(imagePath) && !string.IsNullOrEmpty(outputPath))
                            {
                                ManageProgressbar(pgbMain, pdfPaths.Length);
                                bwMain.RunWorkerAsync();
                            }
                            else
                            {
                                MessageBox.Show("Either one of selected paths doesn't exist!", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    outputPath = fbd.SelectedPath;
                    txtOutput.Text = outputPath;
                }
            }
            /*
            using (var sfd = new SaveFileDialog())
            {
                
                string date = DateTime.Now.ToString("MMddyyyy");
                sfd.FileName = date + " - " + "generated";
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.Title = "Create PDF File";

                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.FileName))
                {
                    outputPath = sfd.FileName;
                    txtOutput.Text = outputPath;
                }
            }*/
        }

        private void bwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            generatePDF();
        }

        private void bwMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbMain.Value = e.ProgressPercentage;
        }

        private void bwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                
            }
            else if (e.Error != null)
            {
                MessageBox.Show("There was an error running the process. The thread aborted",
                    "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Process was completed", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pgbMain.Value = 0;
        }

        private void ManageProgressbar(ProgressBar pgb, int max)
        {
            pgb.Invoke((MethodInvoker)delegate
            {
                pgb.Minimum = 0;
                pgb.Maximum = max;
                pgb.Value = 0;
                pgb.Step = 1;
            });
        }
    }
}
