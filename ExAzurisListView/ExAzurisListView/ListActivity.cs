
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ExAzurisListView
{
	[Activity (Label = "ListActivity")]			
	public class ListActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.List);

			ListAdapter lstAdpt = new ListAdapter (this);
			var lst = FindViewById<ListView> (Resource.Id.lstTeste);

			lst.Adapter = lstAdpt;
		}
	}
}

