namespace Лабораторна_робота__3__КПЗ_
{
    partial class DocumentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentName = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnSaveDocument = new System.Windows.Forms.Button();
            this.lstDocuments = new System.Windows.Forms.ListBox();
            this.lblDbId = new System.Windows.Forms.Label();
            this.lblSaverId = new System.Windows.Forms.Label();
            this.lblLoggerId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва документа:";
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.Location = new System.Drawing.Point(16, 42);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.Size = new System.Drawing.Size(453, 20);
            this.txtDocumentName.TabIndex = 1;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(16, 87);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(453, 96);
            this.rtbContent.TabIndex = 2;
            this.rtbContent.Text = "";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(16, 201);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(180, 23);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Сформувати звіт абонентів";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnSaveDocument
            // 
            this.btnSaveDocument.Location = new System.Drawing.Point(16, 239);
            this.btnSaveDocument.Name = "btnSaveDocument";
            this.btnSaveDocument.Size = new System.Drawing.Size(180, 23);
            this.btnSaveDocument.TabIndex = 4;
            this.btnSaveDocument.Text = "Зберегти документ";
            this.btnSaveDocument.UseVisualStyleBackColor = true;
            this.btnSaveDocument.Click += new System.EventHandler(this.btnSaveDocument_Click);
            // 
            // lstDocuments
            // 
            this.lstDocuments.FormattingEnabled = true;
            this.lstDocuments.Location = new System.Drawing.Point(16, 278);
            this.lstDocuments.Name = "lstDocuments";
            this.lstDocuments.Size = new System.Drawing.Size(453, 95);
            this.lstDocuments.TabIndex = 5;
            // 
            // lblDbId
            // 
            this.lblDbId.AutoSize = true;
            this.lblDbId.Location = new System.Drawing.Point(16, 380);
            this.lblDbId.Name = "lblDbId";
            this.lblDbId.Size = new System.Drawing.Size(35, 13);
            this.lblDbId.TabIndex = 6;
            this.lblDbId.Text = "label2";
            // 
            // lblSaverId
            // 
            this.lblSaverId.AutoSize = true;
            this.lblSaverId.Location = new System.Drawing.Point(16, 402);
            this.lblSaverId.Name = "lblSaverId";
            this.lblSaverId.Size = new System.Drawing.Size(35, 13);
            this.lblSaverId.TabIndex = 7;
            this.lblSaverId.Text = "label3";
            // 
            // lblLoggerId
            // 
            this.lblLoggerId.AutoSize = true;
            this.lblLoggerId.Location = new System.Drawing.Point(16, 425);
            this.lblLoggerId.Name = "lblLoggerId";
            this.lblLoggerId.Size = new System.Drawing.Size(35, 13);
            this.lblLoggerId.TabIndex = 8;
            this.lblLoggerId.Text = "label4";
            // 
            // DocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.lblLoggerId);
            this.Controls.Add(this.lblSaverId);
            this.Controls.Add(this.lblDbId);
            this.Controls.Add(this.lstDocuments);
            this.Controls.Add(this.btnSaveDocument);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.txtDocumentName);
            this.Controls.Add(this.label1);
            this.Name = "DocumentsForm";
            this.Text = "DocumentsForm";
            this.Load += new System.EventHandler(this.DocumentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentName;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnSaveDocument;
        private System.Windows.Forms.ListBox lstDocuments;
        private System.Windows.Forms.Label lblDbId;
        private System.Windows.Forms.Label lblSaverId;
        private System.Windows.Forms.Label lblLoggerId;
    }
}