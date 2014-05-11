using System;
using Gtk;
using Mono.Unix;

namespace quadraticequation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			Catalog.Init ("i18n", "./locale");
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
