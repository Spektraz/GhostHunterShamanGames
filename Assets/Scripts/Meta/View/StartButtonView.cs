using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Meta.View
{
    public class StartButtonView : MonoBehaviour
    {
         [SerializeField] private Button buttonStart;
        private void SetButton()
        {
            SceneManager.LoadScene((int)SceneType.MainScene);
        }
        public void Start()
        {
            buttonStart.onClick.AddListener(SetButton);
        }

        public void OnDestroy()
        {
            buttonStart.onClick.RemoveListener(SetButton);
        }
        private enum SceneType 
        {
            StartScene = 0,
            MainScene = 1,
        }
    }
}
