using System;
//using System.Collections.Generic;

using Xamarin.Forms;

namespace NewsRead
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            //List<Page> itemsPage = null; //(Please try adding to Children directly
            string[] pageTitle = { "院长双周记", "学院消息", "良友电台" };
            string[] iconFile = { "tab_feed.png", "tab_feed.png", "tab_feed.png" };
            int numPages = pageTitle.Length;

            //Create Pages object with their parameters
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    for (int i = 0; i < numPages; i++){
                        //arguement points to BaseViewModel.NewsSource
                        Children.Add(new NavigationPage(new ItemsPage(i))
                        {
                            Title = pageTitle[i],
                            Icon = iconFile[i]
                        });
                    }
                    break;

                default:
                    for (int i = 0; i < numPages; i++)
                    {
                        Children.Add(new ItemsPage(i)
                        {
                            Title = pageTitle[i]
                        });
                    }
                    //for (int i = 0; i < numPages; i++)
                    //{
                    //    itemsPage[i] = new ItemsPage(i) { Title = pageTitle[i] };
                    //}
                    break;
            }

            //Add Pages to children of tabbed page
            //for (int i = 0; i < numPages; i++)
            //{
            //    Children.Add(itemsPage[i]);
            //}

            Title = Children[0].Title;
        }

        //Change title when page is changed
        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
