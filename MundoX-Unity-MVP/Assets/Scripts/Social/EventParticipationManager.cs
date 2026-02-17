using UnityEngine;
using MundoX.Gamification;

namespace MundoX.Social
{
    public class EventParticipationManager : MonoBehaviour
    {
        [SerializeField] private PresenceProgressionManager progressionManager;
        [SerializeField] private int joinEventXp = 15;
        [SerializeField] private int stayPerMinuteXp = 5;

        private float _insideTimer;
        private bool _isInside;

        private void Update()
        {
            if (!_isInside) return;

            _insideTimer += Time.deltaTime;
            if (_insideTimer >= 60f)
            {
                _insideTimer = 0f;
                progressionManager.AddEventXp(stayPerMinuteXp);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;
            _isInside = true;
            progressionManager.AddEventXp(joinEventXp);
        }

        private void OnTriggerExit(Collider other)
        {
            if (!other.CompareTag("Player")) return;
            _isInside = false;
            _insideTimer = 0f;
        }
    }
}
