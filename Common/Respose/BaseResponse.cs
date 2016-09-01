using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Respose
{
    [DataContract]
    public  abstract class BaseResponse
    {

        [DataMember]
        public bool IsSuccess { get; set; }

        [DataMember]
        public string Error { get; set; }
    }
}
