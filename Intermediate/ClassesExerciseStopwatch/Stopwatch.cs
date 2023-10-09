using System;

namespace ClassesExerciseStopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running.");
            }

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running.");
            }

            _stopTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan? GetDuration()
        {
            return _stopTime - _startTime;
        }
    }
}