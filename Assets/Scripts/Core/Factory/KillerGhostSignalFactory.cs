using Core.Controller;
using Zenject;

namespace Core.Factory
{
    public class KillerGhostSignalFactory
    {
        readonly SignalBus _signalBus;
        public KillerGhostSignalFactory(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        public void SetFire()
        {
            _signalBus.Fire(new GhostController());
        }
        public class KillGhostFactory : PlaceholderFactory<KillerGhostSignalFactory>
        {
        }
    }
}
