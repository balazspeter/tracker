using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Tracker2.iOS
{
    [Register("HomeView")]
    public class HomeView : UIView
    {
        public HomeView()
        {
            Initialize();
        }

        public HomeView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Green;
        }
    }

    [Register("HomeViewController")]
    public class HomeViewController : UIViewController
    {
        public HomeViewController()
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
            View = new HomeView();

            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            Title = "Home";
        }
    }
}