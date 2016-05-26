using Android.Content;
using System.Linq;
using Xamarin.Forms;
using DoctorApp.Droid;

[assembly: DependencyAttribute(typeof(Determiner))]

namespace DoctorApp.Droid
{
	public class Determiner : IDeterminer
	{
		public string find() {
			return "Android";
		}
	}
}

