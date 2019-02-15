using Newtonsoft.Json;

namespace HytaleBlogAlerter
{
    //API endpoint
    //https://hytale.com/api/blog/post/published

    /// <summary>
    /// Json template
    /// </summary>
    public class BlogApi
    {
        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("_id")]
        public string _id { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("coverImage")]
        public _coverImage CoverImage { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("bodyExcerpt")]
        public string BodyExcerpt { get; set; }



        public class _coverImage
        {
            [JsonProperty("_id")]
            public string _id { get; set; }
            [JsonProperty("s3key")]
            public string s3key { get; set; }
            [JsonProperty("mimeType")]
            public string mimeType { get; set; }
            [JsonProperty("attached")]
            public bool attached { get; set; }
            [JsonProperty("contentType")]
            public string contentType { get; set; }
            [JsonProperty("contentId")]
            public string contentId { get; set; }
            [JsonProperty("createdAt")]
            public string createdAt { get; set; }
            [JsonProperty("__v")]
            public string __v { get; set; }
        }
    }
}

