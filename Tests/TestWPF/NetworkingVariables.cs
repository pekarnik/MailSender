using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPF
{
	public static class NetworkingVariables
	{
		public static string host = "smtp.mail.ru";
		public static int port = 25;
		public static string msg = "Hello World!" + DateTime.Now;
		public static string emailFrom = "sh5@inbox.ru";
		public static string emailTo = "pekgoglo@gmail.com";
		public static string name = "Andrey";
		public static string msgSubj= "Заголовок письма";
		public static string successMsg = "Почта успешно отправлена!";
		public static string successCaption = "Успех!";
		public static string errorMsg = "Почта не отправлена!";
		public static string errorCaption = "Успех!";
	}
}
