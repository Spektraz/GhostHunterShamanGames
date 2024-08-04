using Core.Controller;
using Core.Factory;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Zenject;

namespace Core.View
{
    public class KillGhostsView : MonoBehaviour, IPointerClickHandler
    {
        [Inject] private KillerGhostSignalFactory.KillGhostFactory killFactory;
        private Image imageGhost;
        private void OnEnable()
        {
            imageGhost = gameObject.GetComponent<Image>();
        }

        public void Update()
        {
            var gameObjectGhost = gameObject;
            var gamVector3 = gameObjectGhost.transform.position;
            gameObjectGhost.transform.position = new Vector2(gamVector3.x, gamVector3.y+1 * Time.deltaTime);
        }
        public void OnPointerClick(PointerEventData eventData)
        {
            imageGhost.enabled = false;
            var killer = killFactory.Create();
            killer.SetFire();
        }
    }
}
