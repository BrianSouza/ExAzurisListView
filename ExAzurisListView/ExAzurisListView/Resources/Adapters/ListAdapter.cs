
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
			
	public class ListAdapter : BaseAdapter
	{
		List<Pessoas> lstPessoas = null;
		Activity _activity;
		public ListAdapter(Activity activity)
		{
			this._activity = activity;
			FillList ();
		}

		private void FillList()
		{
			lstPessoas = new List<Pessoas> ();

			Pessoas pessoa1 = new Pessoas{ Id = 1, Nome = "Brian" };
			Pessoas pessoa2 = new Pessoas{ Id = 2, Nome = "Camila" };

			lstPessoas.Add (pessoa1);
			lstPessoas.Add (pessoa2);
		}

		#region implemented abstract members of BaseAdapter

		public override Java.Lang.Object GetItem (int position)
		{
			return null;
		}

		public override long GetItemId (int position)
		{
			return lstPessoas [position].Id;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? _activity.LayoutInflater.Inflate (Resource.Layout.LineList,parent,false);
			var id = view.FindViewById<TextView> (Resource.Id.textView1);
			var nome = view.FindViewById<TextView> (Resource.Id.textView2);

			id.Text = lstPessoas [position].Id.ToString ();
			nome.Text = lstPessoas [position].Nome;

			return view;
		}

		public override int Count {
			get {
				return lstPessoas.Count;
			}
		}

		#endregion

	}
}

