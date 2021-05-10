using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopWebApi.Core.Domain.Entieties
{
    class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AddressUrl { get; set; }
    }
}
