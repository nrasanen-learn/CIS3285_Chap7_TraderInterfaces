using System;
using Unit8_SRP_F24.Contracts;

namespace Unit8_SRP_F24;

public class RestfulTradeDataProvider : ITradeDataProvider
{
    string url;
    ILogger logger;

    public RestfulTradeDataProvider(string url, ILogger logger)
    {
        this.url = url;
        this.logger = logger;
    }

    public IEnumerable<string> ReadTradeData()
    {
        logger.LogMessage("Reading trade data from Restful API: " + url);

        using (HttpClient client = new HttpClient())
        {
            
        }
        // -------------- Add your code here to fetch trade data from the URL and return it as an IEnumerable<string> --------------
        throw new NotImplementedException();
    }
}
