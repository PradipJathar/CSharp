using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDesignWorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            workflow.Add(new UploadVideo());              // Polymorphic behavior
            workflow.Add(new CallWebService());
            workflow.Add(new SendEmail());
            workflow.Add(new ChangeStatus());

            WorkflowEngine workflowEngine = new WorkflowEngine();            
            workflowEngine.Run(workflow);
        }
    }
}
