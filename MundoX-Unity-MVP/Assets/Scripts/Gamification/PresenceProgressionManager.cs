using UnityEngine;
using UnityEngine.Events;

namespace MundoX.Gamification
{
    public class PresenceProgressionManager : MonoBehaviour
    {
        [Header("Progressão")]
        [SerializeField] private int currentLevel = 1;
        [SerializeField] private int currentXp;
        [SerializeField] private int baseXpPerMinute = 3;
        [SerializeField] private AnimationCurve levelCurve;

        [Header("Eventos")]
        public UnityEvent<int> OnLevelUp;
        public UnityEvent<int, int> OnXpChanged;

        private float _timeAccumulator;

        private void Awake()
        {
            if (levelCurve == null || levelCurve.length == 0)
            {
                levelCurve = AnimationCurve.Linear(1, 100, 50, 2500);
            }
        }

        private void Update()
        {
            _timeAccumulator += Time.deltaTime;
            if (_timeAccumulator >= 60f)
            {
                _timeAccumulator = 0f;
                AddXp(baseXpPerMinute);
            }
        }

        public void AddEventXp(int amount)
        {
            AddXp(Mathf.Max(0, amount));
        }

        private void AddXp(int amount)
        {
            currentXp += amount;
            OnXpChanged?.Invoke(currentXp, GetRequiredXpForNextLevel());

            while (currentXp >= GetRequiredXpForNextLevel())
            {
                currentXp -= GetRequiredXpForNextLevel();
                currentLevel++;
                OnLevelUp?.Invoke(currentLevel);
            }
        }

        private int GetRequiredXpForNextLevel()
        {
            return Mathf.RoundToInt(levelCurve.Evaluate(currentLevel));
        }
    }
}
