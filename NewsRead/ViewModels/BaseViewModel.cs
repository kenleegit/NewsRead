using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace NewsRead
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public enum NewsSourceEnum { RSSMoodleDean, RSSMoodleNews, Txly2};
        public string[] NewsURL = {
            "https://api.rss2json.com/v1/api.json?rss_url=http%3A%2F%2Fnew.ltshk.net%2Frss%2Ffile.php%2F3619%2Fa91badc54389491a65e8c070e6cd78e6%2Fmod_forum%2F78%2Frss.xml",
            "https://api.rss2json.com/v1/api.json?rss_url=http%3A%2F%2Fnew.ltshk.net%2Frss%2Ffile.php%2F1244%2Fa91badc54389491a65e8c070e6cd78e6%2Fmod_forum%2F43%2Frss.xml",
            "https://api.rss2json.com/v1/api.json?rss_url=https%3A%2F%2Ftxly2.net%2Findex.php%3Foption%3Dcom_sermonspeaker%26view%3Dfeed%26format%3Draw%26type%3Daudio%26Itemid%3D233"
            };

        public IDataStore<RssObject> DataStore => DependencyService.Get<IDataStore<RssObject>>() ?? new MockDataStore();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
