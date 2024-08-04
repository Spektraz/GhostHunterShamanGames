using Core.Controller;
using Core.Factory;
using Core.View;
using Zenject;

namespace Core.Installer
{
    public class GhostInstaller : MonoInstaller<GhostInstaller>
    {
         public GhostMonoFactory ghostMonoFactoryPrefab;
         public ScoreGhostView textScore;
        public override void InstallBindings()
        {
            Container.Bind<GhostController>().AsSingle();
            Container.BindFactory<GhostMonoFactory, GhostMonoFactory.GhostFactory>()
                .FromComponentInNewPrefab(ghostMonoFactoryPrefab);
            Container.BindFactory<KillerGhostSignalFactory, KillerGhostSignalFactory.KillGhostFactory>();
            SignalBusInstaller.Install(Container);
            Container.DeclareSignal<GhostController>();
            Container.BindInterfacesTo<GhostScoreSignalController>().AsSingle();
            Container.Bind<ScoreGhostView>().FromInstance(textScore).AsSingle();
            Container.DeclareSignal<KillGhostsView>();
        }
    }
}
