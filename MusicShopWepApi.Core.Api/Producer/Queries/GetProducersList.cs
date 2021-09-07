using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MusicShopWepApi.Core.Api.Dto;

namespace MusicShopWepApi.Core.Api.Producer.Query
{
    public class GetProducersList:IRequest<IEnumerable<ProducerDto>>
    {
        
    }
}
