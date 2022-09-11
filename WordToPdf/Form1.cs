using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;

namespace WordToPdf
{
    public partial class frmApp : Form
    {
        private bool bSameFolder = false;
        private string strExePath = string.Empty;

        public frmApp()
        {
            InitializeComponent();
            strExePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        }

        private void callConvert(string[] files) 
        {
            string[] wordFiles = getWordFilesFromFolder(files);
            if (wordFiles.Length > 0) {
                proBarConvertionProcess.Maximum = wordFiles.Length;
                convert(wordFiles);
            } 
            else {
                MessageBox.Show("Подходящих файлов (DOC или DOCX) не обнаружено.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e) 
        {
            lblDirectoryPath.Text = string.Empty;
            lblConvertationProgress.Text = string.Empty;
            proBarConvertionProcess.Value = 0;
            string[] files = null;

            if (bSameFolder) {
                files = Directory.GetFiles(strExePath);
                callConvert(files);
                return;
            }

            DialogResult result;

            using (var fbd = new FolderBrowserDialog()) {
                result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    files = Directory.GetFiles(fbd.SelectedPath);
                    lblDirectoryPath.Text = fbd.SelectedPath;
                    callConvert(files);
                }
            }
        }

        // Метод выдаёт массив названий всех Word-файлов.
        private string[] getWordFilesFromFolder(string[] files)
        {
            List<string> wordFiles = new List<string>(); // List используется из-за удобства применения метода Add().
            
            foreach (string file in files) {
                if (Path.GetFileName(file)[0] != '~' && (Path.GetExtension(file) == ".docx" || (Path.GetExtension(file) == ".doc")))
                    wordFiles.Add(file);
            }

            return wordFiles.ToArray();
        }

        private void convert(string[] files) 
        {
            Cursor.Current = Cursors.WaitCursor;
            bool isWordClosed = false;
            Microsoft.Office.Interop.Word.Document wordDocument = null;
            Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
            int counter = 0;

            if (files != null) {                    
                foreach(string file in files) {
                    if (Path.GetFileName(file)[0] != '~' && (Path.GetExtension(file) == ".docx" || (Path.GetExtension(file) == ".doc"))) {
                        wordDocument = appWord.Documents.Open(file);
                        string pdf = Path.ChangeExtension(file, ".pdf");
                        if (File.Exists(pdf)) {
                            MessageBox.Show("Файл \n\n" + pdf + "\n\nуже существует!\n\n\n\nПроцесс конвертации будет прекращён.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CloseAll(appWord, wordDocument);
                            isWordClosed = true;
                            break;
                        }
                        wordDocument.ExportAsFixedFormat(pdf, WdExportFormat.wdExportFormatPDF); // only if the file doesn't exist yet!
                        wordDocument.Close();
                        counter++;
                        lblConvertationProgress.Text = "Конвертировано " + counter + " из " + files.Length;
                        proBarConvertionProcess.Value += 1;
                    }
                }
                if (counter > 0)
                    MessageBox.Show("Процесс конвертации успешно закончен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cursor.Current = Cursors.Default;               

            if (!isWordClosed) //Объект COM, который был отделен от своего базового RCW, использоваться не может. 
                CloseAll(appWord, wordDocument);            
        }

        private void CloseAll(Microsoft.Office.Interop.Word.Application appWord, Microsoft.Office.Interop.Word.Document wordDocument) 
        {               
            appWord.Quit();
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(appWord);
            if (wordDocument != null)
                Marshal.ReleaseComObject(wordDocument);
            Marshal.ReleaseComObject(appWord);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.Show();
        }

        private void chbSameFolder_CheckedChanged(object sender, EventArgs e)
        {
            bSameFolder = chbSameFolder.Checked;
            if (bSameFolder == true) {
                btnOpenDirectory.Text = "&Конвертировать WORD-документы в PDF";
                lblDirectoryPath.Text = strExePath;
            } 
            else {
                btnOpenDirectory.Text = "&Выберите папку с WORD-документами для их последующей конвертации в PDF";
                lblDirectoryPath.Text = string.Empty;
            }
        }
    }
}
