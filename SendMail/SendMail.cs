using System;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Ionic.Zip;
using System.Linq;

namespace SendMail
{
    public enum AfterSendActions
    {
        None,
        Move,
        Clear
    }

    class SendMail
    {
        public string smtpServer;
        public string from;
        public string username;
        public string password;
        public int port;
        public bool useSSL;

        private static List<string> FilesList = new List<string>();

        public bool Send(string mailTo, string caption, string message, bool html, MailPriority Priority, Encoding encoding, bool simulate,
                bool ignoreErrors = true, string[] attachFiles = null)
        {
            bool result = false;
            try
            {
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = html;
                mail.Priority = Priority;
                mail.BodyEncoding = encoding;
                mail.SubjectEncoding = encoding;
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailTo));
                mail.Subject = caption;
                mail.Body = message;
                if (attachFiles != null)
                {
                    foreach (var attachFile in attachFiles)
                    {
                        if (!string.IsNullOrEmpty(attachFile))
                            mail.Attachments.Add(new Attachment(attachFile));
                    }
                }
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = port;
                client.EnableSsl = useSSL;
                client.Credentials = new NetworkCredential(username, password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                if (!simulate)
                    client.Send(mail);
                mail.Dispose();

                result = true;
            }
            catch (Exception e)
            {
                result = false;
                if (!ignoreErrors)
                    throw new Exception("Mail.Send: " + e.Message);
            }
            return result;
        }

        public static bool ValidateEmail(string EMail)
        {
            bool next = !string.IsNullOrEmpty(EMail);
            if (next)
            {
                next = EMail.Length > 6;
                if (next)
                {
                    next = EMail.IndexOf("@") > 0;
                    if (next)
                    {
                        next = EMail.Contains(".");
                        if (next)
                        {
                            next = EMail.IndexOf("@") < EMail.LastIndexOf(".");
                        }
                    }
                }
            }
            return next;
        }

        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        FilesList.Add(f);
                    }
                    DirSearch(d);
                    FilesList.AddRange(Directory.GetFiles(sDir));
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        public void SendFolder(string Email, string Folder, string rootFolder, bool Arc, AfterSendActions AfterFolderSend, string caption,
                string message, bool html, MailPriority Priority, Encoding encoding, bool simulate, bool arcFolder,
                    bool ignoreErrors = true)
        {
            if (Folder.Last() != Path.DirectorySeparatorChar)
                Folder += Path.DirectorySeparatorChar;

            FilesList.Clear();
            DirSearch(Folder);

            string arcName = "";
            if (arcFolder)
            {
                arcName = Path.GetTempPath() + Email + ".zip";

                ZipFile zf = new ZipFile();

                foreach (string f in FilesList)
                {
                    string dirInArchive = Path.GetDirectoryName(f).Replace(Folder, "");

                    zf.AddFile(f, "Attachments" + dirInArchive);
                }
                zf.Save(arcName);

                FilesList.Clear();
                FilesList.Add(arcName);
            }

            Send(Email, caption, message, html, Priority, encoding, simulate, ignoreErrors, FilesList.ToArray());

            if (File.Exists(arcName))
                File.Delete(arcName);

            switch (AfterFolderSend)
            {
                case AfterSendActions.Move:

                    if (!simulate)
                    {
                        string dir = rootFolder + "_sended" + Path.DirectorySeparatorChar + Path.DirectorySeparatorChar + Email;
                        Directory.CreateDirectory(dir);
                        Directory.Move(Folder, dir);
                    }

                    break;

                case AfterSendActions.Clear:

                    if (!simulate)
                    {
                        Directory.Delete(Folder, true);
                        Directory.CreateDirectory(Folder);
                    }

                    break;
            }
        }
    }
}
