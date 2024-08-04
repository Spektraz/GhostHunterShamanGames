using Core.Factory;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Core.View
{
    public class GhostSpawnerView : MonoBehaviour
    {
        private const int RangeYConst = 10;
        private const int RangeXConst = 7;
        [Inject] private GhostMonoFactory.GhostFactory ghostFactory;
        [SerializeField] private Canvas mainCanvas;
        public int maxCountGhost;
        public float timeBetweenSpawns = 1.0f;
        private int countGhost;
        private float timeSinceSpawn;
        public void Update()
        {
            if (maxCountGhost <= countGhost) return;
            timeSinceSpawn += Time.deltaTime;
            if (!(timeSinceSpawn > timeBetweenSpawns)) return;
            var consumer = ghostFactory.Create();
            consumer.transform.SetParent(mainCanvas.transform, false);
            consumer.transform.position = GetRandomSpawnPosition();
            timeSinceSpawn = 0;
            countGhost++;
        }

        private Vector3 GetRandomSpawnPosition()
        {
            var xPos = Random.Range(-RangeXConst, RangeXConst); 
            var yPos = Random.Range(-RangeYConst, 0);
            return new Vector3(xPos, yPos);
        }
    }
}
