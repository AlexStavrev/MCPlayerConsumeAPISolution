using System.Diagnostics;

namespace VisualEffects.Animators
{
    public class AnimationStatus : EventArgs
    {
        private readonly Stopwatch _stopwatch;

        public long ElapsedMilliseconds
        {
            get { return _stopwatch.ElapsedMilliseconds; }
        }
        public CancellationTokenSource CancellationToken { get; private set; }
        public bool IsCompleted { get; set; }

        public AnimationStatus(CancellationTokenSource token, Stopwatch stopwatch)
        {
            CancellationToken = token;
            _stopwatch = stopwatch;
        }
    }
}
