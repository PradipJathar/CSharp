using System;

namespace ExerciseDesignWorkflowEngine
{
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling a web service...");
        }
    }
}
