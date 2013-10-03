using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.healthmarketscience.api.samples.dotnet.domain;

namespace com.healthmarketscience.api.samples.dotnet
{
    public class Search
    {
        public static SearchResponse findAll(IDictionary<String, String> parameters = null, string secret = null)
        {
            return find(@"{""match_all"":{}}", parameters, secret);
        }
        public static SearchResponse find(string elasticQuery, IDictionary<String, String> parameters = null, string secret = null)
        {
            if (parameters == null)
            {
                parameters = Core.SecurityParameters;
            }
            string context = Core.HMS_API_SEARCH_WEBSERVICE_PATH() +
                (parameters != null && parameters.Count > 0 ?
                "?" + string.Join("&", parameters.Select(p => p.Key + "=" + p.Value).ToArray()) :
                string.Empty);

            string searchResponse = Core.CallWebServicePost(context, elasticQuery, secret);
            Core.DebuggerPrintWebResponse(context, searchResponse);
            return SearchResponse.DeserializeFromResponse(searchResponse);
        }
    }
}
