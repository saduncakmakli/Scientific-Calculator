namespace ScientificCalculation
{
    partial class Debug
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debug));
            this.lB_logs = new System.Windows.Forms.ListBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_auto_refresh = new System.Windows.Forms.Button();
            this.tmr_auto_refresh = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMainRec = new System.Windows.Forms.TabPage();
            this.lblMainScreen = new System.Windows.Forms.Label();
            this.tbMainSonuc = new System.Windows.Forms.TextBox();
            this.tbMainIslem = new System.Windows.Forms.TextBox();
            this.lblMainRecTemporaryProcessingPriority = new System.Windows.Forms.Label();
            this.lblMainRecWhichBracket = new System.Windows.Forms.Label();
            this.lblMainRecWhichOperation = new System.Windows.Forms.Label();
            this.lblMainRecWhichNumber = new System.Windows.Forms.Label();
            this.lblMainRecIsOperationHavePermit = new System.Windows.Forms.Label();
            this.lblMainRecIsHaveNegativeBracket = new System.Windows.Forms.Label();
            this.lblMainRecIsHaveComma = new System.Windows.Forms.Label();
            this.lblMainRecIsHaveOperation = new System.Windows.Forms.Label();
            this.lblMainRecIsHaveNumber = new System.Windows.Forms.Label();
            this.lblMainRecIsFirstStart = new System.Windows.Forms.Label();
            this.tabPageARec = new System.Windows.Forms.TabPage();
            this.lblRecATemporaryProcessingPriority = new System.Windows.Forms.Label();
            this.lblRecAWhichBracket = new System.Windows.Forms.Label();
            this.lblRecAWhichOperation = new System.Windows.Forms.Label();
            this.lblRecAWhichNumber = new System.Windows.Forms.Label();
            this.lblRecAIsOperationHavePermit = new System.Windows.Forms.Label();
            this.lblRecAIsHaveNegativeBracket = new System.Windows.Forms.Label();
            this.lblRecAIsHaveComma = new System.Windows.Forms.Label();
            this.lblRecAIsHaveOperation = new System.Windows.Forms.Label();
            this.lblRecAIsHaveNumber = new System.Windows.Forms.Label();
            this.lblRecAIsFirstStart = new System.Windows.Forms.Label();
            this.listviewRecANumbers = new System.Windows.Forms.ListView();
            this.Numbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewRecAOperation = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewRecAProcessPiority = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageBRec = new System.Windows.Forms.TabPage();
            this.tabPageCRec = new System.Windows.Forms.TabPage();
            this.tabPageDRec = new System.Windows.Forms.TabPage();
            this.tabPageERec = new System.Windows.Forms.TabPage();
            this.tabPageFRec = new System.Windows.Forms.TabPage();
            this.btn_auto_log_clean = new System.Windows.Forms.Button();
            this.tmr_auto_logs_clean = new System.Windows.Forms.Timer(this.components);
            this.btn_logs = new System.Windows.Forms.Button();
            this.btn_screens = new System.Windows.Forms.Button();
            this.listviewMainRecNumbers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewMainRecOperation = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewMainRecProcessPiority = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageMainRec.SuspendLayout();
            this.tabPageARec.SuspendLayout();
            this.SuspendLayout();
            // 
            // lB_logs
            // 
            this.lB_logs.FormattingEnabled = true;
            resources.ApplyResources(this.lB_logs, "lB_logs");
            this.lB_logs.Name = "lB_logs";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.btn_refresh, "btn_refresh");
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.RefreshAll);
            // 
            // btn_auto_refresh
            // 
            this.btn_auto_refresh.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.btn_auto_refresh, "btn_auto_refresh");
            this.btn_auto_refresh.Name = "btn_auto_refresh";
            this.btn_auto_refresh.UseVisualStyleBackColor = false;
            this.btn_auto_refresh.Click += new System.EventHandler(this.btn_auto_refresh_Click);
            // 
            // tmr_auto_refresh
            // 
            this.tmr_auto_refresh.Interval = 1000;
            this.tmr_auto_refresh.Tick += new System.EventHandler(this.tmr_auto_refresh_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMainRec);
            this.tabControl1.Controls.Add(this.tabPageARec);
            this.tabControl1.Controls.Add(this.tabPageBRec);
            this.tabControl1.Controls.Add(this.tabPageCRec);
            this.tabControl1.Controls.Add(this.tabPageDRec);
            this.tabControl1.Controls.Add(this.tabPageERec);
            this.tabControl1.Controls.Add(this.tabPageFRec);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPageMainRec
            // 
            this.tabPageMainRec.Controls.Add(this.listviewMainRecNumbers);
            this.tabPageMainRec.Controls.Add(this.listviewMainRecOperation);
            this.tabPageMainRec.Controls.Add(this.listviewMainRecProcessPiority);
            this.tabPageMainRec.Controls.Add(this.lblMainScreen);
            this.tabPageMainRec.Controls.Add(this.tbMainSonuc);
            this.tabPageMainRec.Controls.Add(this.tbMainIslem);
            this.tabPageMainRec.Controls.Add(this.lblMainRecTemporaryProcessingPriority);
            this.tabPageMainRec.Controls.Add(this.lblMainRecWhichBracket);
            this.tabPageMainRec.Controls.Add(this.lblMainRecWhichOperation);
            this.tabPageMainRec.Controls.Add(this.lblMainRecWhichNumber);
            this.tabPageMainRec.Controls.Add(this.lblMainRecIsOperationHavePermit);
            this.tabPageMainRec.Controls.Add(this.lblMainRecIsHaveNegativeBracket);
            this.tabPageMainRec.Controls.Add(this.lblMainRecIsHaveComma);
            this.tabPageMainRec.Controls.Add(this.lblMainRecIsHaveOperation);
            this.tabPageMainRec.Controls.Add(this.lblMainRecIsHaveNumber);
            this.tabPageMainRec.Controls.Add(this.lblMainRecIsFirstStart);
            resources.ApplyResources(this.tabPageMainRec, "tabPageMainRec");
            this.tabPageMainRec.Name = "tabPageMainRec";
            this.tabPageMainRec.UseVisualStyleBackColor = true;
            // 
            // lblMainScreen
            // 
            resources.ApplyResources(this.lblMainScreen, "lblMainScreen");
            this.lblMainScreen.Name = "lblMainScreen";
            // 
            // tbMainSonuc
            // 
            resources.ApplyResources(this.tbMainSonuc, "tbMainSonuc");
            this.tbMainSonuc.Name = "tbMainSonuc";
            this.tbMainSonuc.ReadOnly = true;
            // 
            // tbMainIslem
            // 
            resources.ApplyResources(this.tbMainIslem, "tbMainIslem");
            this.tbMainIslem.Name = "tbMainIslem";
            this.tbMainIslem.ReadOnly = true;
            // 
            // lblMainRecTemporaryProcessingPriority
            // 
            resources.ApplyResources(this.lblMainRecTemporaryProcessingPriority, "lblMainRecTemporaryProcessingPriority");
            this.lblMainRecTemporaryProcessingPriority.Name = "lblMainRecTemporaryProcessingPriority";
            // 
            // lblMainRecWhichBracket
            // 
            resources.ApplyResources(this.lblMainRecWhichBracket, "lblMainRecWhichBracket");
            this.lblMainRecWhichBracket.Name = "lblMainRecWhichBracket";
            // 
            // lblMainRecWhichOperation
            // 
            resources.ApplyResources(this.lblMainRecWhichOperation, "lblMainRecWhichOperation");
            this.lblMainRecWhichOperation.Name = "lblMainRecWhichOperation";
            // 
            // lblMainRecWhichNumber
            // 
            resources.ApplyResources(this.lblMainRecWhichNumber, "lblMainRecWhichNumber");
            this.lblMainRecWhichNumber.Name = "lblMainRecWhichNumber";
            // 
            // lblMainRecIsOperationHavePermit
            // 
            resources.ApplyResources(this.lblMainRecIsOperationHavePermit, "lblMainRecIsOperationHavePermit");
            this.lblMainRecIsOperationHavePermit.Name = "lblMainRecIsOperationHavePermit";
            // 
            // lblMainRecIsHaveNegativeBracket
            // 
            resources.ApplyResources(this.lblMainRecIsHaveNegativeBracket, "lblMainRecIsHaveNegativeBracket");
            this.lblMainRecIsHaveNegativeBracket.Name = "lblMainRecIsHaveNegativeBracket";
            // 
            // lblMainRecIsHaveComma
            // 
            resources.ApplyResources(this.lblMainRecIsHaveComma, "lblMainRecIsHaveComma");
            this.lblMainRecIsHaveComma.Name = "lblMainRecIsHaveComma";
            // 
            // lblMainRecIsHaveOperation
            // 
            resources.ApplyResources(this.lblMainRecIsHaveOperation, "lblMainRecIsHaveOperation");
            this.lblMainRecIsHaveOperation.Name = "lblMainRecIsHaveOperation";
            // 
            // lblMainRecIsHaveNumber
            // 
            resources.ApplyResources(this.lblMainRecIsHaveNumber, "lblMainRecIsHaveNumber");
            this.lblMainRecIsHaveNumber.Name = "lblMainRecIsHaveNumber";
            // 
            // lblMainRecIsFirstStart
            // 
            resources.ApplyResources(this.lblMainRecIsFirstStart, "lblMainRecIsFirstStart");
            this.lblMainRecIsFirstStart.Name = "lblMainRecIsFirstStart";
            // 
            // tabPageARec
            // 
            this.tabPageARec.Controls.Add(this.lblRecATemporaryProcessingPriority);
            this.tabPageARec.Controls.Add(this.lblRecAWhichBracket);
            this.tabPageARec.Controls.Add(this.lblRecAWhichOperation);
            this.tabPageARec.Controls.Add(this.lblRecAWhichNumber);
            this.tabPageARec.Controls.Add(this.lblRecAIsOperationHavePermit);
            this.tabPageARec.Controls.Add(this.lblRecAIsHaveNegativeBracket);
            this.tabPageARec.Controls.Add(this.lblRecAIsHaveComma);
            this.tabPageARec.Controls.Add(this.lblRecAIsHaveOperation);
            this.tabPageARec.Controls.Add(this.lblRecAIsHaveNumber);
            this.tabPageARec.Controls.Add(this.lblRecAIsFirstStart);
            this.tabPageARec.Controls.Add(this.listviewRecANumbers);
            this.tabPageARec.Controls.Add(this.listviewRecAOperation);
            this.tabPageARec.Controls.Add(this.listviewRecAProcessPiority);
            resources.ApplyResources(this.tabPageARec, "tabPageARec");
            this.tabPageARec.Name = "tabPageARec";
            this.tabPageARec.UseVisualStyleBackColor = true;
            // 
            // lblRecATemporaryProcessingPriority
            // 
            resources.ApplyResources(this.lblRecATemporaryProcessingPriority, "lblRecATemporaryProcessingPriority");
            this.lblRecATemporaryProcessingPriority.Name = "lblRecATemporaryProcessingPriority";
            // 
            // lblRecAWhichBracket
            // 
            resources.ApplyResources(this.lblRecAWhichBracket, "lblRecAWhichBracket");
            this.lblRecAWhichBracket.Name = "lblRecAWhichBracket";
            // 
            // lblRecAWhichOperation
            // 
            resources.ApplyResources(this.lblRecAWhichOperation, "lblRecAWhichOperation");
            this.lblRecAWhichOperation.Name = "lblRecAWhichOperation";
            // 
            // lblRecAWhichNumber
            // 
            resources.ApplyResources(this.lblRecAWhichNumber, "lblRecAWhichNumber");
            this.lblRecAWhichNumber.Name = "lblRecAWhichNumber";
            // 
            // lblRecAIsOperationHavePermit
            // 
            resources.ApplyResources(this.lblRecAIsOperationHavePermit, "lblRecAIsOperationHavePermit");
            this.lblRecAIsOperationHavePermit.Name = "lblRecAIsOperationHavePermit";
            // 
            // lblRecAIsHaveNegativeBracket
            // 
            resources.ApplyResources(this.lblRecAIsHaveNegativeBracket, "lblRecAIsHaveNegativeBracket");
            this.lblRecAIsHaveNegativeBracket.Name = "lblRecAIsHaveNegativeBracket";
            // 
            // lblRecAIsHaveComma
            // 
            resources.ApplyResources(this.lblRecAIsHaveComma, "lblRecAIsHaveComma");
            this.lblRecAIsHaveComma.Name = "lblRecAIsHaveComma";
            // 
            // lblRecAIsHaveOperation
            // 
            resources.ApplyResources(this.lblRecAIsHaveOperation, "lblRecAIsHaveOperation");
            this.lblRecAIsHaveOperation.Name = "lblRecAIsHaveOperation";
            // 
            // lblRecAIsHaveNumber
            // 
            resources.ApplyResources(this.lblRecAIsHaveNumber, "lblRecAIsHaveNumber");
            this.lblRecAIsHaveNumber.Name = "lblRecAIsHaveNumber";
            // 
            // lblRecAIsFirstStart
            // 
            resources.ApplyResources(this.lblRecAIsFirstStart, "lblRecAIsFirstStart");
            this.lblRecAIsFirstStart.Name = "lblRecAIsFirstStart";
            // 
            // listviewRecANumbers
            // 
            this.listviewRecANumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numbers});
            resources.ApplyResources(this.listviewRecANumbers, "listviewRecANumbers");
            this.listviewRecANumbers.Name = "listviewRecANumbers";
            this.listviewRecANumbers.UseCompatibleStateImageBehavior = false;
            this.listviewRecANumbers.View = System.Windows.Forms.View.Details;
            // 
            // Numbers
            // 
            this.Numbers.Tag = "";
            resources.ApplyResources(this.Numbers, "Numbers");
            // 
            // listviewRecAOperation
            // 
            this.listviewRecAOperation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            resources.ApplyResources(this.listviewRecAOperation, "listviewRecAOperation");
            this.listviewRecAOperation.Name = "listviewRecAOperation";
            this.listviewRecAOperation.UseCompatibleStateImageBehavior = false;
            this.listviewRecAOperation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // listviewRecAProcessPiority
            // 
            this.listviewRecAProcessPiority.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            resources.ApplyResources(this.listviewRecAProcessPiority, "listviewRecAProcessPiority");
            this.listviewRecAProcessPiority.Name = "listviewRecAProcessPiority";
            this.listviewRecAProcessPiority.UseCompatibleStateImageBehavior = false;
            this.listviewRecAProcessPiority.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // tabPageBRec
            // 
            resources.ApplyResources(this.tabPageBRec, "tabPageBRec");
            this.tabPageBRec.Name = "tabPageBRec";
            this.tabPageBRec.UseVisualStyleBackColor = true;
            // 
            // tabPageCRec
            // 
            resources.ApplyResources(this.tabPageCRec, "tabPageCRec");
            this.tabPageCRec.Name = "tabPageCRec";
            this.tabPageCRec.UseVisualStyleBackColor = true;
            // 
            // tabPageDRec
            // 
            resources.ApplyResources(this.tabPageDRec, "tabPageDRec");
            this.tabPageDRec.Name = "tabPageDRec";
            this.tabPageDRec.UseVisualStyleBackColor = true;
            // 
            // tabPageERec
            // 
            resources.ApplyResources(this.tabPageERec, "tabPageERec");
            this.tabPageERec.Name = "tabPageERec";
            this.tabPageERec.UseVisualStyleBackColor = true;
            // 
            // tabPageFRec
            // 
            resources.ApplyResources(this.tabPageFRec, "tabPageFRec");
            this.tabPageFRec.Name = "tabPageFRec";
            this.tabPageFRec.UseVisualStyleBackColor = true;
            // 
            // btn_auto_log_clean
            // 
            this.btn_auto_log_clean.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.btn_auto_log_clean, "btn_auto_log_clean");
            this.btn_auto_log_clean.Name = "btn_auto_log_clean";
            this.btn_auto_log_clean.UseVisualStyleBackColor = false;
            this.btn_auto_log_clean.Click += new System.EventHandler(this.btn_auto_log_clean_Click);
            // 
            // tmr_auto_logs_clean
            // 
            this.tmr_auto_logs_clean.Interval = 1000;
            this.tmr_auto_logs_clean.Tick += new System.EventHandler(this.tmr_auto_logs_clean_Tick);
            // 
            // btn_logs
            // 
            this.btn_logs.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.btn_logs, "btn_logs");
            this.btn_logs.Name = "btn_logs";
            this.btn_logs.UseVisualStyleBackColor = false;
            this.btn_logs.Click += new System.EventHandler(this.btn_logs_Click);
            // 
            // btn_screens
            // 
            this.btn_screens.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.btn_screens, "btn_screens");
            this.btn_screens.Name = "btn_screens";
            this.btn_screens.UseVisualStyleBackColor = false;
            this.btn_screens.Click += new System.EventHandler(this.btn_screens_Click);
            // 
            // listviewMainRecNumbers
            // 
            this.listviewMainRecNumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            resources.ApplyResources(this.listviewMainRecNumbers, "listviewMainRecNumbers");
            this.listviewMainRecNumbers.Name = "listviewMainRecNumbers";
            this.listviewMainRecNumbers.UseCompatibleStateImageBehavior = false;
            this.listviewMainRecNumbers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // listviewMainRecOperation
            // 
            this.listviewMainRecOperation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            resources.ApplyResources(this.listviewMainRecOperation, "listviewMainRecOperation");
            this.listviewMainRecOperation.Name = "listviewMainRecOperation";
            this.listviewMainRecOperation.UseCompatibleStateImageBehavior = false;
            this.listviewMainRecOperation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // listviewMainRecProcessPiority
            // 
            this.listviewMainRecProcessPiority.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            resources.ApplyResources(this.listviewMainRecProcessPiority, "listviewMainRecProcessPiority");
            this.listviewMainRecProcessPiority.Name = "listviewMainRecProcessPiority";
            this.listviewMainRecProcessPiority.UseCompatibleStateImageBehavior = false;
            this.listviewMainRecProcessPiority.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // Debug
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_screens);
            this.Controls.Add(this.btn_logs);
            this.Controls.Add(this.btn_auto_log_clean);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_auto_refresh);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lB_logs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Debug";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Debug_FormClosing);
            this.Load += new System.EventHandler(this.Debug_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMainRec.ResumeLayout(false);
            this.tabPageMainRec.PerformLayout();
            this.tabPageARec.ResumeLayout(false);
            this.tabPageARec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lB_logs;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_auto_refresh;
        private System.Windows.Forms.Timer tmr_auto_refresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMainRec;
        private System.Windows.Forms.TabPage tabPageARec;
        private System.Windows.Forms.TabPage tabPageBRec;
        private System.Windows.Forms.TabPage tabPageCRec;
        private System.Windows.Forms.TabPage tabPageDRec;
        private System.Windows.Forms.TabPage tabPageERec;
        private System.Windows.Forms.TabPage tabPageFRec;
        private System.Windows.Forms.Label lblMainRecWhichNumber;
        private System.Windows.Forms.Label lblMainRecIsOperationHavePermit;
        private System.Windows.Forms.Label lblMainRecIsHaveNegativeBracket;
        private System.Windows.Forms.Label lblMainRecIsHaveComma;
        private System.Windows.Forms.Label lblMainRecIsHaveOperation;
        private System.Windows.Forms.Label lblMainRecIsHaveNumber;
        private System.Windows.Forms.Label lblMainRecIsFirstStart;
        private System.Windows.Forms.Label lblMainRecWhichBracket;
        private System.Windows.Forms.Label lblMainRecWhichOperation;
        private System.Windows.Forms.Label lblMainRecTemporaryProcessingPriority;
        private System.Windows.Forms.Button btn_auto_log_clean;
        private System.Windows.Forms.Timer tmr_auto_logs_clean;
        private System.Windows.Forms.TextBox tbMainIslem;
        private System.Windows.Forms.Label lblMainScreen;
        private System.Windows.Forms.TextBox tbMainSonuc;
        private System.Windows.Forms.Button btn_logs;
        private System.Windows.Forms.Button btn_screens;
        private System.Windows.Forms.ListView listviewRecANumbers;
        private System.Windows.Forms.ListView listviewRecAOperation;
        private System.Windows.Forms.ListView listviewRecAProcessPiority;
        private System.Windows.Forms.Label lblRecATemporaryProcessingPriority;
        private System.Windows.Forms.Label lblRecAWhichBracket;
        private System.Windows.Forms.Label lblRecAWhichOperation;
        private System.Windows.Forms.Label lblRecAWhichNumber;
        private System.Windows.Forms.Label lblRecAIsOperationHavePermit;
        private System.Windows.Forms.Label lblRecAIsHaveNegativeBracket;
        private System.Windows.Forms.Label lblRecAIsHaveComma;
        private System.Windows.Forms.Label lblRecAIsHaveOperation;
        private System.Windows.Forms.Label lblRecAIsHaveNumber;
        private System.Windows.Forms.Label lblRecAIsFirstStart;
        private System.Windows.Forms.ColumnHeader Numbers;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listviewMainRecNumbers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listviewMainRecOperation;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listviewMainRecProcessPiority;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}