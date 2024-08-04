using UnityEngine;
using Zenject;

namespace Core.Factory 
{
    public class GhostMonoFactory : MonoBehaviour 
    {
        public class GhostFactory : PlaceholderFactory<GhostMonoFactory>
        {
        }
    }
}
