using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API Users object.
    /// </summary>
    public class Users
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("accesses")]
        public IEnumerable<Accesses> Accesses { get; set; }
    }
}