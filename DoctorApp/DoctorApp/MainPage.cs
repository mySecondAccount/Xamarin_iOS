using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DoctorApp
{
	public class MainPage  : ContentPage
	{
		string givenName = "Michael";
		Label welcomeUser;
		Label question;
		Entry doctorName;
		Button submit;

		public MainPage()
		{
			this.Padding = new Thickness (20, Device.OnPlatform (100, 20, 20), 20, 20);

			// The root page of your application

			StackLayout panel = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Vertical,
				Spacing = 15,
			};

			panel.Children.Add (welcomeUser = new Label { 
				XAlign = TextAlignment.Center,
				Text = "Welcome to the UHG Doctor App, " + givenName,
				TextColor = Color.Navy,
			});

			panel.Children.Add (question = new Label {
				Text = "What is your Doctor's Name?",
				TextColor = Color.Teal,
			});

			panel.Children.Add (doctorName = new Entry {
				Placeholder = "Doctor's Name",
				Keyboard = Keyboard.Default,
			});

			panel.Children.Add (submit = new Button {
				Text = "Submit Name",
			});

			submit.Clicked += popUp;

			this.Content = panel;
		}

		private void popUp(object sender, EventArgs e)
		{
			var determiner = DependencyService.Get<IDeterminer> ();
			this.DisplayAlert ("Your device type: " + determiner.find(),"Your Doctor's name is: " + doctorName.Text, "OK");
		}
	}
}