namespace Лабораторна_робота__3__КПЗ_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubscribers = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnLogger = new System.Windows.Forms.Button();
            this.lblDbId = new System.Windows.Forms.Label();
            this.lblSaverId = new System.Windows.Forms.Label();
            this.lblLoggerId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Телефонний вузол";
            // 
            // btnSubscribers
            // 
            this.btnSubscribers.Location = new System.Drawing.Point(12, 54);
            this.btnSubscribers.Name = "btnSubscribers";
            this.btnSubscribers.Size = new System.Drawing.Size(292, 23);
            this.btnSubscribers.TabIndex = 1;
            this.btnSubscribers.Text = "Абоненти";
            this.btnSubscribers.UseVisualStyleBackColor = true;
            this.btnSubscribers.Click += new System.EventHandler(this.btnSubscribers_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(12, 83);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(292, 23);
            this.btnDocuments.TabIndex = 2;
            this.btnDocuments.Text = "Документи";
            this.btnDocuments.UseVisualStyleBackColor = true;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnLogger
            // 
            this.btnLogger.Location = new System.Drawing.Point(12, 112);
            this.btnLogger.Name = "btnLogger";
            this.btnLogger.Size = new System.Drawing.Size(292, 23);
            this.btnLogger.TabIndex = 3;
            this.btnLogger.Text = "Журнал";
            this.btnLogger.UseVisualStyleBackColor = true;
            this.btnLogger.Click += new System.EventHandler(this.btnLogger_Click);
            // 
            // lblDbId
            // 
            this.lblDbId.AutoSize = true;
            this.lblDbId.Location = new System.Drawing.Point(24, 173);
            this.lblDbId.Name = "lblDbId";
            this.lblDbId.Size = new System.Drawing.Size(35, 13);
            this.lblDbId.TabIndex = 4;
            this.lblDbId.Text = "label2";
            // 
            // lblSaverId
            // 
            this.lblSaverId.AutoSize = true;
            this.lblSaverId.Location = new System.Drawing.Point(24, 195);
            this.lblSaverId.Name = "lblSaverId";
            this.lblSaverId.Size = new System.Drawing.Size(35, 13);
            this.lblSaverId.TabIndex = 5;
            this.lblSaverId.Text = "label3";
            // 
            // lblLoggerId
            // 
            this.lblLoggerId.AutoSize = true;
            this.lblLoggerId.Location = new System.Drawing.Point(24, 217);
            this.lblLoggerId.Name = "lblLoggerId";
            this.lblLoggerId.Size = new System.Drawing.Size(35, 13);
            this.lblLoggerId.TabIndex = 6;
            this.lblLoggerId.Text = "label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 282);
            this.Controls.Add(this.lblLoggerId);
            this.Controls.Add(this.lblSaverId);
            this.Controls.Add(this.lblDbId);
            this.Controls.Add(this.btnLogger);
            this.Controls.Add(this.btnDocuments);
            this.Controls.Add(this.btnSubscribers);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Телефонний вузол - Singleton";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubscribers;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnLogger;
        private System.Windows.Forms.Label lblDbId;
        private System.Windows.Forms.Label lblSaverId;
        private System.Windows.Forms.Label lblLoggerId;
    }
}

