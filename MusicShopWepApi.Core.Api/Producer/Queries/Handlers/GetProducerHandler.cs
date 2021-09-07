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

namespace MusicShopWepApi.Core.Api.Producer.Queries.Handlers
{
    public class GetProducerHandler : IRequestHandler<GetProducer, ProducerDto>
    {
        private readonly IMapper mapper;
        private readonly IProducerRepository repository;

        public async Task<ProducerDto> Handle(GetProducer request, CancellationToken cancellationToken)
        {
            var producer = await repository.GetAsync(request.Id);
            return mapper.Map<ProducerDto>(producer);
        }
        public GetProducerHandler(IMapper mapper, IProducerRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
    }
}
