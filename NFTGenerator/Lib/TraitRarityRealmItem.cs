using System.Collections.Generic;

namespace NFTGenerator.Lib
{
    public class TraitRarityRealmItem
    {
        public string Name { get; set; }
        public double RarityPercentage { get; set; }
        public string Id { get; set; }
        public int NumberOfOccurences { get; set; }
        public List<TraitRarityGroupItem> TraitRarityGroupItems { get; set; }
    }
}
