using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Orders 
{
    public class Amount
    {
        /// <summary>
        /// Currency name
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("amounts")]
        public IEnumerable<VkLib.Types.Orders.AmountItem> Amounts { get; set; }

    }
}
