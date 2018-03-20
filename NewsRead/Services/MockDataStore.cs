using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsRead
{
    public class MockDataStore : IDataStore<RssObject>
    {
        RssObject rssObject; /* Use RssObject instead of Items */
        //List<Item> items;

        public MockDataStore()
        {
            /* Use RssObject instead of Items */
            List<Item>items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item {title="Mock Item 1 Title", description="Mock Item 1 Description", content="Mock Item 1 Content"},
                new Item {title="Mock Item 2 Title", description="Mock Item 2 Description", content="Mock Item 2 Content"},
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
            rssObject = new RssObject
            {
                status = "ok",
                items = items,
                feed = new Feed(){ title = "Mock Feed Title", url = "http://127.0.0.1/"} 
            };
        }

        public async Task<RssObject> GetRssObjectAsync(bool forceRefresh = false)
        {
            //Dummy implementation
            return await Task.FromResult(rssObject);;
        }

        /* Use RssObject instead of Items
        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(string catname, bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
        */
        /* Code not applicable in an RSS reader
        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }
        
        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }
        */
    }
}
