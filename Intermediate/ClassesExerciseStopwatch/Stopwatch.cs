using System;

namespace ClassesExerciseStopwatch
{
    public class Stopwatch
    {
        private DateTime? startTime;
        private DateTime? stopTime;
        private bool isRunning;

        public void Start()
        {
            if (isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running.");
            }

            startTime = DateTime.Now;
            isRunning = true;
        }

        public void Stop()
        {
            if (!isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running.");
            }

            stopTime = DateTime.Now;
            isRunning = false;
        }

        public TimeSpan? GetDuration()
        {
            if (startTime.HasValue && stopTime.HasValue)
            {
                return stopTime.Value - startTime.Value;
            }
            else
            {
                return null;
            }
        }
    }
}