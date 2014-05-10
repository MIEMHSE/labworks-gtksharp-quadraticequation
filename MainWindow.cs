using System;
using Gtk;

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
		if (entryA.Text == "" || entryB.Text == "" || entryC.Text == "") {
			labelOut.Text = "Введите значения A, B и C. Значения должны быть числами с плавающей запятой.";
			return;
		}
		try {
			A = Convert.ToDouble (entryA.Text);
			B = Convert.ToDouble (entryB.Text);
			C = Convert.ToDouble (entryC.Text);
		} catch (System.FormatException) {
			labelOut.Text = "Неправильно введены A, B или C. Значения должны быть числами с плавающей запятой.";
			return;
		}
		if (A == 0) {
			if (B == 0) {
				if (C == 0) {
					labelOut.Text = "Верное равенство.";
					entryX1.Text = "";
					entryX2.Text = "";
					return;
				}
				labelOut.Text = "Неверное равенство.";
				entryX1.Text = "";
				entryX2.Text = "";
				return;
			}
			labelOut.Text = "Линейное уравнение. Корень один.";
			entryX1.Text = Convert.ToString (C / -B);
			entryX2.Text = "";
			return;
		}
		D = Math.Pow (B, 2) - 4 * A * C;
		if (D < 0) {
			labelOut.Text = "Дискриминант < 0. Уравнение не имеет действительных корней.";
			entryX1.Text = "";
			entryX2.Text = "";
		} else {
			if (D > 0) {
				labelOut.Text = "Дискриминант > 0. Уравнение имеет два корня.";
			} else {
				labelOut.Text = "Дискриминант = 0. Уравнение имеет два одинаковых корня.";
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
		entryA.Text = "";
		entryB.Text = "";
		entryC.Text = "";
		entryX1.Text = "";
		entryX2.Text = "";
		labelOut.Text = "Введите A, B, C в формате чисел с плавающей запятой.";
	}
}
