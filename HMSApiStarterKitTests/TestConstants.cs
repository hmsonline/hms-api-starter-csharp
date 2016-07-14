using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.healthmarketscience.api.samples.dotnet
{
    static class TestConstants
    {
        // TODO: Test with trial.hmsonline.com and a valid key/secret pair, then remove the internal information and uncomment the code below
        internal static Core.HmsApiConfig TEST_API_CONFIGURATION = new Core.HmsApiConfig("https://trial.hmsonline.com", "v1", "masterfile");
        internal const string DEFAULT_KEY = "<get from your sales representative>";
        internal const string DEFAULT_SECRET = "<get from your sales representative>";

        internal static IDictionary<string, string> GetSearchParameters()
        {
            return new Dictionary<string, string>() {
                { "timestamp",  ((long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds).ToString()},
                { "key", TestConstants.DEFAULT_KEY }
            };
        }
    }
}
