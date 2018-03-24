using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewsRead
{
    public partial class ItemsVPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsVPage(int thisPageType)
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel()
            {
                //Specify the page source at ItemsViewModel
                newsSource = (BaseViewModel.NewsSourceEnum)thisPageType
            };
            //var htmlSource = new HtmlWebViewSource() { Html = "<h2>Head2</h2><p><strong>Strong Text</strong></p>" };
            //webView.Source = htmlSource.Html;
            //DescriptionWV.Source = "<h2>Head2</h2><p><strong>Strong Text</strong></p>";
        }

        ////async Not implemented yet
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            //I can see the link at Console.
            Console.WriteLine("Opening:" + item.link);
            var modalPage = new ModalPage(item.link);
            await Navigation.PushModalAsync(modalPage);

            // Manually deselect item
            ItemsListView.SelectedItem = null;
        }

        ////async Not implemented yet 
        void AddItem_Clicked(object sender, EventArgs e)
        {
            ////await Navigation.PushAsync(new NewItemPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
