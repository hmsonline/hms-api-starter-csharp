using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace com.healthmarketscience.api.samples.dotnet.domain
{

    //TODO: Add more fields that are of interest into this domain class so they can be deserialized
    [DataContract]
    public class Practitioner
    {
        [DataMember(Name = "first_name")]
        public string FirstName;
        [DataMember(Name = "last_name")]
        public string LastName;

        public void DebugPrint()
        {
            Core.DebuggerPrint(
                "Name = " + FirstName + " " + LastName
                );
        }
    }
}
