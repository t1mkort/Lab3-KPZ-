using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonLibrary;

namespace Лабораторна_робота__3__КПЗ_
{
    public partial class DocumentsForm : Form
    {
        private DbManager dbManager;
        private DocumentSaver documentSaver;
        private Logger logger;
        public DocumentsForm()
        {
            InitializeComponent();

            dbManager = DbManager.GetInstance();
            documentSaver = DocumentSaver.GetInstance();
            logger = Logger.GetInstance();

            lblDbId.Text =
                "DbManager ID: " + dbManager.GetHashCode();

            lblSaverId.Text =
                "DocumentSaver ID: " + documentSaver.GetHashCode();

            lblLoggerId.Text =
                "Logger ID: " + logger.GetHashCode();

            UpdateDocumentList();
        }

        private void DocumentsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DataTable table = dbManager.GetSubscribers();

            StringBuilder report = new StringBuilder();

            report.AppendLine("ЗВІТ ТЕЛЕФОННОГО ВУЗЛА");
            report.AppendLine();
            report.AppendLine("Список абонентів:");
            report.AppendLine();

            foreach (DataRow row in table.Rows)
            {
                report.AppendLine(
                    "Номер: " + row["Номер"]
                    + "; ПІБ: " + row["ПІБ"]
                    + "; Тариф: " + row["Тариф"]
                );
            }

            rtbContent.Text = report.ToString();

            logger.Log("Сформовано звіт абонентів.");
        }

        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentName.Text))
            {
                MessageBox.Show("Введіть назву документа.");
                return;
            }

            string path = documentSaver.SaveDocument(
                txtDocumentName.Text,
                rtbContent.Text
            );

            logger.Log(
                "Збережено документ: " + txtDocumentName.Text
            );

            MessageBox.Show(
                "Документ збережено:\n" + path
            );

            UpdateDocumentList();
        }
        private void UpdateDocumentList()
        {
            lstDocuments.Items.Clear();

            foreach (string document in documentSaver.GetSavedDocuments())
            {
                lstDocuments.Items.Add(document);
            }
        }
    }
}
