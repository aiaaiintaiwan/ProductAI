namespace CheckoutSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeLB = new System.Windows.Forms.Label();
            this.imgMSLB = new System.Windows.Forms.Label();
            this.yoloMSLB = new System.Windows.Forms.Label();
            this.addLB = new System.Windows.Forms.Label();
            this.contCapChk = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalLB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.viewSC = new System.Windows.Forms.SplitContainer();
            this.waitTimeNud = new System.Windows.Forms.NumericUpDown();
            this.confidenceChk = new System.Windows.Forms.CheckBox();
            this.captionLB = new System.Windows.Forms.Label();
            this.mainSC = new System.Windows.Forms.SplitContainer();
            this.container = new System.Windows.Forms.Panel();
            this.capAFBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveImgBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.ctrlVisibleLB = new System.Windows.Forms.Label();
            this.waitThd = new System.ComponentModel.BackgroundWorker();
            this.historyListBox = new CheckoutSystem.HistoryListBox();
            this.addListBox = new CheckoutSystem.PersonListBox();
            this.itemListBox = new CheckoutSystem.PersonListBox();
            this.testLB = new CheckoutSystem.PersonLabel();
            this.checkoutBtn = new CheckoutSystem.PersonButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSC)).BeginInit();
            this.viewSC.Panel1.SuspendLayout();
            this.viewSC.Panel2.SuspendLayout();
            this.viewSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitTimeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSC)).BeginInit();
            this.mainSC.Panel1.SuspendLayout();
            this.mainSC.Panel2.SuspendLayout();
            this.mainSC.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.timeLB);
            this.groupBox1.Controls.Add(this.imgMSLB);
            this.groupBox1.Controls.Add(this.yoloMSLB);
            this.groupBox1.Controls.Add(this.addListBox);
            this.groupBox1.Controls.Add(this.addLB);
            this.groupBox1.Controls.Add(this.contCapChk);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.itemListBox);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.checkoutBtn);
            this.groupBox1.Controls.Add(this.picLB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(923, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 674);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // timeLB
            // 
            this.timeLB.AutoSize = true;
            this.timeLB.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.timeLB.ForeColor = System.Drawing.Color.Black;
            this.timeLB.Location = new System.Drawing.Point(14, 138);
            this.timeLB.Name = "timeLB";
            this.timeLB.Size = new System.Drawing.Size(78, 21);
            this.timeLB.TabIndex = 14;
            this.timeLB.Text = "結帳時間:";
            this.timeLB.Visible = false;
            // 
            // imgMSLB
            // 
            this.imgMSLB.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.imgMSLB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgMSLB.Location = new System.Drawing.Point(304, 5);
            this.imgMSLB.Name = "imgMSLB";
            this.imgMSLB.Size = new System.Drawing.Size(99, 20);
            this.imgMSLB.TabIndex = 13;
            this.imgMSLB.Text = "0";
            this.imgMSLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yoloMSLB
            // 
            this.yoloMSLB.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yoloMSLB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yoloMSLB.Location = new System.Drawing.Point(304, 31);
            this.yoloMSLB.Name = "yoloMSLB";
            this.yoloMSLB.Size = new System.Drawing.Size(99, 20);
            this.yoloMSLB.TabIndex = 12;
            this.yoloMSLB.Text = "0";
            this.yoloMSLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addLB
            // 
            this.addLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addLB.AutoSize = true;
            this.addLB.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addLB.ForeColor = System.Drawing.Color.Black;
            this.addLB.Location = new System.Drawing.Point(14, 391);
            this.addLB.Name = "addLB";
            this.addLB.Size = new System.Drawing.Size(54, 26);
            this.addLB.TabIndex = 10;
            this.addLB.Text = "加購";
            this.addLB.Visible = false;
            // 
            // contCapChk
            // 
            this.contCapChk.AutoSize = true;
            this.contCapChk.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.contCapChk.ForeColor = System.Drawing.Color.SeaGreen;
            this.contCapChk.Location = new System.Drawing.Point(19, 30);
            this.contCapChk.Name = "contCapChk";
            this.contCapChk.Size = new System.Drawing.Size(93, 25);
            this.contCapChk.TabIndex = 8;
            this.contCapChk.Text = "連續辨識";
            this.contCapChk.UseVisualStyleBackColor = true;
            this.contCapChk.CheckedChanged += new System.EventHandler(this.contCapChk_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.totalLB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 46);
            this.panel2.TabIndex = 6;
            // 
            // totalLB
            // 
            this.totalLB.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalLB.ForeColor = System.Drawing.Color.Black;
            this.totalLB.Location = new System.Drawing.Point(303, 10);
            this.totalLB.Name = "totalLB";
            this.totalLB.Size = new System.Drawing.Size(99, 26);
            this.totalLB.TabIndex = 7;
            this.totalLB.Text = "$0";
            this.totalLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "小結";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.testLB);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 70);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(302, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "12,000";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(84, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "累計消費:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(303, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "0900000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(84, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anna";
            // 
            // picLB
            // 
            this.picLB.AutoSize = true;
            this.picLB.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.picLB.Location = new System.Drawing.Point(228, 18);
            this.picLB.Name = "picLB";
            this.picLB.Size = new System.Drawing.Size(60, 26);
            this.picLB.TabIndex = 1;
            this.picLB.Text = "(0件)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "購物車";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All files|*.*|Bitmap Files|*.bmp";
            // 
            // update
            // 
            this.update.Interval = 200;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // viewSC
            // 
            this.viewSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSC.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.viewSC.IsSplitterFixed = true;
            this.viewSC.Location = new System.Drawing.Point(0, 0);
            this.viewSC.Name = "viewSC";
            this.viewSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // viewSC.Panel1
            // 
            this.viewSC.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewSC.Panel1.Controls.Add(this.waitTimeNud);
            this.viewSC.Panel1.Controls.Add(this.confidenceChk);
            this.viewSC.Panel1.Controls.Add(this.captionLB);
            // 
            // viewSC.Panel2
            // 
            this.viewSC.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.viewSC.Panel2.Controls.Add(this.mainSC);
            this.viewSC.Size = new System.Drawing.Size(923, 674);
            this.viewSC.SplitterDistance = 55;
            this.viewSC.TabIndex = 2;
            // 
            // waitTimeNud
            // 
            this.waitTimeNud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.waitTimeNud.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.waitTimeNud.Location = new System.Drawing.Point(861, 28);
            this.waitTimeNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.waitTimeNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.waitTimeNud.Name = "waitTimeNud";
            this.waitTimeNud.Size = new System.Drawing.Size(56, 25);
            this.waitTimeNud.TabIndex = 12;
            this.waitTimeNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.waitTimeNud.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.waitTimeNud.ValueChanged += new System.EventHandler(this.waitTimeNud_ValueChanged);
            // 
            // confidenceChk
            // 
            this.confidenceChk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confidenceChk.AutoSize = true;
            this.confidenceChk.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confidenceChk.ForeColor = System.Drawing.Color.SeaGreen;
            this.confidenceChk.Location = new System.Drawing.Point(808, 3);
            this.confidenceChk.Name = "confidenceChk";
            this.confidenceChk.Size = new System.Drawing.Size(109, 25);
            this.confidenceChk.TabIndex = 10;
            this.confidenceChk.Text = "顯示信任度";
            this.confidenceChk.UseVisualStyleBackColor = true;
            // 
            // captionLB
            // 
            this.captionLB.BackColor = System.Drawing.Color.SeaGreen;
            this.captionLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captionLB.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.captionLB.ForeColor = System.Drawing.Color.White;
            this.captionLB.Location = new System.Drawing.Point(0, 0);
            this.captionLB.Name = "captionLB";
            this.captionLB.Size = new System.Drawing.Size(923, 55);
            this.captionLB.TabIndex = 2;
            this.captionLB.Text = "商品影像";
            this.captionLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainSC
            // 
            this.mainSC.BackColor = System.Drawing.Color.Transparent;
            this.mainSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSC.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSC.IsSplitterFixed = true;
            this.mainSC.Location = new System.Drawing.Point(0, 0);
            this.mainSC.Name = "mainSC";
            // 
            // mainSC.Panel1
            // 
            this.mainSC.Panel1.Controls.Add(this.container);
            this.mainSC.Panel1.Controls.Add(this.ctrlVisibleLB);
            // 
            // mainSC.Panel2
            // 
            this.mainSC.Panel2.Controls.Add(this.historyListBox);
            this.mainSC.Size = new System.Drawing.Size(923, 615);
            this.mainSC.SplitterDistance = 775;
            this.mainSC.TabIndex = 0;
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.BackColor = System.Drawing.Color.DimGray;
            this.container.Controls.Add(this.capAFBtn);
            this.container.Controls.Add(this.saveBtn);
            this.container.Controls.Add(this.saveImgBtn);
            this.container.Controls.Add(this.browseBtn);
            this.container.Location = new System.Drawing.Point(5, 2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(728, 607);
            this.container.TabIndex = 17;
            this.container.SizeChanged += new System.EventHandler(this.container_SizeChanged);
            // 
            // capAFBtn
            // 
            this.capAFBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.capAFBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.capAFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capAFBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.capAFBtn.ForeColor = System.Drawing.Color.White;
            this.capAFBtn.Location = new System.Drawing.Point(5, 4);
            this.capAFBtn.Name = "capAFBtn";
            this.capAFBtn.Size = new System.Drawing.Size(111, 35);
            this.capAFBtn.TabIndex = 10;
            this.capAFBtn.Text = "Capture(Auto)";
            this.capAFBtn.UseVisualStyleBackColor = false;
            this.capAFBtn.Click += new System.EventHandler(this.capAFBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(5, 522);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 35);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save BackImg";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveImgBtn
            // 
            this.saveImgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveImgBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.saveImgBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.saveImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImgBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveImgBtn.ForeColor = System.Drawing.Color.White;
            this.saveImgBtn.Location = new System.Drawing.Point(5, 563);
            this.saveImgBtn.Name = "saveImgBtn";
            this.saveImgBtn.Size = new System.Drawing.Size(111, 35);
            this.saveImgBtn.TabIndex = 8;
            this.saveImgBtn.Text = "Save ResImg";
            this.saveImgBtn.UseVisualStyleBackColor = false;
            this.saveImgBtn.Click += new System.EventHandler(this.saveImgBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.browseBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Location = new System.Drawing.Point(607, 6);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(111, 31);
            this.browseBtn.TabIndex = 7;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // ctrlVisibleLB
            // 
            this.ctrlVisibleLB.BackColor = System.Drawing.Color.SeaGreen;
            this.ctrlVisibleLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlVisibleLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrlVisibleLB.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlVisibleLB.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ctrlVisibleLB.ForeColor = System.Drawing.Color.Gainsboro;
            this.ctrlVisibleLB.Location = new System.Drawing.Point(739, 0);
            this.ctrlVisibleLB.Name = "ctrlVisibleLB";
            this.ctrlVisibleLB.Size = new System.Drawing.Size(36, 615);
            this.ctrlVisibleLB.TabIndex = 16;
            this.ctrlVisibleLB.Text = "◀ ◀ ◀";
            this.ctrlVisibleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrlVisibleLB.Click += new System.EventHandler(this.ctrlVisibleLB_Click);
            // 
            // waitThd
            // 
            this.waitThd.DoWork += new System.ComponentModel.DoWorkEventHandler(this.waitThd_DoWork);
            // 
            // historyListBox
            // 
            this.historyListBox.BackColor = System.Drawing.Color.LightGray;
            this.historyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 140;
            this.historyListBox.Location = new System.Drawing.Point(0, 0);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(144, 615);
            this.historyListBox.TabIndex = 0;
            this.historyListBox.Click += new System.EventHandler(this.historyListBox_Click);
            // 
            // addListBox
            // 
            this.addListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.addListBox.FormattingEnabled = true;
            this.addListBox.ItemHeight = 70;
            this.addListBox.Location = new System.Drawing.Point(1, 421);
            this.addListBox.Name = "addListBox";
            this.addListBox.Size = new System.Drawing.Size(423, 73);
            this.addListBox.TabIndex = 11;
            this.addListBox.Visible = false;
            // 
            // itemListBox
            // 
            this.itemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 70;
            this.itemListBox.Location = new System.Drawing.Point(1, 167);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(423, 210);
            this.itemListBox.TabIndex = 5;
            // 
            // testLB
            // 
            this.testLB.BackColor = System.Drawing.Color.SeaGreen;
            this.testLB.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.testLB.ForeColor = System.Drawing.Color.White;
            this.testLB.Location = new System.Drawing.Point(12, 11);
            this.testLB.Name = "testLB";
            this.testLB.Radius = 50;
            this.testLB.Size = new System.Drawing.Size(50, 50);
            this.testLB.TabIndex = 3;
            this.testLB.Text = "A";
            this.testLB.Click += new System.EventHandler(this.testLB_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkoutBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Location = new System.Drawing.Point(19, 563);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Radius = 65;
            this.checkoutBtn.Size = new System.Drawing.Size(378, 98);
            this.checkoutBtn.TabIndex = 2;
            this.checkoutBtn.Text = "結帳";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1347, 674);
            this.Controls.Add(this.viewSC);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "結帳系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.viewSC.Panel1.ResumeLayout(false);
            this.viewSC.Panel1.PerformLayout();
            this.viewSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSC)).EndInit();
            this.viewSC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waitTimeNud)).EndInit();
            this.mainSC.Panel1.ResumeLayout(false);
            this.mainSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSC)).EndInit();
            this.mainSC.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label picLB;
        private System.Windows.Forms.Label label1;
        private PersonButton checkoutBtn;
        private PersonLabel testLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private PersonListBox itemListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.CheckBox contCapChk;
        private PersonListBox addListBox;
        private System.Windows.Forms.Label addLB;
        private System.Windows.Forms.Label yoloMSLB;
        private System.Windows.Forms.Label imgMSLB;
        private System.Windows.Forms.SplitContainer viewSC;
        private System.Windows.Forms.Label captionLB;
        private System.Windows.Forms.SplitContainer mainSC;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button capAFBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button saveImgBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label ctrlVisibleLB;
        private HistoryListBox historyListBox;
        private System.Windows.Forms.Label timeLB;
        private System.Windows.Forms.CheckBox confidenceChk;
        private System.Windows.Forms.NumericUpDown waitTimeNud;
        private System.ComponentModel.BackgroundWorker waitThd;
    }
}

