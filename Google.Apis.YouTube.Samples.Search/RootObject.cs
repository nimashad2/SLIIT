using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AuthorChannelId
    {
        public string value { get; set; }
    }

    public class Snippet2
    {
        public AuthorChannelId authorChannelId { get; set; }
        public string authorChannelUrl { get; set; }
        public string authorDisplayName { get; set; }
        public string authorProfileImageUrl { get; set; }
        public bool canRate { get; set; }
        public object channelId { get; set; }
        public int likeCount { get; set; }
        public object moderationStatus { get; set; }
        public object parentId { get; set; }
        public DateTime publishedAt { get; set; }
        public string textDisplay { get; set; }
        public string textOriginal { get; set; }
        public DateTime updatedAt { get; set; }
        public string videoId { get; set; }
        public string viewerRating { get; set; }
        public object ETag { get; set; }
    }

    public class TopLevelComment
    {
        public string etag { get; set; }
        public string id { get; set; }
        public string kind { get; set; }
        public Snippet2 snippet { get; set; }
    }

    public class Snippet
    {
        public bool canReply { get; set; }
        public object channelId { get; set; }
        public bool isPublic { get; set; }
        public TopLevelComment topLevelComment { get; set; }
        public int totalReplyCount { get; set; }
        public string videoId { get; set; }
        public object ETag { get; set; }
    }

    public class Item
    {
        public string etag { get; set; }
        public string id { get; set; }
        public string kind { get; set; }
        public object replies { get; set; }
        public Snippet snippet { get; set; }
    }

    public class PageInfo
    {
        public int resultsPerPage { get; set; }
        public int totalResults { get; set; }
        public object ETag { get; set; }
    }

    public class RootObject
    {
        public string etag { get; set; }
        public object eventId { get; set; }
        public List<Item> items { get; set; }
        public string kind { get; set; }
        public string nextPageToken { get; set; }
        public PageInfo pageInfo { get; set; }
        public object tokenPagination { get; set; }
        public object visitorId { get; set; }
    }

