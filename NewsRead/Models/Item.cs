using System.Collections.Generic; //needed by List

namespace NewsRead
{
    /* Generated at http://json2csharp.com/ */
    public class Feed
    {
        public string url { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }

    public class Rating
    {
        public string scheme { get; set; } //Txly2
        public string value { get; set; } //Txly2
    }

    public class Enclosure
    {
        public string link { get; set; } //Txly2
        public string type { get; set; } //Txly2
        public int length { get; set; } //Txly2
        public int duration { get; set; } //Txly2
        public Rating rating { get; set; } //Txly2
    }

    public class Item
    {
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
