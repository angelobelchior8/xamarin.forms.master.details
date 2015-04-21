using System;
using System.Collections.Generic;

namespace MasterDetailEstudo
{
	public class ViewModel
	{
		public List<Email> Emails {
			get;
			set;
		}

		public List<string> Folders {
			get;
			set;
		}

		public string EmailsCount {
			get { return string.Format ("Inbox {0}", this.Emails.Count); }
		}
		
		public ViewModel ()
		{
			this.Emails = this.LoadEmails ();
			this.Folders = this.LoadFolders ();
		}

		private List<Email> LoadEmails()
		{
			var emails = new List<Email> ();
			for (int i = 0; i < 50; i++) {
				var email = new Email { 
					From = string.Format("email-{0}@servidor.com.br", i),
					Subject = string.Format("Subject {0}", i),
					ReceiveAt = DateTime.Now.AddSeconds(i).ToString("g")
				};

				emails.Add(email);
			}
			return emails;
		}

		private List<string> LoadFolders()
		{
			var folders = new List<string> ();
			folders.Add ("Inbox");
			folders.Add ("Sent");
			folders.Add ("Spam");

			return folders;
		}
	}
}