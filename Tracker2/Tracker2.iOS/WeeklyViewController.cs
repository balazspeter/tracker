using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Tracker2.iOS
{
    [Register("WeeklyView")]
    public class WeeklyView : UIView
    {
        public WeeklyView()
        {
            Initialize();
        }

        public WeeklyView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Orange;
        }
    }

    [Register("WeeklyViewController")]
    public class WeeklyViewController : UIViewController
    {
        public WeeklyViewController()
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
            View = new WeeklyView();

            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            Title = "Weekly";
        }
    }
}