using Meta.Controller;
using Zenject;

namespace Meta.Installer
{
    public class StartMenuInstaller   : MonoInstaller<StartMenuInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<StartMenuController>().AsSingle();
        }
    }
}