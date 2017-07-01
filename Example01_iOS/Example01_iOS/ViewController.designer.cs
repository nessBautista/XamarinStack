// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Example01_iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btn1 { get; set; }

		[Outlet]
		UIKit.UIButton btnLambda { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel label1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel label2 { get; set; }

		[Outlet]
		UIKit.UILabel label3 { get; set; }

		[Outlet]
		UIKit.UILabel label4 { get; set; }

		[Outlet]
		UIKit.UITextField txt1 { get; set; }

		[Action ("Btn1_TouchUpInside:")]
		partial void Btn1_TouchUpInside (UIKit.UIButton sender);

		[Action ("UIButton5VNlIKL3_TouchUpInside:")]
		partial void UIButton5VNlIKL3_TouchUpInside (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btn1 != null) {
				btn1.Dispose ();
				btn1 = null;
			}

			if (label1 != null) {
				label1.Dispose ();
				label1 = null;
			}

			if (label2 != null) {
				label2.Dispose ();
				label2 = null;
			}

			if (label3 != null) {
				label3.Dispose ();
				label3 = null;
			}

			if (label4 != null) {
				label4.Dispose ();
				label4 = null;
			}

			if (txt1 != null) {
				txt1.Dispose ();
				txt1 = null;
			}

			if (btnLambda != null) {
				btnLambda.Dispose ();
				btnLambda = null;
			}
		}
	}
}
