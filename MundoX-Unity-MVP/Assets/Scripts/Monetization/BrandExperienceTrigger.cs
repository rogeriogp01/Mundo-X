using UnityEngine;
using UnityEngine.Events;

namespace MundoX.Monetization
{
    public class BrandExperienceTrigger : MonoBehaviour
    {
        [SerializeField] private string campaignId;
        [SerializeField] private float cooldownSeconds = 45f;
        public UnityEvent<string> OnCampaignActivated;

        private float _nextAllowedTime;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;
            if (Time.time < _nextAllowedTime) return;

            _nextAllowedTime = Time.time + cooldownSeconds;
            OnCampaignActivated?.Invoke(campaignId);
        }
    }
}
