using System;

using Xamarin.Forms;

namespace HelloForms
{
	public class App : Application
	{
		public App ()
		{
			/*Code I added*/
			var btn = new Button {
				Text = "Click me!"
			};

			int count = 1;

			btn.Clicked += (object sender, EventArgs e) => {
				btn.Text = string.Format("Clicked {0} times.", count);
				count++;
			};

			/*End*/

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						/*Code I added*/
						btn
						/*End*/
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

