namespace kursovaVSP
{
    partial class Form1
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
            this.tbSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDest = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbInBothWays = new System.Windows.Forms.CheckBox();
            this.btnException = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.process1 = new System.Diagnostics.Process();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbExceptions = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.progBarStr = new System.Windows.Forms.ProgressBar();
            this.gbProgFirst = new System.Windows.Forms.GroupBox();
            this.gbProgFirst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSource
            // 
            this.tbSource.Enabled = false;
            this.tbSource.Location = new System.Drawing.Point(12, 69);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(247, 22);
            this.tbSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder:";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(266, 69);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(86, 23);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Brows";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(266, 142);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(86, 23);
            this.btnDest.TabIndex = 5;
            this.btnDest.Text = "Brows";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Folder:";
            // 
            // tbDest
            // 
            this.tbDest.Enabled = false;
            this.tbDest.Location = new System.Drawing.Point(12, 142);
            this.tbDest.Name = "tbDest";
            this.tbDest.Size = new System.Drawing.Size(247, 22);
            this.tbDest.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(948, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(948, 568);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(948, 539);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 29);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbInBothWays
            // 
            this.cbInBothWays.AutoSize = true;
            this.cbInBothWays.Location = new System.Drawing.Point(12, 193);
            this.cbInBothWays.Name = "cbInBothWays";
            this.cbInBothWays.Size = new System.Drawing.Size(119, 21);
            this.cbInBothWays.TabIndex = 9;
            this.cbInBothWays.Text = "In bouth ways!";
            this.cbInBothWays.UseVisualStyleBackColor = true;
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(812, 246);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(130, 23);
            this.btnException.TabIndex = 11;
            this.btnException.Text = "Brows exceptoins";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Exceptions:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // lbExceptions
            // 
            this.lbExceptions.FormattingEnabled = true;
            this.lbExceptions.ItemHeight = 16;
            this.lbExceptions.Location = new System.Drawing.Point(12, 275);
            this.lbExceptions.Name = "lbExceptions";
            this.lbExceptions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbExceptions.Size = new System.Drawing.Size(930, 292);
            this.lbExceptions.TabIndex = 13;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 574);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(236, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove Selected Exceptios";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // progBarStr
            // 
            this.progBarStr.Location = new System.Drawing.Point(7, 48);
            this.progBarStr.Name = "progBarStr";
            this.progBarStr.Size = new System.Drawing.Size(538, 23);
            this.progBarStr.TabIndex = 15;
            // 
            // gbProgFirst
            // 
            this.gbProgFirst.Controls.Add(this.progBarStr);
            this.gbProgFirst.Location = new System.Drawing.Point(465, 24);
            this.gbProgFirst.Name = "gbProgFirst";
            this.gbProgFirst.Size = new System.Drawing.Size(569, 84);
            this.gbProgFirst.TabIndex = 17;
            this.gbProgFirst.TabStop = false;
            this.gbProgFirst.Text = "Progress strigth way:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 620);
            this.Controls.Add(this.gbProgFirst);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbExceptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnException);
            this.Controls.Add(this.cbInBothWays);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDest);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbProgFirst.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbInBothWays;
        private System.Windows.Forms.Button btnException;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lbExceptions;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ProgressBar progBarStr;
        public System.Windows.Forms.GroupBox gbProgFirst;
    }
}

