using Foundation;
using UIKit;
using Xamarin.Forms;
using DoctorApp.iOS;

[assembly: DependencyAttribute(typeof(Determiner))]

namespace DoctorApp.iOS
{
	public class Determiner : IDeterminer
	{
		public string find() {
			return "iPhone";
		}
	}
}

