using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicShopWebApi.Core.Domain.Entieties;

namespace MusicShopWebApi.Infrastructure.MSDataBase
{
    public class MSDataBaseContext:DbContext
    {
        public MSDataBaseContext(DbContextOptions<MSDataBaseContext>options) :base(options){ }

        DbSet<Producer> Producers { get; set; }
    }
}
