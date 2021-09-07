using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MusicShopWebApi.Core.Domain.Repositories;
using MusicShopWepApi.Core.Api.Dto;
using MusicShopWepApi.Core.Api.Producer.Query;

namespace MusicShopWepApi.Core.Api.Producer.Queries.Handlers
{
    public class GetProducersListHandler : IRequestHandler<GetProducersList, IEnumerable<ProducerDto>>
    {
        private readonly IMapper mapper;
        private readonly IProducerRepository repository;
        
        async Task<IEnumerable<ProducerDto>> IRequestHandler<GetProducersList, IEnumerable<ProducerDto>>.Handle(GetProducersList request, CancellationToken cancellationToken)
        {
            var producer = await repository.GetAllAsync();
            return mapper.Map<IEnumerable<ProducerDto>>(producer);
        }

        public GetProducersListHandler(IMapper mapper, IProducerRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
    }
}
