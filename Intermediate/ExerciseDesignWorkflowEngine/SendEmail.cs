using System;

namespace ExerciseDesignWorkflowEngine
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
           Console.WriteLine("Sending an email...");
        }
    }
}
