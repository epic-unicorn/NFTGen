﻿using System.Collections.Generic;

namespace NFTGenerator.Lib
{
    public class TraitRarityGroupItem
    {
        public string Name { get; set; }
        public double RarityPercentage { get; set; }
        public string Id { get; set; }
        public int NumberOfOccurences { get; set; }
        public List<TraitRarityItem> TraitRarityItems {get; set;}
    }
}
