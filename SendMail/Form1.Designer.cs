namespace SendMail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbAlert = new System.Windows.Forms.Label();
            this.openFileAttachment = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chSimulate = new System.Windows.Forms.CheckBox();
            this.lbMailsCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chIgnoreErrors = new System.Windows.Forms.CheckBox();
            this.lbPos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMailsList = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.cbAfterSend = new System.Windows.Forms.ComboBox();
            this.chSimulateFolder = new System.Windows.Forms.CheckBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btFolderSend = new System.Windows.Forms.Button();
            this.chSendAsArc = new System.Windows.Forms.CheckBox();
            this.tbFolderName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.chAsHtml = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCaption = new System.Windows.Forms.TextBox();
            this.tbOneMail = new System.Windows.Forms.TextBox();
            this.btSendOne = new System.Windows.Forms.Button();
            this.meBody = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.chDontSave = new System.Windows.Forms.CheckBox();
            this.btShowPass = new System.Windows.Forms.Button();
            this.tbSMTP_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSMTP_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSMTPPort = new System.Windows.Forms.TextBox();
            this.tbSMTPServer = new System.Windows.Forms.TextBox();
            this.chUseSSL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMailFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAttachments = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.очиститьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem2.Text = "Удалить";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text|*.txt";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbAlert
            // 
            this.lbAlert.AutoSize = true;
            this.lbAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.lbAlert.Location = new System.Drawing.Point(20, 375);
            this.lbAlert.Name = "lbAlert";
            this.lbAlert.Size = new System.Drawing.Size(0, 13);
            this.lbAlert.TabIndex = 31;
            // 
            // openFileAttachment
            // 
            this.openFileAttachment.FileName = "openFileDialog2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 372);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cbEncoding);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.cbPriority);
            this.tabPage1.Controls.Add(this.chAsHtml);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tbCaption);
            this.tabPage1.Controls.Add(this.tbOneMail);
            this.tabPage1.Controls.Add(this.btSendOne);
            this.tabPage1.Controls.Add(this.meBody);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Из списка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(6, 7);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(327, 330);
            this.tabControl3.TabIndex = 81;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lbAttachments);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.chSimulate);
            this.tabPage5.Controls.Add(this.lbMailsCount);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.chIgnoreErrors);
            this.tabPage5.Controls.Add(this.lbPos);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.btReset);
            this.tabPage5.Controls.Add(this.btSend);
            this.tabPage5.Controls.Add(this.btOpen);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.tbMailsList);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(319, 304);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Список рассылки";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chSimulate
            // 
            this.chSimulate.AutoSize = true;
            this.chSimulate.Location = new System.Drawing.Point(128, 61);
            this.chSimulate.Name = "chSimulate";
            this.chSimulate.Size = new System.Drawing.Size(82, 17);
            this.chSimulate.TabIndex = 74;
            this.chSimulate.Text = "Симуляция";
            this.chSimulate.UseVisualStyleBackColor = true;
            // 
            // lbMailsCount
            // 
            this.lbMailsCount.AutoSize = true;
            this.lbMailsCount.Location = new System.Drawing.Point(176, 120);
            this.lbMailsCount.Name = "lbMailsCount";
            this.lbMailsCount.Size = new System.Drawing.Size(13, 13);
            this.lbMailsCount.TabIndex = 73;
            this.lbMailsCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "из";
            // 
            // chIgnoreErrors
            // 
            this.chIgnoreErrors.AutoSize = true;
            this.chIgnoreErrors.Location = new System.Drawing.Point(12, 97);
            this.chIgnoreErrors.Name = "chIgnoreErrors";
            this.chIgnoreErrors.Size = new System.Drawing.Size(139, 17);
            this.chIgnoreErrors.TabIndex = 71;
            this.chIgnoreErrors.Text = "Игнорировать ошибки";
            this.chIgnoreErrors.UseVisualStyleBackColor = true;
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(115, 120);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(16, 13);
            this.lbPos.TabIndex = 70;
            this.lbPos.Text = "-1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Текущая позиция:";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(226, 115);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(73, 23);
            this.btReset.TabIndex = 68;
            this.btReset.Text = "Сбросить";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(9, 57);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 67;
            this.btSend.Text = "Рассылка";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(196, 27);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(40, 23);
            this.btOpen.TabIndex = 59;
            this.btOpen.Text = "...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Список рассылки";
            // 
            // tbMailsList
            // 
            this.tbMailsList.Location = new System.Drawing.Point(9, 27);
            this.tbMailsList.Name = "tbMailsList";
            this.tbMailsList.Size = new System.Drawing.Size(181, 20);
            this.tbMailsList.TabIndex = 57;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.cbAfterSend);
            this.tabPage6.Controls.Add(this.chSimulateFolder);
            this.tabPage6.Controls.Add(this.btBrowse);
            this.tabPage6.Controls.Add(this.btFolderSend);
            this.tabPage6.Controls.Add(this.chSendAsArc);
            this.tabPage6.Controls.Add(this.tbFolderName);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(319, 304);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Папки (mailbox)";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "После отправки папку:";
            // 
            // cbAfterSend
            // 
            this.cbAfterSend.FormattingEnabled = true;
            this.cbAfterSend.Location = new System.Drawing.Point(15, 97);
            this.cbAfterSend.Name = "cbAfterSend";
            this.cbAfterSend.Size = new System.Drawing.Size(106, 21);
            this.cbAfterSend.TabIndex = 21;
            // 
            // chSimulateFolder
            // 
            this.chSimulateFolder.AutoSize = true;
            this.chSimulateFolder.Location = new System.Drawing.Point(96, 138);
            this.chSimulateFolder.Name = "chSimulateFolder";
            this.chSimulateFolder.Size = new System.Drawing.Size(82, 17);
            this.chSimulateFolder.TabIndex = 20;
            this.chSimulateFolder.Text = "Симуляция";
            this.chSimulateFolder.UseVisualStyleBackColor = true;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(213, 22);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(33, 23);
            this.btBrowse.TabIndex = 19;
            this.btBrowse.Text = "...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btFolderSend
            // 
            this.btFolderSend.Location = new System.Drawing.Point(15, 134);
            this.btFolderSend.Name = "btFolderSend";
            this.btFolderSend.Size = new System.Drawing.Size(75, 23);
            this.btFolderSend.TabIndex = 18;
            this.btFolderSend.Text = "Рассылка";
            this.btFolderSend.UseVisualStyleBackColor = true;
            this.btFolderSend.Click += new System.EventHandler(this.btFolderSend_Click);
            // 
            // chSendAsArc
            // 
            this.chSendAsArc.AutoSize = true;
            this.chSendAsArc.Location = new System.Drawing.Point(15, 51);
            this.chSendAsArc.Name = "chSendAsArc";
            this.chSendAsArc.Size = new System.Drawing.Size(160, 17);
            this.chSendAsArc.TabIndex = 17;
            this.chSendAsArc.Text = "Отправлять в виде архива";
            this.chSendAsArc.UseVisualStyleBackColor = true;
            // 
            // tbFolderName
            // 
            this.tbFolderName.Location = new System.Drawing.Point(15, 25);
            this.tbFolderName.Name = "tbFolderName";
            this.tbFolderName.Size = new System.Drawing.Size(192, 20);
            this.tbFolderName.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Папка";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(499, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Кодировка";
            // 
            // cbEncoding
            // 
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Location = new System.Drawing.Point(499, 228);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(121, 21);
            this.cbEncoding.TabIndex = 78;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 77;
            this.label13.Text = "Приоритет";
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(353, 228);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(121, 21);
            this.cbPriority.TabIndex = 76;
            // 
            // chAsHtml
            // 
            this.chAsHtml.AutoSize = true;
            this.chAsHtml.Location = new System.Drawing.Point(459, 56);
            this.chAsHtml.Name = "chAsHtml";
            this.chAsHtml.Size = new System.Drawing.Size(78, 17);
            this.chAsHtml.TabIndex = 75;
            this.chAsHtml.Text = "Как HTML";
            this.chAsHtml.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Заголовок письма";
            // 
            // tbCaption
            // 
            this.tbCaption.Location = new System.Drawing.Point(354, 29);
            this.tbCaption.Name = "tbCaption";
            this.tbCaption.Size = new System.Drawing.Size(268, 20);
            this.tbCaption.TabIndex = 73;
            // 
            // tbOneMail
            // 
            this.tbOneMail.Location = new System.Drawing.Point(353, 255);
            this.tbOneMail.Name = "tbOneMail";
            this.tbOneMail.Size = new System.Drawing.Size(134, 20);
            this.tbOneMail.TabIndex = 72;
            // 
            // btSendOne
            // 
            this.btSendOne.Location = new System.Drawing.Point(502, 255);
            this.btSendOne.Name = "btSendOne";
            this.btSendOne.Size = new System.Drawing.Size(119, 23);
            this.btSendOne.TabIndex = 71;
            this.btSendOne.Text = "Отправить одно";
            this.btSendOne.UseVisualStyleBackColor = true;
            this.btSendOne.Click += new System.EventHandler(this.btSendOne_Click);
            // 
            // meBody
            // 
            this.meBody.Location = new System.Drawing.Point(353, 78);
            this.meBody.MaxLength = 3276700;
            this.meBody.Multiline = true;
            this.meBody.Name = "meBody";
            this.meBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.meBody.Size = new System.Drawing.Size(268, 122);
            this.meBody.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Текст письма";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbInterval);
            this.tabPage2.Controls.Add(this.chDontSave);
            this.tabPage2.Controls.Add(this.btShowPass);
            this.tabPage2.Controls.Add(this.tbSMTP_password);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbSMTP_username);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbSMTPPort);
            this.tabPage2.Controls.Add(this.tbSMTPServer);
            this.tabPage2.Controls.Add(this.chUseSSL);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbMailFrom);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(638, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Интервал отправки (с.)";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(235, 140);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(72, 20);
            this.tbInterval.TabIndex = 73;
            // 
            // chDontSave
            // 
            this.chDontSave.AutoSize = true;
            this.chDontSave.Location = new System.Drawing.Point(187, 31);
            this.chDontSave.Name = "chDontSave";
            this.chDontSave.Size = new System.Drawing.Size(151, 17);
            this.chDontSave.TabIndex = 72;
            this.chDontSave.Text = "Не сохранять настройки";
            this.chDontSave.UseVisualStyleBackColor = true;
            // 
            // btShowPass
            // 
            this.btShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btShowPass.Image")));
            this.btShowPass.Location = new System.Drawing.Point(154, 181);
            this.btShowPass.Name = "btShowPass";
            this.btShowPass.Size = new System.Drawing.Size(42, 23);
            this.btShowPass.TabIndex = 71;
            this.btShowPass.UseVisualStyleBackColor = true;
            this.btShowPass.Click += new System.EventHandler(this.btShowPass_Click);
            // 
            // tbSMTP_password
            // 
            this.tbSMTP_password.Location = new System.Drawing.Point(17, 183);
            this.tbSMTP_password.Name = "tbSMTP_password";
            this.tbSMTP_password.PasswordChar = '#';
            this.tbSMTP_password.Size = new System.Drawing.Size(131, 20);
            this.tbSMTP_password.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "SMTP пароль";
            // 
            // tbSMTP_username
            // 
            this.tbSMTP_username.Location = new System.Drawing.Point(17, 140);
            this.tbSMTP_username.Name = "tbSMTP_username";
            this.tbSMTP_username.Size = new System.Drawing.Size(131, 20);
            this.tbSMTP_username.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "SMTP имя пользователя";
            // 
            // tbSMTPPort
            // 
            this.tbSMTPPort.Location = new System.Drawing.Point(136, 91);
            this.tbSMTPPort.Name = "tbSMTPPort";
            this.tbSMTPPort.Size = new System.Drawing.Size(60, 20);
            this.tbSMTPPort.TabIndex = 66;
            // 
            // tbSMTPServer
            // 
            this.tbSMTPServer.Location = new System.Drawing.Point(17, 91);
            this.tbSMTPServer.Name = "tbSMTPServer";
            this.tbSMTPServer.Size = new System.Drawing.Size(100, 20);
            this.tbSMTPServer.TabIndex = 65;
            // 
            // chUseSSL
            // 
            this.chUseSSL.AutoSize = true;
            this.chUseSSL.Location = new System.Drawing.Point(216, 91);
            this.chUseSSL.Name = "chUseSSL";
            this.chUseSSL.Size = new System.Drawing.Size(122, 17);
            this.chUseSSL.TabIndex = 64;
            this.chUseSSL.Text = "Использовать SSL";
            this.chUseSSL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "SMTP порт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "SMTP сервер";
            // 
            // tbMailFrom
            // 
            this.tbMailFrom.Location = new System.Drawing.Point(17, 29);
            this.tbMailFrom.Name = "tbMailFrom";
            this.tbMailFrom.Size = new System.Drawing.Size(135, 20);
            this.tbMailFrom.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Отправитель";
            // 
            // lbAttachments
            // 
            this.lbAttachments.ContextMenuStrip = this.contextMenuStrip1;
            this.lbAttachments.FormattingEnabled = true;
            this.lbAttachments.Location = new System.Drawing.Point(9, 162);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(290, 121);
            this.lbAttachments.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Вложения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 372);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbAlert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendMailer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbAlert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFileAttachment;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.CheckBox chAsHtml;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCaption;
        private System.Windows.Forms.TextBox tbOneMail;
        private System.Windows.Forms.Button btSendOne;
        private System.Windows.Forms.TextBox meBody;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.CheckBox chDontSave;
        private System.Windows.Forms.Button btShowPass;
        private System.Windows.Forms.TextBox tbSMTP_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSMTP_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSMTPPort;
        private System.Windows.Forms.TextBox tbSMTPServer;
        private System.Windows.Forms.CheckBox chUseSSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMailFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox chSimulate;
        private System.Windows.Forms.Label lbMailsCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chIgnoreErrors;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMailsList;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox cbAfterSend;
        private System.Windows.Forms.CheckBox chSimulateFolder;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btFolderSend;
        private System.Windows.Forms.CheckBox chSendAsArc;
        private System.Windows.Forms.TextBox tbFolderName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lbAttachments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

