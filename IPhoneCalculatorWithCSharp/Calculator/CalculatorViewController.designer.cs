// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Calculator
{
	[Register ("CalculatorViewController")]
	partial class CalculatorViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton ButtonClear { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonDivide { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonEight { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonEquals { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonFive { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonFour { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonMinus { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonMultiply { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonNine { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonOne { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonPlus { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonSeven { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonSix { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonThree { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonTwo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonZero { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField ViewLabel { get; set; }

		[Action ("ButtonClearPress:")]
		partial void ButtonClearPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonDividePress:")]
		partial void ButtonDividePress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonEightPress:")]
		partial void ButtonEightPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonEqualsPress:")]
		partial void ButtonEqualsPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonFivePress:")]
		partial void ButtonFivePress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonFourPress:")]
		partial void ButtonFourPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonMinusPress:")]
		partial void ButtonMinusPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonMultiplyPress:")]
		partial void ButtonMultiplyPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonNinePress:")]
		partial void ButtonNinePress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonOnePress:")]
		partial void ButtonOnePress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonPlusPress:")]
		partial void ButtonPlusPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonSevenPress:")]
		partial void ButtonSevenPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonSixPress:")]
		partial void ButtonSixPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonThreePress:")]
		partial void ButtonThreePress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonTwoPress:")]
		partial void ButtonTwoPress (MonoTouch.Foundation.NSObject sender);

		[Action ("ButtonZeroPress:")]
		partial void ButtonZeroPress (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ViewLabel != null) {
				ViewLabel.Dispose ();
				ViewLabel = null;
			}

			if (ButtonZero != null) {
				ButtonZero.Dispose ();
				ButtonZero = null;
			}

			if (ButtonOne != null) {
				ButtonOne.Dispose ();
				ButtonOne = null;
			}

			if (ButtonTwo != null) {
				ButtonTwo.Dispose ();
				ButtonTwo = null;
			}

			if (ButtonThree != null) {
				ButtonThree.Dispose ();
				ButtonThree = null;
			}

			if (ButtonFour != null) {
				ButtonFour.Dispose ();
				ButtonFour = null;
			}

			if (ButtonFive != null) {
				ButtonFive.Dispose ();
				ButtonFive = null;
			}

			if (ButtonSix != null) {
				ButtonSix.Dispose ();
				ButtonSix = null;
			}

			if (ButtonSeven != null) {
				ButtonSeven.Dispose ();
				ButtonSeven = null;
			}

			if (ButtonEight != null) {
				ButtonEight.Dispose ();
				ButtonEight = null;
			}

			if (ButtonNine != null) {
				ButtonNine.Dispose ();
				ButtonNine = null;
			}

			if (ButtonPlus != null) {
				ButtonPlus.Dispose ();
				ButtonPlus = null;
			}

			if (ButtonMinus != null) {
				ButtonMinus.Dispose ();
				ButtonMinus = null;
			}

			if (ButtonMultiply != null) {
				ButtonMultiply.Dispose ();
				ButtonMultiply = null;
			}

			if (ButtonDivide != null) {
				ButtonDivide.Dispose ();
				ButtonDivide = null;
			}

			if (ButtonEquals != null) {
				ButtonEquals.Dispose ();
				ButtonEquals = null;
			}

			if (ButtonClear != null) {
				ButtonClear.Dispose ();
				ButtonClear = null;
			}
		}
	}
}
