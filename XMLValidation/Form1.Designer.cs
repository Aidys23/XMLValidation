namespace XMLValidation
{
    partial class Form1
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
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SaveTo = new System.Windows.Forms.Button();
            this.deleteLog = new System.Windows.Forms.Button();
            this.OpenLog = new System.Windows.Forms.Button();
            this.WorkDirectory = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.Label();
            this.XMLViewer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(13, 13);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.save.Location = new System.Drawing.Point(94, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // SaveTo
            // 
            this.SaveTo.Location = new System.Drawing.Point(175, 13);
            this.SaveTo.Name = "SaveTo";
            this.SaveTo.Size = new System.Drawing.Size(75, 23);
            this.SaveTo.TabIndex = 2;
            this.SaveTo.Text = "SaveTo";
            this.SaveTo.UseVisualStyleBackColor = true;
            this.SaveTo.Click += new System.EventHandler(this.SaveTo_Click);
            // 
            // deleteLog
            // 
            this.deleteLog.Location = new System.Drawing.Point(772, 13);
            this.deleteLog.Name = "deleteLog";
            this.deleteLog.Size = new System.Drawing.Size(75, 23);
            this.deleteLog.TabIndex = 3;
            this.deleteLog.Text = "Delete Log";
            this.deleteLog.UseVisualStyleBackColor = true;
            this.deleteLog.Click += new System.EventHandler(this.deleteLog_Click);
            // 
            // OpenLog
            // 
            this.OpenLog.Location = new System.Drawing.Point(853, 13);
            this.OpenLog.Name = "OpenLog";
            this.OpenLog.Size = new System.Drawing.Size(75, 23);
            this.OpenLog.TabIndex = 4;
            this.OpenLog.Text = "Open Log";
            this.OpenLog.UseVisualStyleBackColor = true;
            this.OpenLog.Click += new System.EventHandler(this.OpenLog_Click);
            // 
            // WorkDirectory
            // 
            this.WorkDirectory.AutoSize = true;
            this.WorkDirectory.Location = new System.Drawing.Point(256, 9);
            this.WorkDirectory.Name = "WorkDirectory";
            this.WorkDirectory.Size = new System.Drawing.Size(0, 13);
            this.WorkDirectory.TabIndex = 5;
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Location = new System.Drawing.Point(256, 26);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(0, 13);
            this.FilePath.TabIndex = 6;
            // 
            // XMLViewer
            // 
            this.XMLViewer.Location = new System.Drawing.Point(12, 42);
            this.XMLViewer.Name = "XMLViewer";
            this.XMLViewer.Size = new System.Drawing.Size(916, 668);
            this.XMLViewer.TabIndex = 7;
            this.XMLViewer.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 722);
            this.Controls.Add(this.XMLViewer);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.WorkDirectory);
            this.Controls.Add(this.OpenLog);
            this.Controls.Add(this.deleteLog);
            this.Controls.Add(this.SaveTo);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button SaveTo;
        private System.Windows.Forms.Button deleteLog;
        private System.Windows.Forms.Button OpenLog;
        private System.Windows.Forms.Label WorkDirectory;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.RichTextBox XMLViewer;
    }
}

