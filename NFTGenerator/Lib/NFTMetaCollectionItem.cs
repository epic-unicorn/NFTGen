using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NFTGenerator.Lib
{
    public class NFTMetaCollectionItem
    {
        [JsonIgnore]
        [Browsable(false)]
        public int tokenId { get; set; }

        [Browsable(false)]
        public string name { get; set; }

        [Browsable(false)]
        public string description { get; set; }

        [Browsable(false)]
        public string image { get; set; }

        [Category("Meta data"), DisplayName("Properties")]
        [ReadOnly(true), TypeConverter(typeof(ListConverter))]
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