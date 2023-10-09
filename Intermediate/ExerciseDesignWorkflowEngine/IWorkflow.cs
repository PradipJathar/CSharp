using System.Collections.Generic;

namespace ExerciseDesignWorkflowEngine
{
    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
