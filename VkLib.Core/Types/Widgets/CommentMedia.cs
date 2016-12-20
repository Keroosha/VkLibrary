using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Widgets 
{
    public class CommentMedia
    {
        /// <summary>
        /// Media item ID
        /// </summary>
        [JsonProperty("item_id")]
        public int? ItemId { get; set; }

        /// <summary>
        /// URL of the preview image (type=photo only)
        /// </summary>
        [JsonProperty("thumb_src")]
        public string ThumbSrc { get; set; }

        /// <summary>
        /// Media type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Media owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

    }
}
