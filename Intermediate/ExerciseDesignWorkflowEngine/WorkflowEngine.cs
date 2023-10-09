using System.Collections.Generic;

namespace ExerciseDesignWorkflowEngine
{
    public class WorkflowEngine
    {        
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }

    }
}
