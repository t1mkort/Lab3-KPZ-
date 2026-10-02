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
    public partial class SubscribersForm : Form
    {
        private DbManager dbManager;
        private Logger logger;
        public SubscribersForm()
        {
            InitializeComponent();

            dbManager = DbManager.GetInstance();
            logger = Logger.GetInstance();

            cmbTariff.SelectedIndex = 0;

            dgvSubscribers.DataSource = dbManager.GetSubscribers();

            lblDbId.Text =
                "DbManager ID: " + dbManager.GetHashCode();

            lblLoggerId.Text =
                "Logger ID: " + logger.GetHashCode();
        }

        private void SubscribersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSubscribers_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.AddSubscriber(
                    txtNumber.Text,
                    txtFullName.Text,
                    cmbTariff.Text
                );

                logger.Log(
                    "Додано абонента: "
                    + txtFullName.Text
                    + ", номер: "
                    + txtNumber.Text
                );

                MessageBox.Show("Абонента додано.");

                txtNumber.Clear();
                txtFullName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindSubscriber_Click(object sender, EventArgs e)
        {
            var row = dbManager.FindSubscriber(txtSearchNumber.Text);

            if (row == null)
            {
                MessageBox.Show("Абонента не знайдено.");

                logger.Log(
                    "Пошук номера "
                    + txtSearchNumber.Text
                    + ": не знайдено"
                );

                return;
            }

            string info =
                "Номер: " + row["Номер"] +
                "\nПІБ: " + row["ПІБ"] +
                "\nТариф: " + row["Тариф"];

            MessageBox.Show(info);

            logger.Log(
                "Знайдено абонента з номером "
                + txtSearchNumber.Text
            );
        }
    }
}
