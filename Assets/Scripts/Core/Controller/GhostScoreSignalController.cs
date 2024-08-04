using System;
using Core.View;
using Zenject;

namespace Core.Controller
{
    public class GhostScoreSignalController : IInitializable, IDisposable
    {
        private const int ScoreForGhost = 20;
        private readonly SignalBus signalBus;
        private int count = 0;
        private ScoreGhostView _scoreGhostView;
        
        [Inject]
        private void Construct(ScoreGhostView scoreGhostView)
        {
            this._scoreGhostView = scoreGhostView;
        }
        public GhostScoreSignalController(SignalBus signalBus)
        {
            this.signalBus = signalBus;
        }
        public void Initialize()
        {
            signalBus.Subscribe<GhostController>(ScoreAdd);
        }
        public void Dispose()
        {
            signalBus.Unsubscribe<GhostController>(ScoreAdd);
        }
        private void ScoreAdd()
        {
            count += ScoreForGhost;
            SetScore(count);
        }
        private void SetScore(int score)
        {
            _scoreGhostView.SetScore(score);
        }
    }
}
