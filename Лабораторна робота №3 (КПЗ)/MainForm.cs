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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            lblDbId.Text =
                "DbManager ID: "
                + DbManager.GetInstance().GetHashCode();

            lblSaverId.Text =
                "DocumentSaver ID: "
                + DocumentSaver.GetInstance().GetHashCode();

            lblLoggerId.Text =
                "Logger ID: "
                + Logger.GetInstance().GetHashCode();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubscribers_Click(object sender, EventArgs e)
        {
            SubscribersForm form = new SubscribersForm();
            form.Show();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            DocumentsForm form = new DocumentsForm();
            form.Show();
        }

        private void btnLogger_Click(object sender, EventArgs e)
        {
            LoggerForm form = new LoggerForm();
            form.Show();
        }
    }
}
