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
    public partial class LoggerForm : Form
    {
        private Logger logger;
        public LoggerForm()
        {
            InitializeComponent();

            logger = Logger.GetInstance();

            lblLoggerId.Text =
                "Logger ID: " + logger.GetHashCode();
        }

        private void LoggerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
                return;

            logger.Log(txtMessage.Text);

            txtMessage.Clear();
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();

            foreach (string item in logger.GetStrings())
            {
                lstLog.Items.Add(item);
            }
        }
    }
}
