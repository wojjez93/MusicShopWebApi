using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicShopWepApi.Core.Api.Dto;
using MusicShopWepApi.Core.Api.Producer.Queries;
using MusicShopWepApi.Core.Api.Producer.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShopWebApi.WebApi.Controllers
{
    [Route("MusicShop/[controller]")]
    [ApiController]
    public class ProducersController : Controller
    {
        private readonly IMediator mediator;

        public ProducersController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("ProducerInfo/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [AllowAnonymous]
        public async Task<ActionResult<ProducerDto>> GetProducerInformation(int id)
        {
            var producerDto = await mediator.Send(new GetProducer() {Id = id});
            return Ok(producerDto);
        }

        [HttpGet("ProducersList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [AllowAnonymous]
        public async Task<ActionResult<ProducerDto>> GetProducersNamesList()
        {
            var producentDto = await mediator.Send(new GetProducersList());
            return Ok(producentDto);
        }
    }
}
