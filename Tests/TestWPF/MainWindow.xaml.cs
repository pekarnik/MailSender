using System.Windows;
using System.Net.Mail;
using System.Net;
using System.Security;
using System;

namespace TestWPF
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		

		private void SendButton_OnClick(object sender, RoutedEventArgs e)
		{

			var emailSender = new EmailSendServiceClass(UserNameEditor.Text,PasswordEditor.SecurePassword);
			emailSender.SendMessage(NetworkingVariables.host, NetworkingVariables.port, NetworkingVariables.emailFrom, NetworkingVariables.emailTo, NetworkingVariables.name, MessageSubj.Text, Message.Text
				, NetworkingVariables.successMsg, NetworkingVariables.errorMsg, NetworkingVariables.successCaption, NetworkingVariables.successCaption);
		}
	}
}
