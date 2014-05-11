
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Label label5;
	private global::Gtk.Label label6;
	private global::Gtk.HBox hbox2;
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label label7;
	private global::Gtk.Entry entryA;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Label label8;
	private global::Gtk.Entry entryB;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Label label9;
	private global::Gtk.Entry entryC;
	private global::Gtk.VBox vbox3;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Label label11;
	private global::Gtk.Entry entryX1;
	private global::Gtk.Label label12;
	private global::Gtk.Entry entryX2;
	private global::Gtk.Label labelOut;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Button buttonRst;
	private global::Gtk.Button buttonSolve;
	private global::Gtk.Button buttonQuit;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Quadratic equation roots");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Homogeneous = true;
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Homogeneous = true;
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Equation coefficients");
		this.hbox1.Add (this.label5);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label5]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Equation roots");
		this.hbox1.Add (this.label6);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label6]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Homogeneous = true;
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = "a =";
		this.hbox3.Add (this.label7);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label7]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entryA = new global::Gtk.Entry ();
		this.entryA.CanFocus = true;
		this.entryA.Name = "entryA";
		this.entryA.IsEditable = true;
		this.entryA.InvisibleChar = '●';
		this.entryA.Xalign = 1F;
		this.hbox3.Add (this.entryA);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entryA]));
		w5.Position = 1;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = "b =";
		this.hbox4.Add (this.label8);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label8]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.entryB = new global::Gtk.Entry ();
		this.entryB.CanFocus = true;
		this.entryB.Name = "entryB";
		this.entryB.IsEditable = true;
		this.entryB.InvisibleChar = '●';
		this.entryB.Xalign = 1F;
		this.hbox4.Add (this.entryB);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entryB]));
		w8.Position = 1;
		this.vbox2.Add (this.hbox4);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = "c =";
		this.hbox5.Add (this.label9);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label9]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.entryC = new global::Gtk.Entry ();
		this.entryC.CanFocus = true;
		this.entryC.Name = "entryC";
		this.entryC.IsEditable = true;
		this.entryC.InvisibleChar = '●';
		this.entryC.Xalign = 1F;
		this.hbox5.Add (this.entryC);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.entryC]));
		w11.Position = 1;
		this.vbox2.Add (this.hbox5);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox5]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.hbox2.Add (this.vbox2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox2]));
		w13.Position = 0;
		w13.Padding = ((uint)(6));
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Homogeneous = true;
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = "x1 =";
		this.hbox6.Add (this.label11);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label11]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.entryX1 = new global::Gtk.Entry ();
		this.entryX1.CanFocus = true;
		this.entryX1.Name = "entryX1";
		this.entryX1.IsEditable = true;
		this.entryX1.InvisibleChar = '●';
		this.entryX1.Xalign = 1F;
		this.hbox6.Add (this.entryX1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.entryX1]));
		w15.Position = 1;
		// Container child hbox6.Gtk.Box+BoxChild
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.LabelProp = "x2 =";
		this.hbox6.Add (this.label12);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label12]));
		w16.Position = 2;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.entryX2 = new global::Gtk.Entry ();
		this.entryX2.CanFocus = true;
		this.entryX2.Name = "entryX2";
		this.entryX2.IsEditable = true;
		this.entryX2.InvisibleChar = '●';
		this.entryX2.Xalign = 1F;
		this.hbox6.Add (this.entryX2);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.entryX2]));
		w17.PackType = ((global::Gtk.PackType)(1));
		w17.Position = 3;
		this.vbox3.Add (this.hbox6);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox6]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.labelOut = new global::Gtk.Label ();
		this.labelOut.Name = "labelOut";
		this.labelOut.LabelProp = global::Mono.Unix.Catalog.GetString ("Type A, B, C in floating-point format.");
		this.vbox3.Add (this.labelOut);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelOut]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		this.hbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		w20.Padding = ((uint)(6));
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w21.Position = 1;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Homogeneous = true;
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.buttonRst = new global::Gtk.Button ();
		this.buttonRst.CanFocus = true;
		this.buttonRst.Name = "buttonRst";
		this.buttonRst.UseUnderline = true;
		this.buttonRst.Label = global::Mono.Unix.Catalog.GetString ("Reset");
		this.hbox7.Add (this.buttonRst);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonRst]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.buttonSolve = new global::Gtk.Button ();
		this.buttonSolve.CanDefault = true;
		this.buttonSolve.CanFocus = true;
		this.buttonSolve.Name = "buttonSolve";
		this.buttonSolve.UseUnderline = true;
		this.buttonSolve.Label = global::Mono.Unix.Catalog.GetString ("Solve");
		this.hbox7.Add (this.buttonSolve);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonSolve]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.buttonQuit = new global::Gtk.Button ();
		this.buttonQuit.CanFocus = true;
		this.buttonQuit.Name = "buttonQuit";
		this.buttonQuit.UseUnderline = true;
		this.buttonQuit.Label = global::Mono.Unix.Catalog.GetString ("Close");
		this.hbox7.Add (this.buttonQuit);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonQuit]));
		w24.Position = 2;
		w24.Expand = false;
		w24.Fill = false;
		this.vbox1.Add (this.hbox7);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox7]));
		w25.Position = 2;
		w25.Expand = false;
		w25.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 648;
		this.DefaultHeight = 353;
		this.buttonSolve.HasDefault = true;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonRst.Clicked += new global::System.EventHandler (this.OnButtonRstClicked);
		this.buttonSolve.Clicked += new global::System.EventHandler (this.OnButtonSolveClicked);
		this.buttonQuit.Clicked += new global::System.EventHandler (this.OnButtonQuitClicked);
	}
}
