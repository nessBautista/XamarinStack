using System;
using System.Diagnostics;
using System.Text;
using UIKit;

namespace Example01_iOS
{
    public partial class ViewController : UIViewController
    {       
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.label1.Text = "label 1 with a lot of text: Adding a lot of textAdding a lot of textAdding a lot of textAdding a lot of textAdding a lot of textAdding a lot of text";
            this.label2.Text = "This is label 2";
            this.label3.Text = "Hello I'm the label 3";
            this.btnLambda.TouchUpInside += (sender, e) => 
            {
				var alert = UIAlertController.Create("Lambda Button", "Action by Lambda Expression", UIAlertControllerStyle.Alert);
				alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, ChangeLabel1Color));
				PresentViewController(alert, true, null);
            };

            //Code basics
            //this.variablesExample();
            buildingStrings();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void Btn1_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
            this.label3.Text = this.txt1.Text;
        }

        partial void UIButton5VNlIKL3_TouchUpInside(UIButton sender)
        {
            var alert = UIAlertController.Create("An Alert", "Hello this is a simple allert", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, ChangeLabel1Color));
            PresentViewController(alert, true, null);
        }

        private void ChangeLabel1Color(UIAlertAction action)
        {
            this.label1.BackgroundColor = UIColor.Blue;
        }

        private void variablesExample()
        {
            //char array
            char[] charArray = { 'h','e','l','l','o'};
            Debug.WriteLine("The output of charArray is" + charArray);
            //String
            string hello = new string(charArray);
            Debug.WriteLine("The output of hello is: " + hello);

            string helloUpper = hello.ToUpper();
            Debug.WriteLine("The output of helloUpper is: " + helloUpper);

            string sub = hello.Substring(3, 2);
            Debug.WriteLine("The output of sub is: " + sub);
        }

        private void buildingStrings()
        {
            //Appending
            StringBuilder builder = new StringBuilder();
            builder.Append("Hello");    
            Debug.WriteLine(builder);
            builder.Append(",")
                   .Append(" World")
                   .Append("!");
            Debug.WriteLine(builder);

            //Parsing
            string s = "255";
            int intFromString = Int32.Parse(s);
            Debug.WriteLine("Value from string: " + intFromString);

            int sByTwo = intFromString * 2;
            Debug.WriteLine("s * 2: " + sByTwo);

            string s2 = "10.5";
            double doubleFromString = Double.Parse(s2);
            Debug.WriteLine("double from string: " + doubleFromString);

            string s3 = "10.0";
            double parsedS3;
            if(Double.TryParse(s3, out parsedS3))
            {
                Debug.WriteLine("double from string: " + parsedS3);
            }
            else 
            {
                Debug.WriteLine("Couldn't parse that value");
            }
        }


    }
}
