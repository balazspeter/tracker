using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Tracker2.iOS
{
    [Register("MonthlyView")]
    public class MonthlyView : UIView
    {
        public MonthlyView()
        {
            Initialize();
        }

        public MonthlyView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }

    [Register("MonthlyViewController")]
    public class MonthlyViewController : UIViewController
    {
        public MonthlyViewController()
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
            View = new MonthlyView();

            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            Title = "Monthly";
        }
    }
}