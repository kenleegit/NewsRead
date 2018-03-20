using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsRead
{
    public interface IDataStore<T>
    {
        Task<T> GetRssObjectAsync(bool forceRefresh = false, 
                                  string OptionalURL = "https://www.news.gov.hk/tc/common/html/ticker.rss.xml");
        /* Use RssObject instead of Items
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        Task<IEnumerable<T>> GetItemsAsync(string catname, bool forceRefresh = false);
        */
        /* Code not applicable in an RSS reader
         * Task<bool> AddItemAsync(T item);
        Task<T> GetItemAsync(string id);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        */
    }
}
