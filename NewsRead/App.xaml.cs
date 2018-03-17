using Xamarin.Forms;

namespace NewsRead
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = false;
        //public static string BackendUrl = "http://localhost:8887";
        public static string BackendUrl = "https://api.rss2json.com/v1/api.json?rss_url=http%3A%2F%2Fnew.ltshk.net%2Frss%2Ffile.php%2F3619%2Fa91badc54389491a65e8c070e6cd78e6%2Fmod_forum%2F78%2Frss.xml";
        public App()
        {
            InitializeComponent();

            MainPage = new NewsReadPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
