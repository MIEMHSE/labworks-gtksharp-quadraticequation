using System;
using Gtk;
using Mono.Unix;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButtonSolveClicked (object sender, EventArgs e)
	{
		Double A = 0, B = 0, C = 0, D = 0;
		if (entryA.Text.Length == 0 || entryB.Text.Length == 0 || entryC.Text.Length == 0) {
			labelOut.Text = Catalog.GetString("Type A, B and C. Values are to be in floating-point format.");
			return;
		}
		try {
			A = Convert.ToDouble (entryA.Text);
			B = Convert.ToDouble (entryB.Text);
			C = Convert.ToDouble (entryC.Text);
		} catch (System.FormatException) {
			labelOut.Text = Catalog.GetString("A, B or C are typed incorrectly. They are to be floating-point numbers.");
			return;
		}
		if (A == 0) {
			if (B == 0) {
				if (C == 0) {
					labelOut.Text = Catalog.GetString("Correct equality.");
					entryX1.Text = String.Empty;
					entryX2.Text = String.Empty;
					return;
				}
				labelOut.Text = Catalog.GetString("Incorrect equality.");
				entryX1.Text = String.Empty;
				entryX2.Text = String.Empty;
				return;
			}
			labelOut.Text = Catalog.GetString("Linear equation. Only one root.");
			entryX1.Text = Convert.ToString (C / -B);
			entryX2.Text = String.Empty;
			return;
		}
		D = Math.Pow (B, 2) - 4 * A * C;
		if (D < 0) {
			labelOut.Text = Catalog.GetString("Discriminant < 0. Equation has no real roots.");
			entryX1.Text = String.Empty;
			entryX2.Text = String.Empty;
		} else {
			if (D > 0) {
				labelOut.Text = Catalog.GetString("Discriminant > 0. Equation has two roots.");
			} else {
				labelOut.Text = Catalog.GetString("Discriminant = 0. Equation has two equal roots.");
			}
			entryX1.Text = Convert.ToString (-B + Math.Sqrt (D));
			entryX2.Text = Convert.ToString (-B - Math.Sqrt (D));
		}
	}

	protected void OnButtonQuitClicked (object sender, EventArgs e)
	{
		Application.Quit ();
	}

	protected void OnButtonRstClicked (object sender, EventArgs e)
	{
		entryA.Text = String.Empty;
		entryB.Text = String.Empty;
		entryC.Text = String.Empty;
		entryX1.Text = String.Empty;
		entryX2.Text = String.Empty;
		labelOut.Text = Catalog.GetString("Type A, B, C in floating-point format.");
	}
}
