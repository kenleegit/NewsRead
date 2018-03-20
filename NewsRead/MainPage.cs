using System;

using Xamarin.Forms;

namespace NewsRead
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page itemsPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    itemsPage = new NavigationPage(new ItemsPage(0))
                        //arguement points to BaseViewModel.NewsSource
                    {
                        Title = "每日代禱",
                        Icon = "tab_feed.png"
                    };

                    break;
                default:
                    itemsPage = new ItemsPage(0)
                    {
                        Title = "每日代禱"
                    };
                    break;
            }

            Children.Add(itemsPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
