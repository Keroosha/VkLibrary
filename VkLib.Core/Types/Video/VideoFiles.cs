using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Video 
{
    public class VideoFiles
    {
        /// <summary>
        /// URL of the mpeg4 file with 240p quality
        /// </summary>
        [JsonProperty("mp_240")]
        public string Mp240 { get; set; }

        /// <summary>
        /// URL of the mpeg4 file with 360p quality
        /// </summary>
        [JsonProperty("mp_360")]
        public string Mp360 { get; set; }

        /// <summary>
        /// URL of the mpeg4 file with 720p quality
        /// </summary>
        [JsonProperty("mp_720")]
        public string Mp720 { get; set; }

        /// <summary>
        /// URL of the external player
        /// </summary>
        [JsonProperty("external")]
        public string External { get; set; }

        /// <summary>
        /// URL of the mpeg4 file with 480p quality
        /// </summary>
        [JsonProperty("mp_480")]
        public string Mp480 { get; set; }

    }
}
