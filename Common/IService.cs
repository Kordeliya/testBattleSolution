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
    [ServiceContract(CallbackContract = typeof(ICallBackService))]
    public interface IService
    {
        [OperationContract(IsOneWay = false)]
        AutorizeResponse Autorize(AutorizeRequest request);

        [OperationContract(IsOneWay = false)]
        RegisterResponse Register(RegisterRequest request);

        [OperationContract(IsOneWay = false)]
        CreateGameResponse CreateGame(CreateGameRequest request);

        [OperationContract(IsOneWay = false)]
        GetListGamesResponse GetListAvailableGames(GetListGamesRequest request);
    }
}
