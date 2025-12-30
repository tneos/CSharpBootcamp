using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    // Task interface(returns result -- method returns same type of value)
    public interface ITask<TResult>
    {
        TResult Perform();
    }

    class EmailTask:ITask<string>
    {
        public string? Recipient {get; set;}
        public string? Message {get; set;}

        public string Perform()
        {
            return $"Email sent to {Recipient} with message {Message}";
        }
    }

    class ReportTask:ITask<string>
    {
        public string? ReportName {get; set;}

        public string Perform()
        {
            return $"Report performed by {ReportName}";
        }
    }

    // Generic class with two types, constraint for TTask, implements ITask interface
    class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        private TTask task {get; set;}
        // Constructor
        public TaskProcessor(TTask task)
        {
            this.task = task;
        }

        public TResult Execute()
        {
            return task.Perform();  
        }

        
    }
}