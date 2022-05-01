using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MyFunctionAppQueueSingletonSample
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([QueueTrigger("myqueue-items-1", Connection = "")]string myQueueItem, ILogger log, ExecutionContext executionContext)
        {
            log.LogInformation($"{executionContext.InvocationId} {myQueueItem}");
        }
    }
}
