using TMPro;
using UnityEngine;

namespace MundoX.UI
{
    public class HudController : MonoBehaviour
    {
        [SerializeField] private TMP_Text levelText;
        [SerializeField] private TMP_Text xpText;

        public void RenderLevel(int level)
        {
            levelText.text = $"Nível {level}";
        }

        public void RenderXp(int currentXp, int requiredXp)
        {
            xpText.text = $"XP {currentXp}/{requiredXp}";
        }
    }
}
