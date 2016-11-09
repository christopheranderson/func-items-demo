#load "./../item/item.csx"

public static void Run(Item item, ICollector<Item> output, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed with name: {item.name}");
    if(item.count > 0) {
        item.count = item.count - 1;
        output.Add(item);
    } else {
        // do something else here
    }
} 