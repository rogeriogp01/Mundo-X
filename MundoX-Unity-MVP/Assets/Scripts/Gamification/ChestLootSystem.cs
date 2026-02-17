using System;
using System.Collections.Generic;
using UnityEngine;

namespace MundoX.Gamification
{
    public class ChestLootSystem : MonoBehaviour
    {
        [Serializable]
        public struct LootEntry
        {
            public string itemId;
            public float weight;
            public string rarity;
        }

        [SerializeField] private List<LootEntry> lootTable = new();

        public LootEntry OpenChest()
        {
            var totalWeight = 0f;
            foreach (var entry in lootTable)
            {
                totalWeight += Mathf.Max(0f, entry.weight);
            }

            var roll = UnityEngine.Random.Range(0f, totalWeight);
            var cumulative = 0f;
            foreach (var entry in lootTable)
            {
                cumulative += Mathf.Max(0f, entry.weight);
                if (roll <= cumulative)
                {
                    return entry;
                }
            }

            return lootTable.Count > 0 ? lootTable[^1] : default;
        }
    }
}
