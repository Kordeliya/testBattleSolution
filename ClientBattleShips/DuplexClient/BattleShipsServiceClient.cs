using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ClientBattleShips.DuplexClient
{
    public class BattleShipsServiceClient : DuplexClientBase<ICallBackService>, IService
    {
        public BattleShipsServiceClient(InstanceContext callbackInstance) :
            base(callbackInstance)
        {
        }

        public BattleShipsServiceClient(InstanceContext callbackInstance, string endpointConfigurationName) :
            base(callbackInstance, endpointConfigurationName)
        {
        } 


        public Common.Respose.AutorizeResponse Autorize(Common.Request.AutorizeRequest request)
        {
            throw new NotImplementedException();
        }

        public Common.Respose.RegisterResponse Register(Common.Request.RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        public Common.Respose.CreateGameResponse CreateGame(Common.Request.CreateGameRequest request)
        {
            throw new NotImplementedException();
        }

        public Common.Respose.GetListGamesResponse GetListAvailableGames(Common.Request.GetListGamesRequest request)
        {
            throw new NotImplementedException();
        }

        public void DoMove()
        {
        }
    }
}