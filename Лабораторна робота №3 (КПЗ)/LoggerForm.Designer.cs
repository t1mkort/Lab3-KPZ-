namespace Лабораторна_робота__3__КПЗ_
{
    partial class LoggerForm
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAddLog = new System.Windows.Forms.Button();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.lblLoggerId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 22);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(174, 20);
            this.txtMessage.TabIndex = 0;
            // 
            // btnAddLog
            // 
            this.btnAddLog.Location = new System.Drawing.Point(12, 69);
            this.btnAddLog.Name = "btnAddLog";
            this.btnAddLog.Size = new System.Drawing.Size(100, 23);
            this.btnAddLog.TabIndex = 1;
            this.btnAddLog.Text = "Записати";
            this.btnAddLog.UseVisualStyleBackColor = true;
            this.btnAddLog.Click += new System.EventHandler(this.btnAddLog_Click);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Location = new System.Drawing.Point(12, 98);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(100, 23);
            this.btnShowLog.TabIndex = 2;
            this.btnShowLog.Text = "Показати журнал";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(12, 138);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(757, 95);
            this.lstLog.TabIndex = 3;
            // 
            // lblLoggerId
            // 
            this.lblLoggerId.AutoSize = true;
            this.lblLoggerId.Location = new System.Drawing.Point(12, 249);
            this.lblLoggerId.Name = "lblLoggerId";
            this.lblLoggerId.Size = new System.Drawing.Size(35, 13);
            this.lblLoggerId.TabIndex = 4;
            this.lblLoggerId.Text = "label1";
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 283);
            this.Controls.Add(this.lblLoggerId);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.btnAddLog);
            this.Controls.Add(this.txtMessage);
            this.Name = "LoggerForm";
            this.Text = "LoggerForm";
            this.Load += new System.EventHandler(this.LoggerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnAddLog;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label lblLoggerId;
    }
}