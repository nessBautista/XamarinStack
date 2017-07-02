using System;
using Foundation;
using UIKit;


namespace Example02_iOS_Calendar
{
    public partial class ViewController : UIViewController
    {        
        CalendarViewController vc;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.			
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            if (vc != null)
            {
                lblResult.Text = vc.netDate.Date.ToShortDateString();
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if (segue.Identifier == "Calendar")
            {

                vc = (CalendarViewController)segue.DestinationViewController;
            }
        }
    }

}
