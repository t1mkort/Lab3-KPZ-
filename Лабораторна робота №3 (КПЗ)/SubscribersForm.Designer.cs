namespace Лабораторна_робота__3__КПЗ_
{
    partial class SubscribersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtSearchNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTariff = new System.Windows.Forms.ComboBox();
            this.btnAddSubscribers = new System.Windows.Forms.Button();
            this.dgvSubscribers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDbId = new System.Windows.Forms.Label();
            this.lblLoggerId = new System.Windows.Forms.Label();
            this.btnFindSubscriber = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(21, 41);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(318, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(21, 97);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(318, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // txtSearchNumber
            // 
            this.txtSearchNumber.Location = new System.Drawing.Point(362, 41);
            this.txtSearchNumber.Name = "txtSearchNumber";
            this.txtSearchNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ПІБ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тариф:";
            // 
            // cmbTariff
            // 
            this.cmbTariff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTariff.FormattingEnabled = true;
            this.cmbTariff.Items.AddRange(new object[] {
            "Базовий",
            "Стандарт",
            "Преміум"});
            this.cmbTariff.Location = new System.Drawing.Point(21, 146);
            this.cmbTariff.Name = "cmbTariff";
            this.cmbTariff.Size = new System.Drawing.Size(318, 21);
            this.cmbTariff.TabIndex = 5;
            // 
            // btnAddSubscribers
            // 
            this.btnAddSubscribers.Location = new System.Drawing.Point(21, 173);
            this.btnAddSubscribers.Name = "btnAddSubscribers";
            this.btnAddSubscribers.Size = new System.Drawing.Size(121, 23);
            this.btnAddSubscribers.TabIndex = 6;
            this.btnAddSubscribers.Text = "Додати абонента";
            this.btnAddSubscribers.UseVisualStyleBackColor = true;
            this.btnAddSubscribers.Click += new System.EventHandler(this.btnAddSubscribers_Click);
            // 
            // dgvSubscribers
            // 
            this.dgvSubscribers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscribers.Location = new System.Drawing.Point(21, 212);
            this.dgvSubscribers.Name = "dgvSubscribers";
            this.dgvSubscribers.Size = new System.Drawing.Size(454, 214);
            this.dgvSubscribers.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пошук за номером:";
            // 
            // lblDbId
            // 
            this.lblDbId.AutoSize = true;
            this.lblDbId.Location = new System.Drawing.Point(359, 110);
            this.lblDbId.Name = "lblDbId";
            this.lblDbId.Size = new System.Drawing.Size(40, 13);
            this.lblDbId.TabIndex = 9;
            this.lblDbId.Text = "lblDbId";
            // 
            // lblLoggerId
            // 
            this.lblLoggerId.AutoSize = true;
            this.lblLoggerId.Location = new System.Drawing.Point(359, 133);
            this.lblLoggerId.Name = "lblLoggerId";
            this.lblLoggerId.Size = new System.Drawing.Size(59, 13);
            this.lblLoggerId.TabIndex = 10;
            this.lblLoggerId.Text = "lblLoggerId";
            // 
            // btnFindSubscriber
            // 
            this.btnFindSubscriber.Location = new System.Drawing.Point(362, 67);
            this.btnFindSubscriber.Name = "btnFindSubscriber";
            this.btnFindSubscriber.Size = new System.Drawing.Size(75, 23);
            this.btnFindSubscriber.TabIndex = 11;
            this.btnFindSubscriber.Text = "Знайти";
            this.btnFindSubscriber.UseVisualStyleBackColor = true;
            this.btnFindSubscriber.Click += new System.EventHandler(this.btnFindSubscriber_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Номер:";
            // 
            // SubscribersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 442);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFindSubscriber);
            this.Controls.Add(this.lblLoggerId);
            this.Controls.Add(this.lblDbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSubscribers);
            this.Controls.Add(this.btnAddSubscribers);
            this.Controls.Add(this.cmbTariff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtNumber);
            this.Name = "SubscribersForm";
            this.Text = "SubscribersForm";
            this.Load += new System.EventHandler(this.SubscribersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtSearchNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTariff;
        private System.Windows.Forms.Button btnAddSubscribers;
        private System.Windows.Forms.DataGridView dgvSubscribers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDbId;
        private System.Windows.Forms.Label lblLoggerId;
        private System.Windows.Forms.Button btnFindSubscriber;
        private System.Windows.Forms.Label label6;
    }
}