namespace AzureFunctions.ServiceBusQueue

open System
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Host
open Microsoft.Extensions.Logging

module SampleFunction =
    [<FunctionName("SampleFunction")>]
    let Run ([<ServiceBusTrigger("your-queue-name-here", Connection = "servicebus-connectionstring")>] (myQueueItem: string),
             (log: ILogger))
        =

        let msg =
            sprintf "ServiceBus queue trigger function processed message: %s" myQueueItem

        log.LogInformation(msg)
