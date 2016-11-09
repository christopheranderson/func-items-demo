#load "./item.csx"

using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, IAsyncCollector<Item> output, TraceWriter log)
{
    // Get request body
    Item data = await req.Content.ReadAsAsync<Item>();

    if(data != null) {
        await output.AddAsync(data);
    }

    return data == null
        ? req.CreateResponse(HttpStatusCode.BadRequest, "Please send a Item on the request body")
        : req.CreateResponse(HttpStatusCode.OK, "Hello !!! " + data.name);
}