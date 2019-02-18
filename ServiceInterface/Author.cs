using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterface
{




        [DataContract]

        [SwaggerWcfDefinition("author")]

        public class Author

        {

            [DataMember]

            public string Id { get; set; }



            [DataMember]

            public string Name { get; set; }

        }

    
}
