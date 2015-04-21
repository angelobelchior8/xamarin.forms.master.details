using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;

namespace MasterDetailEstudo
{
	public partial class MD : MasterDetailPage
	{
		public MD ()
		{
			InitializeComponent ();

			NavigationPage.SetHasNavigationBar (this, false);

			this.ListaEmails.ItemTapped += async (object sender, ItemTappedEventArgs e) => {
				var email = e.Item as Email;
				var leituraEmail = new LeituraEmail(){ BindingContext = email};
				await Navigation.PushAsync(leituraEmail);
			};

			this.BindingContext = new ViewModel();
		}
	}
}