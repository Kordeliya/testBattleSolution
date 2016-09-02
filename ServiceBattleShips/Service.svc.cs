using Common;
using Common.Request;
using Common.Respose;
using Entity;
using ServiceBattleShips.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceBattleShips
{
   
    public class Service : IService
    {
        public Dictionary<User, ICallBackService> callBackCollection = new Dictionary<User, ICallBackService>();
        public MyContext _context = new MyContext();
        public AutorizeResponse Autorize(AutorizeRequest request)
        {
            bool result= false;
            var user = _context.Users.Where(u=>u.Login == request.Login && u.Password == request.Password).FirstOrDefault();
            if(user != null)
            {
                result = true;
                var callback = OperationContext.Current.GetCallbackChannel<ICallBackService>();
                callBackCollection.Add(user, callback);
            }
            AutorizeResponse response = new AutorizeResponse()
            {
                IsSuccess = result
            };
            return response;
        }

        public RegisterResponse Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }


        public CreateGameResponse CreateGame(CreateGameRequest request)
        {

            CreateGameResponse response = new CreateGameResponse {IsSuccess = true };
            return response;
        }

        public GetListGamesResponse GetListAvailableGames(GetListGamesRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
