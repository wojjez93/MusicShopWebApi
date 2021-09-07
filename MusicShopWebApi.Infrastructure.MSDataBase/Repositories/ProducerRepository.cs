﻿using Microsoft.EntityFrameworkCore;
using MusicShopWebApi.Core.Domain.Entieties;
using MusicShopWebApi.Core.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopWebApi.Infrastructure.MSDataBase.Repositories
{
    class ProducerRepository : IProducerRepository
    {
        private readonly MSDataBaseContext context;
        private readonly DbSet<Producer> producer;

        public ProducerRepository(MSDataBaseContext context)
        {
            this.context = context;
            producer = context.Producers;

        }
        public Task<IEnumerable<Producer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Producer> GetAsync(int id)
        {
            return await producer.SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
