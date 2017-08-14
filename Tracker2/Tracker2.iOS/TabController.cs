using System;
using UIKit;

namespace Tracker2.iOS
{
    public class TabController : UITabBarController
    {

        UIViewController tab1, tab2, tab3;

        public TabController()
        {
            tab1 = new HomeViewController();
            tab1.Title = "Home";

            tab2 = new WeeklyViewController();
            tab2.Title = "Weekly";

            tab3 = new MonthlyViewController();
            tab3.Title = "Monthly";

            var tabs = new UIViewController[] {
                                tab1, tab2, tab3
                        };

            ViewControllers = tabs;
        }
    }
}