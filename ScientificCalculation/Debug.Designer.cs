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
            this.listviewMainRec = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageARec = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPageBRec = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tabPageCRec = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.tabPageDRec = new System.Windows.Forms.TabPage();
            this.listView5 = new System.Windows.Forms.ListView();
            this.tabPageERec = new System.Windows.Forms.TabPage();
            this.listView6 = new System.Windows.Forms.ListView();
            this.tabPageFRec = new System.Windows.Forms.TabPage();
            this.listView7 = new System.Windows.Forms.ListView();
            this.btn_auto_log_clean = new System.Windows.Forms.Button();
            this.tmr_auto_logs_clean = new System.Windows.Forms.Timer(this.components);
            this.btn_logs = new System.Windows.Forms.Button();
            this.btn_screens = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageMainRec.SuspendLayout();
            this.tabPageARec.SuspendLayout();
            this.tabPageBRec.SuspendLayout();
            this.tabPageCRec.SuspendLayout();
            this.tabPageDRec.SuspendLayout();
            this.tabPageERec.SuspendLayout();
            this.tabPageFRec.SuspendLayout();
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
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
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
            this.tabPageMainRec.Controls.Add(this.listviewMainRec);
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
            // listviewMainRec
            // 
            this.listviewMainRec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            resources.ApplyResources(this.listviewMainRec, "listviewMainRec");
            this.listviewMainRec.Name = "listviewMainRec";
            this.listviewMainRec.UseCompatibleStateImageBehavior = false;
            this.listviewMainRec.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // tabPageARec
            // 
            this.tabPageARec.Controls.Add(this.listView2);
            resources.ApplyResources(this.tabPageARec, "tabPageARec");
            this.tabPageARec.Name = "tabPageARec";
            this.tabPageARec.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            resources.ApplyResources(this.listView2, "listView2");
            this.listView2.Name = "listView2";
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageBRec
            // 
            this.tabPageBRec.Controls.Add(this.listView3);
            resources.ApplyResources(this.tabPageBRec, "tabPageBRec");
            this.tabPageBRec.Name = "tabPageBRec";
            this.tabPageBRec.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            resources.ApplyResources(this.listView3, "listView3");
            this.listView3.Name = "listView3";
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageCRec
            // 
            this.tabPageCRec.Controls.Add(this.listView4);
            resources.ApplyResources(this.tabPageCRec, "tabPageCRec");
            this.tabPageCRec.Name = "tabPageCRec";
            this.tabPageCRec.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            resources.ApplyResources(this.listView4, "listView4");
            this.listView4.Name = "listView4";
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageDRec
            // 
            this.tabPageDRec.Controls.Add(this.listView5);
            resources.ApplyResources(this.tabPageDRec, "tabPageDRec");
            this.tabPageDRec.Name = "tabPageDRec";
            this.tabPageDRec.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            resources.ApplyResources(this.listView5, "listView5");
            this.listView5.Name = "listView5";
            this.listView5.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageERec
            // 
            this.tabPageERec.Controls.Add(this.listView6);
            resources.ApplyResources(this.tabPageERec, "tabPageERec");
            this.tabPageERec.Name = "tabPageERec";
            this.tabPageERec.UseVisualStyleBackColor = true;
            // 
            // listView6
            // 
            resources.ApplyResources(this.listView6, "listView6");
            this.listView6.Name = "listView6";
            this.listView6.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageFRec
            // 
            this.tabPageFRec.Controls.Add(this.listView7);
            resources.ApplyResources(this.tabPageFRec, "tabPageFRec");
            this.tabPageFRec.Name = "tabPageFRec";
            this.tabPageFRec.UseVisualStyleBackColor = true;
            // 
            // listView7
            // 
            resources.ApplyResources(this.listView7, "listView7");
            this.listView7.Name = "listView7";
            this.listView7.UseCompatibleStateImageBehavior = false;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Debug_FormClosing);
            this.Load += new System.EventHandler(this.Debug_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMainRec.ResumeLayout(false);
            this.tabPageMainRec.PerformLayout();
            this.tabPageARec.ResumeLayout(false);
            this.tabPageBRec.ResumeLayout(false);
            this.tabPageCRec.ResumeLayout(false);
            this.tabPageDRec.ResumeLayout(false);
            this.tabPageERec.ResumeLayout(false);
            this.tabPageFRec.ResumeLayout(false);
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
        private System.Windows.Forms.ListView listviewMainRec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ListView listView7;
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
    }
}