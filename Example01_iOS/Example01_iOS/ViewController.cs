using System;

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
    }
}
