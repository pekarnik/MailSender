using System;

using System.Net;
using System.Net.Mail;
using System.Security;
using System.Windows;

namespace TestWPF
{
	public class EmailSendServiceClass
	{
		private string _username;
		private SecureString _password;
		public EmailSendServiceClass(string username,SecureString pass)
		{
			_username = username;
			_password = pass;
		}
		
	public void SendMessage(string host, int port, string emailFrom,string emailTo,string name,string msgSubj,string msgBody, string successMsg, string errorMsg, string successCaption,string errorCaption)
	{
			using (var client = new SmtpClient(host, port))
			{
				client.EnableSsl = true;
				client.Credentials = new NetworkCredential(_username, _password);

				using (var message = new MailMessage())
				{
					message.From = new MailAddress(emailFrom, name);
					message.To.Add(new MailAddress(emailTo, name));
					message.Subject = msgSubj;
					message.Body = msgBody;

					try
					{
						SendEndWindow sew = new SendEndWindow();
						sew.ShowDialog();
					}
					catch (Exception exc)
					{
						MessageBox.Show(errorMsg + " " + exc,
							   errorCaption, MessageBoxButton.OK, MessageBoxImage.Error);
					}
				}
			}
		}
			
	}
}
