using Foundation;
using System;
using UIKit;
using TimesSquare.iOS;
                 
namespace Example02_iOS_Calendar
{
    public partial class CalendarViewController : UIViewController
    {
        public DateTime netDate;
        UserData data;
        public CalendarViewController (IntPtr handle) : base (handle)
        {
         
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var calendarView = new TSQCalendarView(View.Bounds)
			{
				Calendar = new Foundation.NSCalendar(Foundation.NSCalendarType.Gregorian),
				FirstDate = Foundation.NSDate.Now,
				BackgroundColor = UIColor.LightTextColor,
				PagingEnabled = true
			};

			//Setup handles
			calendarView.DidSelectDate += (sender, e) =>
			{
				netDate = (DateTime)e.Date;
                data = new UserData();
                data.BirthDate = netDate;
			};

            View.Add(calendarView);
		}
    }
}