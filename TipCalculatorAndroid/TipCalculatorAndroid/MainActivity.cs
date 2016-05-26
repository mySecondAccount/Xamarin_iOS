using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TipCalculatorAndroid
{
	[Activity (Label = "TipCalculatorAndroid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		EditText inputBill;
		Button calculateButton;
		TextView outputTip;
		TextView outputTotal;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			inputBill = FindViewById<EditText> (Resource.Id.inputBill);
			calculateButton = FindViewById<Button> (Resource.Id.calculateButton);
			outputTip = FindViewById<TextView> (Resource.Id.outputTip);
			outputTotal = FindViewById<TextView> (Resource.Id.outputTotal);

			calculateButton.Click += OnClick;

		}

		void OnClick(object sender, EventArgs e)
		{
			string s = inputBill.Text;

			var bill = double.Parse (s);

			double tip = bill * 0.15;
			double total = bill + tip;

			outputTip.Text = tip.ToString ();
			output
		}
	}
}