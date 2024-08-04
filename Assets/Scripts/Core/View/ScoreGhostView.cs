using UnityEngine;
using UnityEngine.UI;

namespace Core.View
{
    public class ScoreGhostView :MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        public void SetScore(int score)
        {
            scoreText.text = score.ToString();
        }
    }
}
