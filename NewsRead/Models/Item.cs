using System.Collections.Generic; //needed by List

namespace NewsRead
{
    public class Feed
    {
        public string Id { get; set; } //Id may not be present at Moodle feed. Just to compile
        //public string status { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }

    public class Enclosure
    {
    }

    public class Item
    {
        public string Id { get; set; } //Id may not be present at Moodle feed. Just to compile
        public string title { get; set; }
        public string pubDate { get; set; }
        public string link { get; set; }
        public string guid { get; set; }
        public string author { get; set; }
        public string thumbnail { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public Enclosure enclosure { get; set; }
        public List<object> categories { get; set; }
    }

    public class RssObject
    {
        public string status { get; set; }
        public Feed feed { get; set; }
        public List<Item> items { get; set; }
    }
}
