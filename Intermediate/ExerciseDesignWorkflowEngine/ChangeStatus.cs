using System;

namespace ExerciseDesignWorkflowEngine
{
    public class ChangeStatus : IActivity
    {
        public void Execute()
        {
           Console.WriteLine("Changeing the status of the video record...");
        }
    }
}
