using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace com.healthmarketscience.api.samples.dotnet.domain
{
    [DataContract]
    public class SearchResponse
    {
        [DataMember(Name="results-count")]
        public long ResultCount;
        [DataMember(Name="remaining-count-available")]
        public long RemainingAvailable;
        [DataMember(Name="hits")]
        private SearchHits Hits;

        public long MatchCount
        {
            get
            {
                return Hits.Total;
            }
        }

        public List<Practitioner> Practitioners
        {
            get
            {
                return (from p in Hits.Hits
                       select p.SourceData.Practitioner).ToList<Practitioner>();
            }
        }

        public static SearchResponse DeserializeFromResponse(string response)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SearchResponse));
            using (MemoryStream stream = new MemoryStream(Core.DEFAULT_ENCODING.GetBytes(response)))
            {
                return (SearchResponse)serializer.ReadObject(stream);
            }
        }
    }
}
