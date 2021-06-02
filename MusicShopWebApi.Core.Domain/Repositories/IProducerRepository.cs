using MusicShopWebApi.Core.Domain.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopWebApi.Core.Domain.Repositories
{
    public interface IProducerRepository
    {
        Task<IEnumerable<Producer>> GetAllAsync();
        Task<Producer> GetAsync(int id);
    }
}
