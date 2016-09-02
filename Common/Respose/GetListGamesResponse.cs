using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Respose
{
    public class GetListGamesResponse : BaseResponse
    {
        public List<Game> Games {get; set; }
    }
}
