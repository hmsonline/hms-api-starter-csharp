using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace com.healthmarketscience.api.samples.dotnet.domain
{
    [DataContract]
    internal class SearchHit
    {
        [DataMember(Name = "_source")]
        public SearchHitPractitioner SourceData;
    }

    [DataContract]
    internal class SearchHitPractitioner
    {
        [DataMember(Name = "practitioner")]
        public Practitioner Practitioner;
    }


}
