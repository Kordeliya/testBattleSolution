using Common.Request;
using Common.Respose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract(IsOneWay = true)]
        AutorizeResponse Autorize(AutorizeRequest request);

        [OperationContract(IsOneWay = true)]
        RegisterResponse Register(RegisterRequest request);
    }
}
