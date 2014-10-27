using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Calculator
{
	public partial class CalculatorViewController : UIViewController
	{
		string operand1 = string.Empty; 
		string operand2 = string.Empty; 
		string result; 
		char operation; 

		public CalculatorViewController() : base("CalculatorViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void ButtonZeroPress(NSObject sender)
		{
			ViewLabel.Text += "0";
		}

		partial void ButtonOnePress(NSObject sender)
		{
			ViewLabel.Text += "1";
		}

		partial void ButtonTwoPress(NSObject sender)
		{
			ViewLabel.Text += "2";
		}

		partial void ButtonThreePress(NSObject sender)
		{
			ViewLabel.Text += "3";
		}

		partial void ButtonFourPress(NSObject sender)
		{
			ViewLabel.Text += "4";
		}

		partial void ButtonFivePress(NSObject sender)
		{
			ViewLabel.Text += "5";
		}

		partial void ButtonSixPress(NSObject sender)
		{
			ViewLabel.Text += "6";
		}

		partial void ButtonSevenPress(NSObject sender)
		{
			ViewLabel.Text += "7";
		}

		partial void ButtonEightPress(NSObject sender)
		{
			ViewLabel.Text += "8";
		}

		partial void ButtonNinePress(NSObject sender)
		{
			ViewLabel.Text += "9";
		}

		partial void ButtonPlusPress(NSObject sender)
		{
			operand1 = ViewLabel.Text;
			operation = '+';
			ViewLabel.Text = string.Empty;
		}

		partial void ButtonMinusPress(NSObject sender)
		{
			operand1 = ViewLabel.Text;
			operation = '-';
			ViewLabel.Text = string.Empty;
		}

		partial void ButtonMultiplyPress(NSObject sender)
		{
			operand1 = ViewLabel.Text;
			operation = '*';
			ViewLabel.Text = string.Empty;
		}

		partial void ButtonDividePress(NSObject sender)
		{
			operand1 = ViewLabel.Text;
			operation = '/';
			ViewLabel.Text = string.Empty;
		}

		partial void ButtonEqualsPress(NSObject sender)
		{
			operand2 = ViewLabel.Text;

			double opr1; 
			double opr2; 
			double.TryParse(operand1, out opr1); 
			double.TryParse(operand2, out opr2);

			switch (operation) 
			{ 
				case '+': 
					result = (opr1 + opr2).ToString(); 
					break; 

				case '-': 
					result = (opr1 - opr2).ToString(); 
					break; 

				case '*': 
					result = (opr1 * opr2).ToString(); 
					break; 

				case '/': 
					if (opr2 != 0) 
					{ 
						result = (opr1 / opr2).ToString(); 
					} 
					else 
					{ 
						result =  "Can't divide by zero"; 
					} 
					break; 
			} 

			ViewLabel.Text = result.ToString();  
		}

		partial void ButtonClearPress(NSObject sender)
		{
			ViewLabel.Text = String.Empty;
		}
	}
}

