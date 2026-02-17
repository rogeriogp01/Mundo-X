using System.Collections.Generic;
using UnityEngine;

namespace MundoX.Backend
{
    public class FirebaseProfileRepository : MonoBehaviour
    {
        public string UserId { get; private set; }

        public void SetAuthenticatedUser(string userId)
        {
            UserId = userId;
        }

        public void SaveProgress(int level, int xp, IEnumerable<string> inventoryItemIds)
        {
            Debug.Log($"[FirebaseProfileRepository] SaveProgress user={UserId} level={level} xp={xp}");
            foreach (var itemId in inventoryItemIds)
            {
                Debug.Log($"[FirebaseProfileRepository] InventoryItem={itemId}");
            }
        }
    }
}
