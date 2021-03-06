using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    /// <summary>
    /// API DomainResolved object.
    /// </summary>
    public class DomainResolved
    {
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("object_id")]
        public int? ObjectId { get; set; }

        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}