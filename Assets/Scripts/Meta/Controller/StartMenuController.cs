using Meta.View;
using Zenject;

namespace Meta.Controller
{
    public class StartMenuController
    {
        [Inject]
        private void Construct(StartButtonView startButtonView)
        {
        }
    }
}
