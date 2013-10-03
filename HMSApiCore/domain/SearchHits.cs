using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace com.healthmarketscience.api.samples.dotnet.domain
{
    [DataContract]
    internal class SearchHits
    {
        [DataMember(Name = "total")]
        public long Total;
        [DataMember(Name = "hits")]
        public IList<SearchHit> Hits;
    }
}
