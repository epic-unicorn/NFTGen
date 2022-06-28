using Newtonsoft.Json;
using System.Collections.Generic;

namespace NFTGenerator.Lib
{
    public class NFTMetaCollectionItem
    {
        [JsonIgnore]
        public int tokenId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public List<TraitAttribute> attributes { get; set; }

        public static NFTMetaCollectionItem FromJSON(string json)
        {
            return JsonConvert.DeserializeObject<NFTMetaCollectionItem>(json);
        }

        public static string ToJSON(NFTMetaCollectionItem item)
        {
            return JsonConvert.SerializeObject(item, Formatting.Indented);
        }
    }
}