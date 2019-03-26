using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SendMail
{
    public partial class Form1 : Form
    {
        private enum CodePages
        {
            Win_1251 = 1251,
            UTF8 = 65001,
            CP_866 = 866
        }

        private List<string> MailsList = new List<string>();
        private int CurrentPos = -1;
        private SendMail sendMail = null;

        public Form1()
        {
            InitializeComponent();
            List<object> prior = new List<object>();
            foreach (var c in Enum.GetValues(typeof(System.Net.Mail.MailPriority)))
            {
                prior.Add(c);
            }
            cbPriority.Items.AddRange(prior.ToArray());
            cbPriority.SelectedIndex = prior.FindIndex(f => (System.Net.Mail.MailPriority)f == System.Net.Mail.MailPriority.Normal);

            List<object> codep = new List<object>();
            foreach (var c in Enum.GetValues(typeof(CodePages)))
            {
                codep.Add(c);
            }
            cbEncoding.Items.AddRange(codep.ToArray());
            cbEncoding.SelectedIndex = codep.FindIndex(f => (CodePages)f == CodePages.UTF8);

            cbAfterSend.Items.Clear();
            List<object> asa = new List<object>();
            foreach (var c in Enum.GetValues(typeof(AfterSendActions)))
            {
                asa.Add(c);
            }
            cbAfterSend.Items.AddRange(asa.ToArray());
            cbAfterSend.SelectedIndex = asa.FindIndex(f => (AfterSendActions)f == AfterSendActions.None);

            this.tbMailFrom.Text = Properties.Settings.Default.FromMail;
            this.tbSMTPServer.Text = Properties.Settings.Default.smtpServer;
            this.tbSMTPPort.Text = Convert.ToString(Properties.Settings.Default.smtp_port);
            this.chUseSSL.Checked = Properties.Settings.Default.EnableSSL;
            this.tbSMTP_username.Text = Properties.Settings.Default.SMTP_user;
            this.tbSMTP_password.Text = Properties.Settings.Default.SMTP_password;
            this.meBody.Text = Properties.Settings.Default.Body;
            this.tbMailsList.Text = Properties.Settings.Default.MailList;
            this.tbInterval.Text = Convert.ToString(Properties.Settings.Default.Interval);
            this.tbCaption.Text = Properties.Settings.Default.Caption;
            this.chIgnoreErrors.Checked = Properties.Settings.Default.IgnoreErrors;
            this.chAsHtml.Checked = Properties.Settings.Default.UseHTML;
            this.tbFolderName.Text = Properties.Settings.Default.SendFolder;
            this.cbAfterSend.SelectedIndex = asa.FindIndex(f => (AfterSendActions)f == (AfterSendActions)Properties.Settings.Default.AfterSend);

            if (Properties.Settings.Default.Attachments != null)
                foreach (var a in Properties.Settings.Default.Attachments)
                {
                    this.lbAttachments.Items.Add(a);
                }

            string hash = GetListHash(Properties.Settings.Default.MailList);
            string oldhash = Properties.Settings.Default.HashList;
            if (hash != oldhash)
            {
                CurrentPos = -1;
                Properties.Settings.Default.LastPos = -1;
                Properties.Settings.Default.HashList = hash;
            }
            else
                CurrentPos = Properties.Settings.Default.LastPos;

            lbPos.Text = CurrentPos.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.FromMail = tbMailFrom.Text;
            Properties.Settings.Default.smtpServer = tbSMTPServer.Text;
            Properties.Settings.Default.smtp_port = Convert.ToInt32(tbSMTPPort.Text);
            Properties.Settings.Default.EnableSSL = chUseSSL.Checked;
            Properties.Settings.Default.SMTP_user = tbSMTP_username.Text;
            Properties.Settings.Default.SMTP_password = tbSMTP_password.Text;
            Properties.Settings.Default.Body = meBody.Text;
            Properties.Settings.Default.MailList = tbMailsList.Text;
            Properties.Settings.Default.Interval = Convert.ToInt32(tbInterval.Text);
            Properties.Settings.Default.Caption = tbCaption.Text;
            Properties.Settings.Default.IgnoreErrors = chIgnoreErrors.Checked;
            Properties.Settings.Default.LastPos = CurrentPos;
            Properties.Settings.Default.UseHTML = chAsHtml.Checked;
            Properties.Settings.Default.SendFolder = tbFolderName.Text;
            Properties.Settings.Default.AfterSend = (int)(cbAfterSend.SelectedItem);

            if (Properties.Settings.Default.Attachments != null)
            {
                Properties.Settings.Default.Attachments.Clear();
                foreach (var a in lbAttachments.Items)
                {
                    Properties.Settings.Default.Attachments.Add((string)a);
                }
            }

            if (!chDontSave.Checked)
                Properties.Settings.Default.Save();
        }

        private void LoadMailList(string FileName)
        {
            if (File.Exists(FileName))
            {
                string mail = null;
                MailsList.Clear();
                FileStream maillistfs = new FileStream(FileName, FileMode.Open);
                StreamReader srList = new StreamReader(maillistfs);
                while ((mail = srList.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(mail.Trim()))
                    {
                        MailsList.Add(mail.Trim());
                    }
                }
                srList.Close();
                maillistfs.Close();
                lbMailsCount.Text = MailsList.Count.ToString();
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            LoadMailList(tbMailsList.Text);

            lbPos.Text = "-";
            timer1.Interval = Properties.Settings.Default.Interval * 1000;
            timer1.Enabled = true;
        }

        private string CalcMD5(string Value)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string md5pass = BitConverter.ToString(md5.ComputeHash(ASCIIEncoding.Default.GetBytes(Value)));
            md5pass = md5pass.Replace("-", "");
            return md5pass;
        }

        private string GetListHash(string FileName)
        {
            string hash = "";
            if (File.Exists(FileName))
            {
                StreamReader sr = new StreamReader(FileName);
                hash = CalcMD5(sr.ReadToEnd());
                sr.Close();
            }
            return hash;
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbMailsList.Text = openFileDialog1.FileName;
                LoadMailList(tbMailsList.Text);

                string hash = GetListHash(openFileDialog1.FileName);
                if (hash != Properties.Settings.Default.HashList)
                {
                    CurrentPos = -1;
                }
                Properties.Settings.Default.HashList = hash;
            }
        }

        private void btSendOne_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.GetEncoding((int)((CodePages)cbEncoding.SelectedItem));

            List<string> attach = new List<string>();
            foreach (var a in lbAttachments.Items)
            {
                attach.Add(Convert.ToString(a));
            }

            sendMail = new SendMail();
            sendMail.smtpServer = tbSMTPServer.Text;
            sendMail.from = tbMailFrom.Text;
            sendMail.username = tbSMTP_username.Text;
            sendMail.password = tbSMTP_password.Text;
            sendMail.port = Convert.ToInt32(tbSMTPPort.Text);
            sendMail.useSSL = chUseSSL.Checked;

            System.Net.Mail.MailPriority prior = (System.Net.Mail.MailPriority)cbPriority.SelectedItem;
            lbAlert.Text = "";
            if (!sendMail.Send(tbOneMail.Text,
                    tbCaption.Text, meBody.Text, chAsHtml.Checked, prior, encoding, chSimulate.Checked,
                        true, attach.ToArray()))
            {
                if (!chIgnoreErrors.Checked)
                    timer1.Enabled = false;
                lbAlert.Text = "Ошибка отправки: " + tbOneMail.Text;
            }
        }

        private void btShowPass_Click(object sender, EventArgs e)
        {
            if (tbSMTP_password.PasswordChar != '\0')
                tbSMTP_password.PasswordChar = '\0';
            else
                tbSMTP_password.PasswordChar = '#';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MailsList.Count > CurrentPos + 1)
            {
                CurrentPos++;

                Encoding encoding = Encoding.GetEncoding((int)((CodePages)cbEncoding.SelectedItem));
                List<string> attach = new List<string>();
                foreach (var a in lbAttachments.Items)
                {
                    attach.Add(Convert.ToString(a));
                }

                System.Net.Mail.MailPriority prior = (System.Net.Mail.MailPriority)cbPriority.SelectedItem;

                lbAlert.Text = "";

                sendMail = new SendMail();
                sendMail.smtpServer = tbSMTPServer.Text;
                sendMail.from = tbMailFrom.Text;
                sendMail.username = tbSMTP_username.Text;
                sendMail.password = tbSMTP_password.Text;
                sendMail.port = Convert.ToInt32(tbSMTPPort.Text);
                sendMail.useSSL = chUseSSL.Checked;

                string mail = MailsList[CurrentPos];
                if (!sendMail.Send(mail, tbCaption.Text, meBody.Text, chAsHtml.Checked,
                            prior, encoding, chSimulate.Checked, true, attach.ToArray()))
                {
                    if (!chIgnoreErrors.Checked)
                        timer1.Enabled = false;
                    lbAlert.Text = "Ошибка отправки: " + mail;
                }

                lbPos.Text = (CurrentPos + 1).ToString();
            }
            else
            {
                timer1.Enabled = false;
                CurrentPos = -1;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            CurrentPos = -1;
            lbPos.Text = CurrentPos.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileAttachment.ShowDialog() == DialogResult.OK)
            {
                lbAttachments.Items.Add(openFileAttachment.FileName);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lbAttachments.Items.Remove(lbAttachments.SelectedIndex);
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbAttachments.Items.Clear();
        }

        private void btFolderSend_Click(object sender, EventArgs e)
        {
            sendMail = new SendMail();
            sendMail.smtpServer = tbSMTPServer.Text;
            sendMail.from = tbMailFrom.Text;
            sendMail.username = tbSMTP_username.Text;
            sendMail.password = tbSMTP_password.Text;
            sendMail.port = Convert.ToInt32(tbSMTPPort.Text);
            sendMail.useSSL = chUseSSL.Checked;

            string[] emailsfolders = Directory.GetDirectories(tbFolderName.Text).Where(f => SendMail.ValidateEmail(f)).ToArray();

            AfterSendActions asa = (AfterSendActions)cbAfterSend.SelectedItem;
            Encoding encoding = Encoding.GetEncoding((int)((CodePages)cbEncoding.SelectedItem));
            System.Net.Mail.MailPriority prior = (System.Net.Mail.MailPriority)cbPriority.SelectedItem;
            foreach (string folder in emailsfolders)
            {
                string mail = folder.Split(Path.DirectorySeparatorChar).Last();

                sendMail.SendFolder(mail, folder, tbFolderName.Text, chSendAsArc.Checked, asa, tbCaption.Text, meBody.Text, chAsHtml.Checked,
                            prior, encoding, chSimulateFolder.Checked, chSendAsArc.Checked);
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbFolderName.Text = folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar;
            }
        }
    }
}
