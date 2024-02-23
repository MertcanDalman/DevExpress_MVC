using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.NoDocuments;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_DevExp
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public RibbonForm1()
        {
            InitializeComponent();
            richEditControl1.Visible = false;

        }

        public void Open(object sender, EventArgs e)
        {
            richEditControl1.Visible = true;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Dosyaları|*.doc;*.docx|Tüm Dosyalar|*.*";
            openFileDialog.Title = "Word Dosyası Seç";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                // Dosyayı aç ve içeriğini yükle
                richEditControl1.LoadDocument(selectedFileName, DocumentFormat.OpenXml);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Dosyası (*.docx)|*.docx";
            saveFileDialog.Title = "Dosya Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFileName = saveFileDialog.FileName;

                // RichEditControl içeriğini dosyaya kaydet
                richEditControl1.SaveDocument(saveFileName, DocumentFormat.OpenXml);
                XtraMessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void richEditControl1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            richEditControl1.Text = "";

        }

        private void Print_Click(object sender, EventArgs e)
        {
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.ShowDialog();
            richEditControl1.Print();        
        }
    }
}